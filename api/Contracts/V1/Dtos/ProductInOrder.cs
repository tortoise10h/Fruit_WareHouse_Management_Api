using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.Dtos
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double SinglePrice { get; set; }
    }
}
