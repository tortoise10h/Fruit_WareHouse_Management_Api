using api.Common.Enums;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.PurchaseProposalForms
{
    public class PurchaseProposalFormResponse
    {
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public PurchaseProposalFormStatus Status { get; set; }
        public PurchaseProposalFormOnTimeOrNotStatus OnTimeOrNotStatus { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }

        public IEnumerable<PurchaseProposalDetailResponse> PurchaseProposalDetails { get; set; }
        public IEnumerable<GoodsReceivingNoteResponse> GoodsReceivingNotes { get; set; }
        public UserResponse User { get; set; }
    }
}
