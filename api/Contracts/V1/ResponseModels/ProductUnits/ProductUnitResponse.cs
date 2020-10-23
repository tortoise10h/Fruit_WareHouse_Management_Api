using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.ProductUnits
{
    public class ProductUnitResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RatioFromDefault { get; set; }
    }
}
