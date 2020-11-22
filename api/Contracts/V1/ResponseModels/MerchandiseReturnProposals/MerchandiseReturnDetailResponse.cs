using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.MerchandiseReturnProposals
{
    public class MerchandiseReturnDetailResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public ProductResponse Product { get; set; }
    }
}