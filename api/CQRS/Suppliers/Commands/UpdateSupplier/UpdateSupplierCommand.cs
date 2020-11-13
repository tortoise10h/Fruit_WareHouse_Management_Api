using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Suppliers;
using MediatR;

namespace api.CQRS.Suppliers.Commands.UpdateSupplier
{
    public class UpdateSupplierCommand : IRequest<SupplierResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Representative { get; set; }
        public SupplierStatus Status { get; set; }
    }
}