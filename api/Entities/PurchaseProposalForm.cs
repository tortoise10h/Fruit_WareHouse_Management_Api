using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class PurchaseProposalForm: BaseEntity
    {
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public PurchaseProposalFormStatus Status { get; set; }
        public PurchaseProposalFormOnTimeOrNotStatus OnTimeOrNotStatus { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<PurchaseProposalDetail> PurchaseProposalDetails { get; set; }
        public ICollection<GoodsReceivingNote> GoodsReceivingNotes { get; set; }
    }
}
