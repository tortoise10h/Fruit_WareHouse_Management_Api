using System.Collections.Generic;
using MediatR;

namespace api.CQRS.Suppliers.Commands.RemoveProductsFromSupplier
{
    public class RemoveProductsFromSupplierCommand : IRequest<Unit>
    {
        public int SupplierId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}