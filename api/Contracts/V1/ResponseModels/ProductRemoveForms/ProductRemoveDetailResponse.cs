using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.ProductRemoveForms
{
    public class ProductRemoveDetailResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ProductRemoveFormId { get; set; }
        public int ProductId { get; set; }
        public double RemovedQuantity { get; set; }
        public ProductResponse Product { get; set; }
    }
}