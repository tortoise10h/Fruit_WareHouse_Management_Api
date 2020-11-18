using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Helpers;
using api.IServices;

namespace api.Services
{
    public class InventoryRecordFormServices : IInventoryRecordFormServices
    {
        private readonly DataContext _context;

        public InventoryRecordFormServices(DataContext context)
        {
            _context = context;
        }

        public void ValidateValidNewStatus(InventoryRecordFormStatus oldSatus, InventoryRecordFormStatus newStatus)
        {
            if (newStatus == InventoryRecordFormStatus.New)
            {
                /** Only allow to switch Pending -> New */
                if (oldSatus != InventoryRecordFormStatus.Pending &&
                    oldSatus != InventoryRecordFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu kiểm kho về trạng thái 'Mới' khi trạng thái hiện tại của phiếu là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == InventoryRecordFormStatus.Pending)
            {
                /** Only New -> Pending */
                if (oldSatus != InventoryRecordFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu kiểm kho thành 'Chờ duyệt' khi trạng thái hiện tại là 'Mới'"));
                }

            }
            else if (newStatus == InventoryRecordFormStatus.Approved)
            {
                /** Only Pending -> Approved */
                if (oldSatus != InventoryRecordFormStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép duyệt phiếu kiểm kho khi trạng thái hiện tại là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == InventoryRecordFormStatus.Done)
            {
                /** Only Approved -> Done */
                if (oldSatus != InventoryRecordFormStatus.Approved)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép 'Hoàn tất' phiếu kiểm kho khi trạng thái hiện tại của phiếu là 'Đã duyệt'"));
                }
            }
            else if (newStatus == InventoryRecordFormStatus.Cancelled)
            {
                if (oldSatus == InventoryRecordFormStatus.Done ||
                    oldSatus == InventoryRecordFormStatus.Cancelled)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được huỷ phiếu kiểm kho khi trạng thái hiện tại của nó khác 'Hoàn tất' và 'Đã huỷ'"));
                }
            }

        }
    }
}