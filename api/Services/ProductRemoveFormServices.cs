using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Helpers;
using api.IServices;

namespace api.Services
{
    public class ProductRemoveFormServices : IProductRemoveFormServices
    {
        private readonly DataContext _context;

        public ProductRemoveFormServices(DataContext context)
        {
            _context = context;
        }

        public void ValidateValidNewStatus(ProductRemoveFormStatus oldSatus, ProductRemoveFormStatus newStatus)
        {
            if (newStatus == ProductRemoveFormStatus.New)
            {
                /** Only allow to switch Pending -> New */
                if (oldSatus != ProductRemoveFormStatus.Pending &&
                    oldSatus != ProductRemoveFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu huỷ sản phẩm trong kho về trạng thái 'Mới' khi trạng thái hiện tại của phiếu là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == ProductRemoveFormStatus.Pending)
            {
                /** Only New -> Pending */
                if (oldSatus != ProductRemoveFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu huỷ sản phẩm trong kho thành 'Chờ duyệt' khi trạng thái hiện tại là 'Mới'"));
                }

            }
            else if (newStatus == ProductRemoveFormStatus.Approved)
            {
                /** Only Pending -> Approved */
                if (oldSatus != ProductRemoveFormStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép duyệt phiếu huỷ sản phẩm trong kho khi trạng thái hiện tại là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == ProductRemoveFormStatus.Done)
            {
                /** Only Approved -> Done */
                if (oldSatus != ProductRemoveFormStatus.Approved)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép 'Hoàn tất' phiếu huỷ sản phẩm trong kho khi trạng thái hiện tại của phiếu là 'Đã duyệt'"));
                }
            }
            else if (newStatus == ProductRemoveFormStatus.Cancelled)
            {
                if (oldSatus == ProductRemoveFormStatus.Done ||
                    oldSatus == ProductRemoveFormStatus.Cancelled)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được huỷ phiếu huỷ sản phẩm trong kho khi trạng thái hiện tại của nó khác 'Hoàn tất' và 'Đã huỷ'"));
                }
            }
        }
    }
}