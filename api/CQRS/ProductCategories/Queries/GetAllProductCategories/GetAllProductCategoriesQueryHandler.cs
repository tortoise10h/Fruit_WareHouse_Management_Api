using System;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Helpers;
using MediatR;

namespace api.CQRS.ProductCategories.Queries.GetAllProductCategories
{
    public class GetAllProductCategoriesQueryHandler : IRequestHandler<GetAllProductCategoriesQuery, PagedResponse<ProductCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllProductCategoriesQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<PagedResponse<ProductCategoryResponse>> Handle(GetAllProductCategoriesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.ProductCategories.AsQueryable();
            return await _paginationHelper.Paginate<Entities.ProductCategory, ProductCategoryResponse>(
                queryable, query
            );
        }
    }
}
