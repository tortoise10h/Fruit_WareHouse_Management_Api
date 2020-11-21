using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.Statistics
{
    public class BestSellingProductsStatisticResponse
    {
        public int NumberOfProducts { get; set; }
        public int ProductId { get; set; }
        public double TotalQuantitySold { get; set; }
        public double TotalPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDefaultUnit { get; set; }
    }
}
