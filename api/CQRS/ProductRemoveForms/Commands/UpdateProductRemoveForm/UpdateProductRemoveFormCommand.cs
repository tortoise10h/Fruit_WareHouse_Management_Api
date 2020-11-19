using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveForm
{
    public class UpdateProductRemoveFormCommand : IRequest<Result<ProductRemoveFormResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public ProductRemoveFormStatus Status { get; set; }
    }

    public class UpdateProductRemoveFormHandler : IRequestHandler<UpdateProductRemoveFormCommand, Result<ProductRemoveFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductRemoveFormServices _productRemoveFormServices;
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateProductRemoveFormHandler(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IProductRemoveFormServices productRemoveFormServices, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _productRemoveFormServices = productRemoveFormServices;
            _userManager = userManager;
        }

        public async Task<Result<ProductRemoveFormResponse>> Handle(UpdateProductRemoveFormCommand request, CancellationToken cancellationToken)
        {
            var productRemoveForm = await _context.ProductRemoveForms.SingleOrDefaultAsync(
                prf => prf.Id == request.Id
            );

            if (productRemoveForm == null)
            {
                return new Result<ProductRemoveFormResponse>(
                    new NotFoundException()
                );
            }

            /** Only  allow update product remove form when it is not Done or Cancelled */
            if (productRemoveForm.Status == ProductRemoveFormStatus.Done ||
                productRemoveForm.Status == ProductRemoveFormStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Phiếu huỷ sản phẩm trong kho này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid */
            if (productRemoveForm.Status != request.Status)
            {
                _productRemoveFormServices.ValidateValidNewStatus(
                    productRemoveForm.Status,
                    request.Status);
            }

            /** If the new status is Approved then make sure only role
             * Boss and WarehouseKeeperManager can do */
            if (request.Status == ProductRemoveFormStatus.Approved)
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
                    return new Result<ProductRemoveFormResponse>(
                        new BadRequestException(
                            new ApiError("Bạn không có quyền để duyệt phiếu huỷ sản phẩm trong kho")));
                }
            }

            //** Update product quantity when request status is done */
            if (request.Status == ProductRemoveFormStatus.Done)
            {
                var productRemoveDetails = await _context.ProductRemoveDetails
                    .Where(prd => prd.ProductRemoveFormId == request.Id)
                    .ToListAsync();

                var productsToUpdate = productRemoveDetails
                    .Select(x => new { x.ProductId, x.RemovedQuantity });

                var products = await _context.Products
                    .Where(p => productsToUpdate.Select(x => x.ProductId).Contains(p.Id))
                    .ToListAsync();

                foreach (var p in products)
                {
                    var update = productsToUpdate
                        .FirstOrDefault(x => x.ProductId == p.Id);

                    p.Quantity = p.Quantity - update.RemovedQuantity;
                }

                _context.Products.UpdateRange(products);
            }

            _mapper.Map<UpdateProductRemoveFormCommand, ProductRemoveForm>(request, productRemoveForm);
            _context.ProductRemoveForms.Update(productRemoveForm);

            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<ProductRemoveFormResponse>(
                    _mapper.Map<ProductRemoveFormResponse>(productRemoveForm)
                );
            }

            return new Result<ProductRemoveFormResponse>(
               new BadRequestException(new ApiError("Cập nhật phiếu huỷ sản phẩm trong kho thất bại, vui lòng thử lại"))
            );
        }
    }
}