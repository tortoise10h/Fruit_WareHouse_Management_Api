using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommand : IRequest<SupplierResponse>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Representative { get; set; }
    }
}