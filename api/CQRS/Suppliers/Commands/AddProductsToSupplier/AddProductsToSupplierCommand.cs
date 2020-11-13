using System.Collections.Generic;
using api.Contracts.V1.Dtos;
using MediatR;

namespace api.CQRS.Suppliers.Commands.AddProductsToSupplier
{
    public class AddProductsToSupplierCommand : IRequest<Unit>
    {
        public int SupplierId { get; set; }
        public List<AddProductToSupplierDTO> Products { get; set; }
    }
}