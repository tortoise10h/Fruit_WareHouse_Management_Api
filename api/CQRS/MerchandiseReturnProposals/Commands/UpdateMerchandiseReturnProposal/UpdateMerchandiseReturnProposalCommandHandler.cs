using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnProposal
{
    public class UpdateMerchandiseReturnProposalCommandHandler : IRequestHandler<UpdateMerchandiseReturnProposalCommand, MerchandiseReturnProposalResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateMerchandiseReturnProposalCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<MerchandiseReturnProposalResponse> Handle(UpdateMerchandiseReturnProposalCommand request, CancellationToken cancellationToken)
        {
            var merchandiseReturnProposal = await _context.MerchandiseReturnProposals
                .Include(x => x.MerchandiseReturnDetails)
                .SingleOrDefaultAsync(x => x.Id == request.Id);

            if (merchandiseReturnProposal == null)
            {
                throw new NotFoundException();
            }

            if (request.Status == MerchandiseReturnProposalStatus.Processing)
            {
                var merchandiseReturnDetails = merchandiseReturnProposal.MerchandiseReturnDetails;

                var goodsDeliveryDetails = await _context.GoodsDeliveryDetails
                              .Where(gdd => gdd.GoodsDeliveryNoteId == merchandiseReturnProposal.GoodsDeliveryNoteId)
                              .ToListAsync();

                foreach (var merchandiseReturnDetail in merchandiseReturnDetails)
                {
                    var matchedGoodsDeliveryDetail = goodsDeliveryDetails
                        .SingleOrDefault(x => x.ProductId == merchandiseReturnDetail.ProductId);

                    matchedGoodsDeliveryDetail.QuantityReturned += merchandiseReturnDetail.QuantityReturned;
                }
            }

            if (request.Status == MerchandiseReturnProposalStatus.Cancelled && merchandiseReturnProposal.Status != MerchandiseReturnProposalStatus.New)
            {
                //TODO: Cho phép Cancel khi Processing nhưng chưa có phiếu nhập kho
                throw new BadRequestException(
                    new ApiError("Chỉ cho phép thay đổi trạng thái thành 'Hủy' khi phiếu đề nghị trả hàng đang ở trạng thái 'Mới'"));
            }

            _mapper.Map(request, merchandiseReturnProposal);

            await _context.SaveChangesAsync();

            return _mapper.Map<MerchandiseReturnProposalResponse>(merchandiseReturnProposal);
        }
    }
}