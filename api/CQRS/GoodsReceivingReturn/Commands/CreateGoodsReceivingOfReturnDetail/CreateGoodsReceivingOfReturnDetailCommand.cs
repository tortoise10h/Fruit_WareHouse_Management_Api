using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturnDetail
{
    public class CreateGoodsReceivingOfReturnDetailCommand : IRequest<Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        public int GoodsReceivingOfReturnId { get; set; }
        public List<CreateProductInGoodsReceivingOfReturnDetail> Products { get; set; }
    }

    public class CreateGoodsReceivingOfReturnDetailHandler : IRequestHandler<CreateGoodsReceivingOfReturnDetailCommand, Result<List<GoodsReceivingOfReturnDetailResponse>>>
    {
        private readonly DataContext _context;

        public CreateGoodsReceivingOfReturnDetailHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<List<GoodsReceivingOfReturnDetailResponse>>> Handle(CreateGoodsReceivingOfReturnDetailCommand request, CancellationToken cancellationToken)
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
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu nhập kho trả hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            throw new NotImplementedException();
        }
    }
}