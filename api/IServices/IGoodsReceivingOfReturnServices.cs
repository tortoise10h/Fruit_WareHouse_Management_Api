using api.Common.Enums;

namespace api.IServices
{
    public interface IGoodsReceivingOfReturnServices
    {
        void ValidateValidNewStatus(GoodsReceivingOfReturnStatus oldSatus, GoodsReceivingOfReturnStatus newStatus);
    }
}