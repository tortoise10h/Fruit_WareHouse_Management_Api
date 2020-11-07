using api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace api.Entities
{
    public class Product: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string DefaultUnit { get; set; }
        public double PurchasePrice { get; set; }
        public double Price { get; set; }
        public ProductStatus Status { get; set; }
        public double Quantity { get; set; }
        public int ProductCategoryId { get; set; }
        public double? MinQuantity { get; set; }
        public double? MaxQuantity { get; set; }
        public DateTime? LastSaledDate { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityForSale { get; set; }
        public double QuantityReturned { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public ICollection<PurchaseProposalDetail> PurchaseProposalDetails { get; set; }
        public ICollection<ProductUnit> ProductUnits { get; set; }
    }
}
