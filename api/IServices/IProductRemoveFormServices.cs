using api.Common.Enums;

namespace api.IServices
{
    public interface IProductRemoveFormServices
    {
        void ValidateValidNewStatus(ProductRemoveFormStatus oldSatus, ProductRemoveFormStatus newStatus);
    }
}