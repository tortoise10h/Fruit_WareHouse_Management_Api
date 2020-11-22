using System.Collections.Generic;
using System.Linq;
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

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkCreateMerchandiseReturnDetail
{
    public class BulkCreateMerchandiseReturnDetailCommandHandler : IRequestHandler<BulkCreateMerchandiseReturnDetailCommand, List<MerchandiseReturnDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BulkCreateMerchandiseReturnDetailCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<MerchandiseReturnDetailResponse>> Handle(BulkCreateMerchandiseReturnDetailCommand request, CancellationToken cancellationToken)
        {
            var merchandiseReturnProposal = await _context.MerchandiseReturnProposals
                .SingleOrDefaultAsync(mrp => mrp.Id == request.MerchandiseReturnProposalId);

            if (merchandiseReturnProposal == null)
            {
                throw new NotFoundException();
            }

            if (merchandiseReturnProposal.Status != MerchandiseReturnProposalStatus.New)
            {
                throw new BadRequestException(new ApiError("Chỉ được thêm sản phẩm khi phiếu đề nghị trả hàng ở trạng thái 'Mới'"));
            }

            /** Make sure all product id in list is unique */
            var merchandiseReturnDetails = request.MerchandiseReturnDetails
                .GroupBy(x => x.ProductId)
                .Select(x => x.First());

            /**  Check new product returns must not exist on the existed merchandise return details */
            var newProductIds = merchandiseReturnDetails.Select(x => x.ProductId);

            var duplicateMerchandiseReturnDetails = await _context.MerchandiseReturnDetails
                .Where(x => x.MerchandiseReturnProposalId == request.MerchandiseReturnProposalId &&
                    newProductIds.Contains(x.ProductId))
                .ToListAsync();

            if (duplicateMerchandiseReturnDetails.Count() > 0)
            {
                var duplicateProductIds = duplicateMerchandiseReturnDetails.Select(x => x.ProductId);
                throw new BadRequestException(new ApiError("Sản phẩm id " + string.Join(", ", duplicateProductIds) + " đã tồn tại trong phiếu trả hàng"));
            }

            /** Check new product returns must exist on the delivery note */
            var goodsDeliveryDetails = await _context.GoodsDeliveryDetails
                .Where(gdnd => gdnd.GoodsDeliveryNoteId == merchandiseReturnProposal.GoodsDeliveryNoteId)
                .ToListAsync();

            string errorResponse = "";

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
                throw new BadRequestException(new ApiError(errorResponse));
            }

            var merchandiseReturnDetailEntities = _mapper.Map<List<MerchandiseReturnDetail>>(merchandiseReturnDetails);
            foreach (var merchandiseReturnDetailEntity in merchandiseReturnDetailEntities)
            {
                merchandiseReturnDetailEntity.MerchandiseReturnProposal = merchandiseReturnProposal;
            }

            await _context.AddRangeAsync(merchandiseReturnDetailEntities);
            await _context.SaveChangesAsync();

            return _mapper.Map<List<MerchandiseReturnDetailResponse>>(merchandiseReturnDetailEntities);
        }
    }
}