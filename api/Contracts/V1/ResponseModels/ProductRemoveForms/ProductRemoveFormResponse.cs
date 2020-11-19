using System.Collections.Generic;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.User;

namespace api.Contracts.V1.ResponseModels.ProductRemoveForms
{
    public class ProductRemoveFormResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public ProductRemoveFormStatus Status { get; set; }
        public UserResponse User { get; set; }
        public List<ProductRemoveDetailResponse> ProductRemoveDetails { get; set; }
    }
}