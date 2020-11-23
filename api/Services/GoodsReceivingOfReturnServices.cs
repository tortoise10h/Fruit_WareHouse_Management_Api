using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Helpers;
using api.IServices;

namespace api.Services
{
    public class GoodsReceivingOfReturnServices : IGoodsReceivingOfReturnServices
    {
        private readonly DataContext _context;

        public GoodsReceivingOfReturnServices(DataContext context)
        {
            _context = context;
        }

        public void ValidateValidNewStatus(GoodsReceivingOfReturnStatus oldSatus, GoodsReceivingOfReturnStatus newStatus)
        {
            if (newStatus == GoodsReceivingOfReturnStatus.New)
            {
                /** Only allow to switch Pending -> New */
                if (oldSatus != GoodsReceivingOfReturnStatus.Pending &&
                    oldSatus != GoodsReceivingOfReturnStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu kiểm kho về trạng thái 'Mới' khi trạng thái hiện tại của phiếu là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == GoodsReceivingOfReturnStatus.Pending)
            {
                /** Only New -> Pending */
                if (oldSatus != GoodsReceivingOfReturnStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu kiểm kho thành 'Chờ duyệt' khi trạng thái hiện tại là 'Mới'"));
                }

            }
            else if (newStatus == GoodsReceivingOfReturnStatus.Approved)
            {
                /** Only Pending -> Approved */
                if (oldSatus != GoodsReceivingOfReturnStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép duyệt phiếu kiểm kho khi trạng thái hiện tại là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == GoodsReceivingOfReturnStatus.Done)
            {
                /** Only Approved -> Done */
                if (oldSatus != GoodsReceivingOfReturnStatus.Approved)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép 'Hoàn tất' phiếu kiểm kho khi trạng thái hiện tại của phiếu là 'Đã duyệt'"));
                }
            }
            else if (newStatus == GoodsReceivingOfReturnStatus.Cancelled)
            {
                if (oldSatus == GoodsReceivingOfReturnStatus.Done ||
                    oldSatus == GoodsReceivingOfReturnStatus.Cancelled)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được huỷ phiếu kiểm kho khi trạng thái hiện tại của nó khác 'Hoàn tất' và 'Đã huỷ'"));
                }
            }

        }
    }
}