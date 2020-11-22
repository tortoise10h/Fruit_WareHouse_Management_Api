using System.Collections.Generic;
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

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkUpdateMerchandiseReturnDetail
{
    public class BulkUpdateMerchandiseReturnDetailCommandHandler : IRequestHandler<BulkUpdateMerchandiseReturnDetailCommand, List<MerchandiseReturnDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BulkUpdateMerchandiseReturnDetailCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<MerchandiseReturnDetailResponse>> Handle(BulkUpdateMerchandiseReturnDetailCommand request, CancellationToken cancellationToken)
        {
            var merchandiseReturnProposal = await _context.MerchandiseReturnProposals
                 .SingleOrDefaultAsync(mrp => mrp.Id == request.MerchandiseReturnProposalId);

            if (merchandiseReturnProposal == null)
            {
                throw new NotFoundException();
            }

            if (merchandiseReturnProposal.Status != MerchandiseReturnProposalStatus.New)
            {
                throw new BadRequestException(new ApiError("Chỉ được chỉnh sửa sản phẩm khi phiếu đề nghị trả hàng ở trạng thái 'Mới'"));
            }

            /** Make sure all id in list is unique */
            var updateMerchandiseReturnDetails = request.MerchandiseReturnDetails
                .GroupBy(x => x.Id)
                .Select(x => x.First());

            /** Check update item must exist in database */
            var updateMerchandiseReturnDetailIds = updateMerchandiseReturnDetails.Select(x => x.Id);

            var merchandiseReturnDetailEntities = await _context.MerchandiseReturnDetails
                .Where(x => x.MerchandiseReturnProposalId == request.MerchandiseReturnProposalId &&
                    updateMerchandiseReturnDetailIds.Contains(x.Id))
                .ToListAsync();

            if (merchandiseReturnDetailEntities.Count() != updateMerchandiseReturnDetailIds.Count())
            {
                throw new NotFoundException();
            }

            foreach (var merchandiseReturnDetailEntity in merchandiseReturnDetailEntities)
            {
                var newData = updateMerchandiseReturnDetails
                    .SingleOrDefault(x => x.Id == merchandiseReturnDetailEntity.Id);

                // Map new data to entity
                _mapper.Map(newData, merchandiseReturnDetailEntity);

            }

            // Validate new data
            var goodsDeliveryDetails = await _context.GoodsDeliveryDetails
                .Where(gdnd => gdnd.GoodsDeliveryNoteId == merchandiseReturnProposal.GoodsDeliveryNoteId)
                .ToListAsync();

            string errorResponse = "";
            foreach (var merchandiseReturnDetailEntity in merchandiseReturnDetailEntities)
            {
                var matchedGoodsDeliveryDetail = goodsDeliveryDetails
                    .SingleOrDefault(x => x.ProductId == merchandiseReturnDetailEntity.ProductId);

                if (merchandiseReturnDetailEntity.Quantity > matchedGoodsDeliveryDetail.Quantity - matchedGoodsDeliveryDetail.QuantityReturned)
                {
                    errorResponse += $"Số lượng trả lại của sản phẩm với id[{ merchandiseReturnDetailEntity.ProductId}] là: { merchandiseReturnDetailEntity.Quantity} lớn hơn số lượng đã xuất kho (đã trừ số lượng những lần trả lại trước nếu có): { matchedGoodsDeliveryDetail.Quantity - matchedGoodsDeliveryDetail.QuantityReturned}< br /> ";
                }
            }

            if (!errorResponse.Equals(""))
            {
                throw new BadRequestException(new ApiError(errorResponse));
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<List<MerchandiseReturnDetailResponse>>(merchandiseReturnDetailEntities);
        }
    }
}