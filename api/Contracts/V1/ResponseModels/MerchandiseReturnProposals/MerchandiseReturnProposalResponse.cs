using System.Collections.Generic;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.User;

namespace api.Contracts.V1.ResponseModels.MerchandiseReturnProposals
{
    public class MerchandiseReturnProposalResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public MerchandiseReturnProposalStatus Status { get; set; }
        public ICollection<MerchandiseReturnDetailResponse> MerchandiseReturnDetails { get; set; }
        public GoodsDeliveryNoteResponse GoodsDeliveryNote { get; set; }
        public UserResponse User { get; set; }
    }
}