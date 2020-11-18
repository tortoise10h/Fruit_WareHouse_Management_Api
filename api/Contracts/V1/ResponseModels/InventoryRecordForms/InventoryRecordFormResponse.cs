using System.Collections.Generic;
using api.Common.Enums;
using api.Contracts.V1.ResponseModels.User;

namespace api.Contracts.V1.ResponseModels.InventoryRecordForms
{
    public class InventoryRecordFormResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public InventoryRecordFormStatus Status { get; set; }
        public UserResponse User { get; set; }
        public List<InventoryRecordDetailResponse> InventoryRecordDetails { get; set; }
    }
}