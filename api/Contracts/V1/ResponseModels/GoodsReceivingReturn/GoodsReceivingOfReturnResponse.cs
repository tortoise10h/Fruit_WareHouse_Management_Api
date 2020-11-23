using System.Collections.Generic;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.User;

namespace api.Contracts.V1.ResponseModels.GoodsReceivingReturn
{
    public class GoodsReceivingOfReturnResponse
    {
        public int Id { get; set; }
        public int MerchandiseReturnProposalId { get; set; }
        public GoodsReceivingOfReturnStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public UserResponse User { get; set; }
        public List<GoodsReceivingOfReturnDetailResponse> GoodsReceivingOfReturnDetails { get; set; }
    }
}