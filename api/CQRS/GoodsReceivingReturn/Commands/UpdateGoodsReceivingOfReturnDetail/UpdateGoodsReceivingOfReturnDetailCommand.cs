using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturnDetail
{
    public class UpdateGoodsReceivingOfReturnDetailCommand : IRequest<Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        public int GoodsReceivingOfReturnId { get; set; }
        public List<UpdateProductInGoodsReceivingOfReturnDetail> GoodsReceivingOfReturnDetails { get; set; }
    }

    public class UpdateGoodsReceivingOfReturnDetailHandler : IRequestHandler<UpdateGoodsReceivingOfReturnDetailCommand, Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateGoodsReceivingOfReturnDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<GoodsReceivingOfReturnDetailResponse>>> Handle(UpdateGoodsReceivingOfReturnDetailCommand request, CancellationToken cancellationToken)
        {
            var goodsReceivingReturn = await _context.GoodsReceivingOfReturns.SingleOrDefaultAsync(
                grr => grr.Id == request.GoodsReceivingOfReturnId
            );

            if (goodsReceivingReturn == null)
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can add new products to goods receiving return when it is
             * New */
            if (goodsReceivingReturn.Status != GoodsReceivingOfReturnStatus.New)
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật sản phẩm vào phiếu nhập kho trả hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            var grrds = request.GoodsReceivingOfReturnDetails
                .Select(p => p.Id)
                .ToList();

            // Validate goods receiving detail is unique
            var distinctGoodsReceivingOfReturnDetails = request.GoodsReceivingOfReturnDetails
                .Select(p => p.Id)
                .Distinct()
                .ToList();

            if (grrds.Count() != distinctGoodsReceivingOfReturnDetails.Count())
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Id của phiếu nhập kho trả hàng phải là duy nhất")
                    )
                );
            }

            // Validate goods receiving detail exist
            var goodsReceivingOfReturnDetails = await _context.GoodsReceivingOfReturnDetails
                .Where(grrd => grrd.GoodsReceivingOfReturnId == request.GoodsReceivingOfReturnId &&
                        grrds.Contains(grrd.Id))
                .ToListAsync();

            if (distinctGoodsReceivingOfReturnDetails.Count() != goodsReceivingOfReturnDetails.Count())
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Phiếu nhập kho trả hàng không tồn tại")
                    )
                );
            }

            var productIds = goodsReceivingOfReturnDetails
                .Select(grrd => grrd.ProductId)
                .ToList();

            var products = await _context.MerchandiseReturnDetails
                .Where(p => productIds.Contains(p.ProductId) &&
                        p.MerchandiseReturnProposalId == goodsReceivingReturn.MerchandiseReturnProposalId)
                .ToListAsync();

            foreach (var g in goodsReceivingOfReturnDetails)
            {
                var check = request.GoodsReceivingOfReturnDetails
                    .FirstOrDefault(x => x.Id == g.Id);

                var check2 = products
                    .FirstOrDefault(x => x.ProductId == g.ProductId);

                if (check.Quantity + check2.QuantityReturned > check2.Quantity)
                {
                    return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                        new BadRequestException(
                            new ApiError("Số lượng của sản phẩm trong phiếu trả hàng nhập kho không được lớn hơn số lượng trả hàng")
                        )
                    );
                }

                g.Description = check.Description;
                g.Quantity = check.Quantity;
            }

            _context.GoodsReceivingOfReturnDetails.UpdateRange(goodsReceivingOfReturnDetails);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingOfReturnDetailResponse>>(goodsReceivingOfReturnDetails)
                );
            }

            return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                new BadRequestException(
                    new ApiError("Cập nhật sản phẩm trong phiếu nhập kho trả hàng lỗi, xin thử lại"))
            );
        }
    }
}