using System.Collections.Generic;
using api.Common.Enums;

namespace api.Entities
{
    public class ProductRemoveForm : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public ProductRemoveFormStatus Status { get; set; }
        public ICollection<ProductRemoveDetail> ProductRemoveDetails { get; set; }
        public ApplicationUser User { get; set; }
    }
}