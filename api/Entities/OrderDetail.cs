using api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class OrderDetail: BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double QuantityNeed { get; set; }
        public double QuantitySold { get; set; }
        public double QuantityReturned { get; set; }
        public string Description { get; set; }
        public double SinglePrice { get; set; }
        public double TotalPrice { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
