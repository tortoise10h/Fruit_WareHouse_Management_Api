using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class GoodsDeliveryNote : BaseEntity
    {
        public int Id { get; set; }
        public GoodsDeliveryNoteStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<GoodsDeliveryDetail> GoodsDeliveryDetails { get; set; }
        public ICollection<MerchandiseReturnProposal> MerchandiseReturnProposals { get; set; }
        public Order Order { get; set; }
    }
}
