using api.Common.Enums;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Contracts.V1.ResponseModels.ProductUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.Products
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string DefaultUnit { get; set; }
        public double PurchasePrice { get; set; }
        public double Price { get; set; }
        public ProductStatus Status { get; set; }
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }
        public int? MinQuantity { get; set; }
        public int? MaxQuantity { get; set; }
        public DateTime LastSaledDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityForSale { get; set; }
        public double QuantityReturned { get; set; }

        public ProductCategoryResponse ProductCategory { get; set; }
        public IEnumerable<ProductUnitResponse> ProductUnits { get; set; }
    }
}
