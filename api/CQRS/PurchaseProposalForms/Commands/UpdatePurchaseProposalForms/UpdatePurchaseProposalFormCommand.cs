using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using api.Contracts.V1.Exceptions;
using api.Common.Enums;
using api.Helpers;
using E = api.Entities;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;

namespace api.CQRS.PurchaseProposalForms.Commands.UpdateProducts
{
    public class UpdatePurchaseProposalFormCommand : IRequest<Result<PurchaseProposalFormResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public PurchaseProposalFormStatus Status { get; set; }
    }

    public class UpdatePurchaseProposalHandler : IRequestHandler<UpdatePurchaseProposalFormCommand, Result<PurchaseProposalFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdatePurchaseProposalHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<PurchaseProposalFormResponse>> Handle(UpdatePurchaseProposalFormCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //var product = await _context.Products
            //    .SingleOrDefaultAsync(
            //        p => p.Id == request.Id
            //    );
            //if (product == null)
            //{
            //    return new Result<PurchaseProposalFormResponse>(
            //        new NotFoundException()
            //    );
            //}

            ///** That's mean user want to update category of product */
            //if (request.ProductCategoryId != product.ProductCategoryId)
            //{
            //    var productCategory = await _context.ProductCategories
            //        .SingleOrDefaultAsync(pc => pc.Id == request.ProductCategoryId);

            //    if (productCategory == null)
            //    {
            //        return new Result<PurchaseProposalFormResponse>(
            //            new NotFoundException()
            //        );
            //    }
            //}

            //_mapper.Map<UpdatePurchaseProposalFormCommand, E.Product>(request, product);

            //_context.Products.Update(product);
            //var updated = await _context.SaveChangesAsync();

            //if (updated > 0)
            //{
            //    return new Result<PurchaseProposalFormResponse>(
            //        _mapper.Map<PurchaseProposalFormResponse>(product)
            //    );
            //}

            //return new Result<PurchaseProposalFormResponse>(
            //    new BadRequestException(
            //        new ApiError("Chỉnh sửa thông tin sản phẩm thất bại, xin thử lại"))
            //);
        }
    }
}