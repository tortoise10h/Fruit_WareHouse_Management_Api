using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class GoodsReceivingNote: BaseEntity
    {
        public int Id { get; set; }
        public GoodsReceivingNoteStatus Status { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierId { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public int PurchaseProposalFormId { get; set; }
        public double TotalPrice { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<GoodsReceivingDetail> GoodsReceivingDetails { get; set; }
        public PurchaseProposalForm PurchaseProposalForm { get; set; }
    }
}
