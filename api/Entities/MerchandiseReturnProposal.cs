using System.Collections.Generic;
using api.Common.Enums;

namespace api.Entities
{
    public class MerchandiseReturnProposal : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public MerchandiseReturnProposalStatus Status { get; set; }
        public int GoodsDeliveryNoteId { get; set; }
        public GoodsDeliveryNote GoodsDeliveryNote { get; set; }
        public ICollection<MerchandiseReturnDetail> MerchandiseReturnDetails { get; set; }
        public ICollection<GoodsReceivingOfReturn> GoodsReceivingOfReturns { get; set; }
        public ApplicationUser User { get; set; }
    }
}