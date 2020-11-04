using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.ProductCategories.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommandHandler : IRequestHandler<DeleteProductCategoryCommand, ProductCategoryResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public DeleteProductCategoryCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCategoryResponse> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategories = await _context.ProductCategories.SingleOrDefaultAsync(pc => pc.Id == request.Id);

            if (productCategories == null)
            {
                throw new NotFoundException("Danh mục sản phẩm không tồn tại");
            }

            var productOfCategory = await _context.Products.FirstOrDefaultAsync(p => p.ProductCategoryId == request.Id);
            if (productOfCategory != null)
            {
                throw new BadRequestException(new ApiError("Chỉ có thể xóa danh mục không chứa sản phẩm"));
            }

            _context.ProductCategories.Remove(productCategories);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductCategoryResponse>(productCategories);
        }
    }
}