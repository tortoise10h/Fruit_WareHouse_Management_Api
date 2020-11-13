using api.Common.Enums;
using System.Collections.Generic;

namespace api.Contracts.V1.ResponseModels.Suppliers
{
    public class SupplierResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Representative { get; set; }

        public SupplierStatus Status { get; set; }
        public List<SupplierProductResponse> SupplierProducts { get; set; }
    }
}