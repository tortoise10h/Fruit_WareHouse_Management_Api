using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Products;
using MediatR;

namespace api.CQRS.Suppliers.Queries.GetAllSupplierProducts
{
    public class GetAllSupplierProductsQuery : PaginationQuery, IRequest<PagedResponse<ProductResponse>>
    {
        public int SupplierId { get; set; }
    }
}