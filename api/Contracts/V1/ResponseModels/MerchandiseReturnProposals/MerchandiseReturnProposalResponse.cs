using System.Collections.Generic;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;

namespace api.Contracts.V1.ResponseModels.MerchandiseReturnProposals
{
    public class MerchandiseReturnProposalResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public MerchandiseReturnProposalStatus Status { get; set; }
        public ICollection<MerchandiseReturnDetailResponse> MerchandiseReturnDetailResponses { get; set; }
        public GoodsDeliveryNoteResponse GoodsDeliveryNoteResponse { get; set; }
    }
}