using System.Collections.Generic;
using api.Common.Enums;

namespace api.Entities
{
    public class Supplier : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Representative { get; set; }
        public SupplierStatus Status { get; set; }
        public ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}