using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace api.Contracts.V1.Dtos
{
    public class ProductInGoodsReceivingNote
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double SinglePurchasePrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
