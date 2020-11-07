using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms
{
    public class CreatePurchaseProposalDetailCommand : IRequest<Result<PurchaseProposalDetailResponse>>
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CreatePurchaseProposalDetailHandler : IRequestHandler<CreatePurchaseProposalDetailCommand, Result<PurchaseProposalDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreatePurchaseProposalDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<PurchaseProposalDetailResponse>> Handle(
            CreatePurchaseProposalDetailCommand request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            ///** Make sure the category of product is existed */
            //var productCategory = await _context.ProductCategories
            //    .SingleOrDefaultAsync(
            //        pc => pc.Id == request.ProductCategoryId);
            //if (productCategory == null)
            //{
            //    return new Result<PurchaseProposalDetailResponse>(
            //        new NotFoundException()
            //    );
            //}

            //var product = _mapper.Map<E.Product>(request);
            //product.Status = ProductStatus.Available;

            //await _context.Products.AddAsync(product);
            //var created = await _context.SaveChangesAsync();
            //if (created > 0)
            //{
            //    /** Generate SKU for product */
            //    product.SKU = _productsService.GenerateProductSKU(
            //        productCategory.Name, product.Id);
            //    _context.Products.Update(product);
            //    await _context.SaveChangesAsync();

            //    return new Result<PurchaseProposalDetailResponse>(
            //        _mapper.Map<PurchaseProposalDetailResponse>(product)
            //    );
            //}

            //return new Result<PurchaseProposalDetailResponse>(
            //    new BadRequestException(new ApiError("Tạo sản phẩm thất bại, xin thử lại"))
            //);
        }
    }
}
