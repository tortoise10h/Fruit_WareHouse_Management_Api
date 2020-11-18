using System.Collections.Generic;
using api.Common.Enums;

namespace api.Entities
{
    public class InventoryRecordForm : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public InventoryRecordFormStatus Status { get; set; }
        public ICollection<InventoryRecordDetail> InventoryRecordDetails { get; set; }
        public ApplicationUser User { get; set; }
    }
}