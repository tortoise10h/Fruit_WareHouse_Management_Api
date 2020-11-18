using api.Common.Enums;

namespace api.IServices
{
    public interface IInventoryRecordFormServices
    {
        void ValidateValidNewStatus(InventoryRecordFormStatus oldSatus, InventoryRecordFormStatus newStatus);
    }
}