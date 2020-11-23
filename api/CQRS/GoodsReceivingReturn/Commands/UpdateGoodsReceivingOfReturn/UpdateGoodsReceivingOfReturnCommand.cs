using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturn
{
    public class UpdateGoodsReceivingOfReturnCommand : IRequest<Result<GoodsReceivingOfReturnResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public GoodsReceivingOfReturnStatus Status { get; set; }
    }

    public class UpdateGoodsReceivingOfReturnHandler : IRequestHandler<UpdateGoodsReceivingOfReturnCommand, Result<GoodsReceivingOfReturnResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IGoodsReceivingOfReturnServices _goodsReceingvingOfReturnServices;
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateGoodsReceivingOfReturnHandler(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IGoodsReceivingOfReturnServices goodsReceingvingOfReturnServices, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _goodsReceingvingOfReturnServices = goodsReceingvingOfReturnServices;
            _userManager = userManager;
        }

        public async Task<Result<GoodsReceivingOfReturnResponse>> Handle(UpdateGoodsReceivingOfReturnCommand request, CancellationToken cancellationToken)
        {
            var goodsReceivingOfReturn = await _context.GoodsReceivingOfReturns.SingleOrDefaultAsync(
                irf => irf.Id == request.Id
            );

            if (goodsReceivingOfReturn == null)
            {
                return new Result<GoodsReceivingOfReturnResponse>(
                    new NotFoundException()
                );
            }

            /** Only  allow update goods receiving return form when it is not Done or Cancelled */
            if (goodsReceivingOfReturn.Status == GoodsReceivingOfReturnStatus.Done ||
                goodsReceivingOfReturn.Status == GoodsReceivingOfReturnStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Phiếu nhập kho trả hàng này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid */
            if (goodsReceivingOfReturn.Status != request.Status)
            {
                _goodsReceingvingOfReturnServices.ValidateValidNewStatus(
                    goodsReceivingOfReturn.Status,
                    request.Status);
            }

            /** If the new status is Approved then make sure only role
             * Boss and WarehouseKeeperManager can do */
            if (request.Status == GoodsReceivingOfReturnStatus.Approved)
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
                    return new Result<GoodsReceivingOfReturnResponse>(
                        new BadRequestException(
                            new ApiError("Bạn không có quyền để duyệt phiếu nhập kho trả hàng")));
                }
            }

            //TODO: Còn lúc Done chưa làm, nhớ quay lại làm !!!!!!!!!!!!!

            _mapper.Map<UpdateGoodsReceivingOfReturnCommand, GoodsReceivingOfReturn>(request, goodsReceivingOfReturn);
            _context.GoodsReceivingOfReturns.Update(goodsReceivingOfReturn);

            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GoodsReceivingOfReturnResponse>(
                    _mapper.Map<GoodsReceivingOfReturnResponse>(goodsReceivingOfReturn)
                );
            }

            return new Result<GoodsReceivingOfReturnResponse>(
               new BadRequestException(new ApiError("Cập nhật phiếu nhập kho trả hàng thất bại, vui lòng thử lại"))
            );
        }
    }
}