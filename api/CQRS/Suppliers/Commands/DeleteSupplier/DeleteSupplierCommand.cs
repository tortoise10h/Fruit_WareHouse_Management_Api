using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Commands.DeleteSupplier
{
    public class DeleteSupplierCommand : IRequest<SupplierResponse>
    {
        public int Id { get; }
        public DeleteSupplierCommand(int id)
        {
            Id = id;
        }

    }
}