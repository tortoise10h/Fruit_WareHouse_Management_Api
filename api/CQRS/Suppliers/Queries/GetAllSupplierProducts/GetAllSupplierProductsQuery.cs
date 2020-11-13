using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Queries.GetAllSupplierProducts
{
    public class GetAllSupplierProductsQuery : PaginationQuery, IRequest<PagedResponse<SupplierProductResponse>>
    {
        public int SupplierId { get; set; }
    }
}