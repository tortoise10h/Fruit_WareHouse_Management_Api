using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Products;

namespace api.Contracts.V1.ResponseModels.MerchandiseReturnProposals
{
    public class MerchandiseReturnDetailResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public int QuantityRemoved { get; set; }
        public string Description { get; set; }
        public ProductResponse Product { get; set; }
    }
}