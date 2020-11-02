using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;

namespace api.CQRS.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryHandler : IRequestHandler<CreateProductCategoryCommand, ProductCategoryResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateProductCategoryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCategoryResponse> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategory = _mapper.Map<ProductCategory>(request);
            await _context.ProductCategories.AddAsync(productCategory);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductCategoryResponse>(productCategory);
        }
    }
}