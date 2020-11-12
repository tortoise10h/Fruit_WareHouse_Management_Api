using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class Order: BaseEntity
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public double TotalPrice { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
