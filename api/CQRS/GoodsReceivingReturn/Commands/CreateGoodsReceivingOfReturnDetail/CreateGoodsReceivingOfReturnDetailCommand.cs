using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Entities;
using api.Helpers;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public CreateGoodsReceivingOfReturnDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

            var productIds = request.Products
                .Select(p => p.ProductId)
                .ToList();

            // Validate product id is unique
            var distinctProductIds = request.Products
                .Select(p => p.ProductId)
                .Distinct()
                .ToList();

            if (productIds.Count() != distinctProductIds.Count())
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Mỗi sản phẩm chỉ được thêm vào phiếu nhập kho trả hàng 1 lần")
                    )
                );
            }

            var products = await _context.MerchandiseReturnDetails
                .Where(p => productIds.Contains(p.ProductId) &&
                        p.MerchandiseReturnProposalId == goodsReceivingReturn.MerchandiseReturnProposalId)
                .ToListAsync();

            if (distinctProductIds.Count() != products.Count())
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Có sản phẩm không tồn tại trong phiếu đề nghị trả hàng")
                    )
                );
            }

            foreach (var p in products)
            {
                var check = request.Products
                    .FirstOrDefault(x => x.ProductId == p.ProductId);

                if (check.Quantity > p.Quantity)
                {
                    return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                        new BadRequestException(
                            new ApiError("Số lượng của sản phẩm trong phiếu trả hàng nhập kho không được lớn hơn số lượng trả hàng")
                        )
                    );
                }
            }

            var goodsReceivingReturnOfDetails = _mapper.Map<List<GoodsReceivingOfReturnDetail>>(request.Products);
            foreach (var grrd in goodsReceivingReturnOfDetails)
            {
                grrd.GoodsReceivingOfReturnId = request.GoodsReceivingOfReturnId;
            }

            _context.GoodsReceivingOfReturnDetails.AddRange(goodsReceivingReturnOfDetails);

            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                    _mapper.Map<List<GoodsReceivingOfReturnDetailResponse>>(goodsReceivingReturnOfDetails)
                );
            }

            return new Result<List<GoodsReceivingOfReturnDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu nhập kho trả hàng lỗi, xin thử lại"))
            );
        }
    }
}