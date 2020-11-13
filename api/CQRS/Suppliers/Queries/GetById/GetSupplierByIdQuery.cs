using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Queries.GetById
{
    public class GetSupplierByIdQuery : IRequest<SupplierResponse>
    {
        public int Id { get; }
        public GetSupplierByIdQuery(int id)
        {
            Id = id;
        }

    }
}