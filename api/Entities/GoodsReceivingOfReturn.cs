using System.Collections.Generic;
using api.Common.Enums;

namespace api.Entities
{
    public class GoodsReceivingOfReturn : BaseEntity
    {
        public int Id { get; set; }
        public int MerchandiseReturnProposalId { get; set; }
        public GoodsReceivingOfReturnStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<GoodsReceivingOfReturnDetail> GoodsReceivingOfReturnDetails { get; set; }
    }
}