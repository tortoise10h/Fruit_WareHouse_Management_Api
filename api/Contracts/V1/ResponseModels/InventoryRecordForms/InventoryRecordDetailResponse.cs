using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.InventoryRecordForms
{
    public class InventoryRecordDetailResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductResponse Product { get; set; }
        public int InventoryRecordId { get; set; }
        public double ActualQuantity { get; set; }
        public double OldQuantity { get; set; }
    }
}