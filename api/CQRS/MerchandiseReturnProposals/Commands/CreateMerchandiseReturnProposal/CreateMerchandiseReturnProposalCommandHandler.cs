using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal
{
    public class CreateMerchandiseReturnProposalCommandHandler : IRequestHandler<CreateMerchandiseReturnProposalCommand, MerchandiseReturnProposalResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateMerchandiseReturnProposalCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<MerchandiseReturnProposalResponse> Handle(CreateMerchandiseReturnProposalCommand request, CancellationToken cancellationToken)
        {
            var goodsDeliveryNote = await _context.GoodsDeliveryNotes
                .Include(x => x.GoodsDeliveryDetails)
                .SingleOrDefaultAsync(x => x.Id == request.GoodsDeliveryNoteId);

            if (goodsDeliveryNote == null)
            {
                throw new NotFoundException();
            }
            if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.Done)
            {
                throw new BadRequestException(new ApiError("Chỉ được tạo phiếu đề nghị trả hàng cho phiếu xuất kho 'đã hoàn tất'"));
            }

            var goodsDeliveryDetails = goodsDeliveryNote.GoodsDeliveryDetails;

            /** Make sure all product id in list is unique */
            var merchandiseReturnDetails = request.MerchandiseReturnDetails
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();


            string errorResponse = "";

            // Check product returns must exist on the delivery note
            foreach (var merchandiseReturnDetail in merchandiseReturnDetails)
            {
                var matchedGoodsDeliveryDetail = goodsDeliveryDetails
                    .SingleOrDefault(x => x.ProductId == merchandiseReturnDetail.ProductId);

                if (matchedGoodsDeliveryDetail == null)
                {
                    errorResponse += $"Sản phẩm với id [{merchandiseReturnDetail.ProductId}] không tồn tại trong phiếu xuất kho này<br/>";
                }
                else if (merchandiseReturnDetail.Quantity > matchedGoodsDeliveryDetail.Quantity - matchedGoodsDeliveryDetail.QuantityReturned)
                {
                    errorResponse += $"Số lượng trả lại của sản phẩm với id[{ merchandiseReturnDetail.ProductId}] là: { merchandiseReturnDetail.Quantity} lớn hơn số lượng đã xuất kho (đã trừ số lượng những lần trả lại trước nếu có): { matchedGoodsDeliveryDetail.Quantity - matchedGoodsDeliveryDetail.QuantityReturned}< br /> ";
                }
            }

            if (!errorResponse.Equals(""))
            {
                throw new BadRequestException(
                    new ApiError(errorResponse));
            }

            /** Map to entity: merchandiseReturnProposal and merchandiseReturnDetails */
            var merchandiseReturnProposal = _mapper.Map<MerchandiseReturnProposal>(request);
            merchandiseReturnProposal.Status = MerchandiseReturnProposalStatus.New;
            await _context.AddAsync(merchandiseReturnProposal);
            await _context.SaveChangesAsync();

            return _mapper.Map<MerchandiseReturnProposalResponse>(merchandiseReturnProposal);
        }
    }
}