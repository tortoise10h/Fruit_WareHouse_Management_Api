using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Queries.GetAllSuppliers
{
    public class GetAllSuppliersQuery : PaginationQuery, IRequest<PagedResponse<SupplierResponse>>
    {
    }
}