using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class ProductUnit: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RatioFromDefault { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
