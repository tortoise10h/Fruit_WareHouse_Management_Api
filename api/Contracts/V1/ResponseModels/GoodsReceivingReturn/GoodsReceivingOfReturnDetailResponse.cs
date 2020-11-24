using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.GoodsReceivingReturn
{
    public class GoodsReceivingOfReturnDetailResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GoodsReceivingOfReturnId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public ProductResponse Product { get; set; }
    }
}