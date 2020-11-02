using System;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Helpers;
using api.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommandHandler : IRequestHandler<UpdateProductCategoryCommand, ProductCategoryResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UpdateProductCategoryCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCategoryResponse> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategory = await _context.ProductCategories.SingleOrDefaultAsync(pc => pc.Id == request.Id);
            if (productCategory == null)
            {
                throw new NotFoundException("Danh mục sản phẩm không tồn tại");
            }

            _mapper.Map<UpdateProductCategoryCommand, Entities.ProductCategory>(request, productCategory);

            _context.ProductCategories.Update(productCategory);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductCategoryResponse>(productCategory);
        }
    }
}
