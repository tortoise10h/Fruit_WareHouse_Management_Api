using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.GoodsReceivingReturn.Commands.DeleteGoodsReceivingOfReturnDetail
{
    public class DeleteGoodsReceivingOfReturnDetailCommand : IRequest<Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        public int GoodsReceivingOfReturnId { get; set; }
        public List<int> GoodsReceivingOfReturnDetailIds { get; set; }
    }

    public class DeleteGoodsReceivingOfReturnDetailHandler : IRequestHandler<DeleteGoodsReceivingOfReturnDetailCommand, Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteGoodsReceivingOfReturnDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<GoodsReceivingOfReturnDetailResponse>>> Handle(DeleteGoodsReceivingOfReturnDetailCommand request, CancellationToken cancellationToken)
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

            var grrds = request.GoodsReceivingOfReturnDetailIds
                .ToList();

            // Validate goods receiving detail is unique
            var distinctGoodsReceivingOfReturnDetails = request.GoodsReceivingOfReturnDetailIds
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

            _context.GoodsReceivingOfReturnDetails.RemoveRange(goodsReceivingOfReturnDetails);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingOfReturnDetailResponse>>(goodsReceivingOfReturnDetails)
                );
            }

            return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong phiếu nhập kho trả hàng xảy ra lỗi, xin thử lại"))
            );
        }
    }
}