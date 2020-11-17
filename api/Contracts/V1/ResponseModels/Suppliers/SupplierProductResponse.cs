using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.Suppliers
{
    public class SupplierProductResponse
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }

        public ProductResponse Product { get; set; }
    }
}