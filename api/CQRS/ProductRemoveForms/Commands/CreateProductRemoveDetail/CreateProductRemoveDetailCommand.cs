using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveDetail
{
    public class CreateProductRemoveDetailCommand : IRequest<Result<List<ProductRemoveDetailResponse>>>
    {
        public int ProductRemoveFormId { get; set; }
        public List<CreateProductInProductRemoveDetail> Products { get; set; }
    }

    public class CreateProductRemoveDetailHandler : IRequestHandler<CreateProductRemoveDetailCommand, Result<List<ProductRemoveDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateProductRemoveDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<ProductRemoveDetailResponse>>> Handle(CreateProductRemoveDetailCommand request, CancellationToken cancellationToken)
        {
            var productRemoveForm = await _context.ProductRemoveForms.SingleOrDefaultAsync(
                prf => prf.Id == request.ProductRemoveFormId
            );

            if (productRemoveForm == null)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can add new products to product remove for when it is
             * New */
            if (productRemoveForm.Status != ProductRemoveFormStatus.New)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu huỷ sản phẩm khi đang ở trạng thái 'Mới'"))
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
                return new Result<List<ProductRemoveDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Mỗi sản phẩm chỉ được thêm vào phiếu huỷ sản phẩm 1 lần")
                    )
                );
            }

            // Validate products exist
            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (distinctProductIds.Count() != products.Count())
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new NotFoundException()
                );
            }

            var existedProducts = await _context.ProductRemoveDetails
                .Where(prd => prd.ProductRemoveFormId == request.ProductRemoveFormId &&
                        productIds.Contains(prd.ProductId))
                .ToListAsync();

            if (existedProducts.Count() > 0)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Có sản phẩm đã tồn tại ở phiếu huỷ sản phẩm")
                    )
                );
            }

            var productRemoveDetails = _mapper.Map<List<ProductRemoveDetail>>(request.Products);
            foreach (var prd in productRemoveDetails)
            {
                prd.ProductRemoveFormId = request.ProductRemoveFormId;
            }

            _context.ProductRemoveDetails.AddRange(productRemoveDetails);

            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<ProductRemoveDetailResponse>>(
                    _mapper.Map<List<ProductRemoveDetailResponse>>(productRemoveDetails)
                );
            }

            return new Result<List<ProductRemoveDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu huỷ sản phẩm lỗi, xin thử lại"))
            );

        }
    }
}