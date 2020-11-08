using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class GoodsReceivingDetail: BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GoodsReceivingNoteId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
        public GoodsReceivingNote GoodsReceivingNote { get; set; }
    }
}
