using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductCategories;
using MediatR;

namespace api.CQRS.Products.Queries
{
    public class GetAllProductCategoriesQuery : PaginationQuery, IRequest<PagedResponse<ProductCategoryResponse>>
    {
    }
}
