using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.InventoryRecordForms.Commands.UpdateInventoryForms
{
    public class UpdateInventoryFormCommand : IRequest<Result<InventoryRecordFormResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public InventoryRecordFormStatus Status { get; set; }
    }

    public class UpdateInventoryFormHandler : IRequestHandler<UpdateInventoryFormCommand, Result<InventoryRecordFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IInventoryRecordFormServices _inventoryRecordFormServices;
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateInventoryFormHandler(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IInventoryRecordFormServices inventoryRecordFormServices, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _inventoryRecordFormServices = inventoryRecordFormServices;
            _userManager = userManager;
        }

        public async Task<Result<InventoryRecordFormResponse>> Handle(UpdateInventoryFormCommand request, CancellationToken cancellationToken)
        {
            var inventoryRecordForm = await _context.InventoryRecordForms.SingleOrDefaultAsync(
                irf => irf.Id == request.Id
            );

            if (inventoryRecordForm == null)
            {
                return new Result<InventoryRecordFormResponse>(
                    new NotFoundException()
                );
            }

            /** Only  allow update inventory record form when it is not Done or Cancelled */
            if (inventoryRecordForm.Status == InventoryRecordFormStatus.Done ||
                inventoryRecordForm.Status == InventoryRecordFormStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Phiếu kiểm kho này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid */
            if (inventoryRecordForm.Status != request.Status)
            {
                _inventoryRecordFormServices.ValidateValidNewStatus(
                    inventoryRecordForm.Status,
                    request.Status);
            }

            /** If the new status is Approved then make sure only role
             * Boss and WarehouseKeeperManager can do */
            if (request.Status == InventoryRecordFormStatus.Approved)
            {
                var currentUserId = _httpContextAccessor.HttpContext.User
                    .Claims
                        .First(x => x.Type == "id").Value;

                var currentUser = await _userManager.FindByIdAsync(currentUserId);
                var roles = await _userManager.GetRolesAsync(currentUser);
                var userRole = roles.FirstOrDefault();

                if (userRole != RoleName.Boss &&
                    userRole != RoleName.WarehouseKeeperManager)
                {
                    return new Result<InventoryRecordFormResponse>(
                        new BadRequestException(
                            new ApiError("Bạn không có quyền để duyệt phiêu nhập kho")));
                }
            }

            _mapper.Map<UpdateInventoryFormCommand, InventoryRecordForm>(request, inventoryRecordForm);
            _context.InventoryRecordForms.Update(inventoryRecordForm);

            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<InventoryRecordFormResponse>(
                    _mapper.Map<InventoryRecordFormResponse>(inventoryRecordForm)
                );
            }

            return new Result<InventoryRecordFormResponse>(
               new BadRequestException(new ApiError("Cập nhật phiếu kiểm kho thất bại, vui lòng thử lại"))
            );
        }
    }
}