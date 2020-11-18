using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.InventoryRecordForms.Commands.CreateInventoryDetail
{
    public class CreateInventoryDetailCommand : IRequest<Result<List<InventoryRecordDetailResponse>>>
    {
        public int InventoryRecordFormId { get; set; }
        public List<CreateProductInInventoryRecordDetail> Products { get; set; }
    }

    public class CreateInventoryDetailHandler : IRequestHandler<CreateInventoryDetailCommand, Result<List<InventoryRecordDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateInventoryDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<InventoryRecordDetailResponse>>> Handle(CreateInventoryDetailCommand request, CancellationToken cancellationToken)
        {
            var inventoryRecordForm = await _context.InventoryRecordForms.SingleOrDefaultAsync(
                irf => irf.Id == request.InventoryRecordFormId
            );

            if (inventoryRecordForm == null)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can add new products to inventory record form when it is
             * New */
            if (inventoryRecordForm.Status != InventoryRecordFormStatus.New)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu kiểm kho khi đang ở trạng thái 'Mới'"))
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
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Mỗi sản phẩm chỉ được thêm vào phiếu chi tiết kiểm kho 1 lần")
                    )
                );
            }

            // Validate products exist
            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (distinctProductIds.Count() != products.Count())
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new NotFoundException()
                );
            }

            var existedProducts = await _context.InventoryRecordDetails
                .Where(ird => ird.InventoryRecordId == request.InventoryRecordFormId &&
                        productIds.Contains(ird.ProductId))
                .ToListAsync();

            if (existedProducts.Count() > 0)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Có sản phẩm đã tồn tại ở phiếu chi tiết kiểm kho")
                    )
                );
            }

            var inventoryRecordDetail = _mapper.Map<List<InventoryRecordDetail>>(request.Products);
            foreach (var ird in inventoryRecordDetail)
            {
                var product = products
                    .Where(p => p.Id == ird.ProductId)
                    .FirstOrDefault();

                ird.InventoryRecordId = request.InventoryRecordFormId;
                ird.OldQuantity = product.Quantity;
            }

            _context.InventoryRecordDetails.AddRange(inventoryRecordDetail);

            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<InventoryRecordDetailResponse>>(
                    _mapper.Map<List<InventoryRecordDetailResponse>>(inventoryRecordDetail)
                );
            }

            return new Result<List<InventoryRecordDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu kiểm kho lỗi, xin thử lại"))
            );

        }
    }
}