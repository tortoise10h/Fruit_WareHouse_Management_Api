using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using api.Contracts.V1.Exceptions;
using api.Common.Enums;
using api.Helpers;
using E = api.Entities;
using api.Entities;
using System.Linq.Dynamic.Core;
using System.Linq;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using Microsoft.AspNetCore.Http;
using api.IServices;
using Microsoft.AspNetCore.Identity;
using System.Runtime.InteropServices;

namespace api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingNote
{
    public class UpdateGoodsReceivingNoteCommand : IRequest<Result<GoodsReceivingNoteResponse>>
    {
        public int Id { get; set; }
        public GoodsReceivingNoteStatus Status { get; set; }
        public string SupplierName { get; set; }
        public int SupplierId { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
    }

    public class UpdateGoodsReceivingNoteHandler : IRequestHandler<UpdateGoodsReceivingNoteCommand, Result<GoodsReceivingNoteResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IGoodsReceivingNoteServices _goodsReceivingNoteServices;
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateGoodsReceivingNoteHandler(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IGoodsReceivingNoteServices goodsReceivingNoteServices, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _goodsReceivingNoteServices = goodsReceivingNoteServices;
            _userManager = userManager;
        }

        public async Task<Result<GoodsReceivingNoteResponse>> Handle(UpdateGoodsReceivingNoteCommand request, CancellationToken cancellationToken)
        {
            var goodsReceivingNote = await _context.GoodsReceivingNotes
                .SingleOrDefaultAsync(x => x.Id == request.Id);
            if (goodsReceivingNote == null)
            {
                return new Result<GoodsReceivingNoteResponse>(
                    new NotFoundException()
                );
            }

            /** Only  allow update goods receiving note when it is not Done or canceled */
            if (goodsReceivingNote.Status == GoodsReceivingNoteStatus.Done ||
                goodsReceivingNote.Status == GoodsReceivingNoteStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Phiếu nhập kho này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid */
            if (goodsReceivingNote.Status != request.Status)
            {
                _goodsReceivingNoteServices.ValidateValidNewStatus(
                    goodsReceivingNote.Status,
                    request.Status);
            }

            /** If the new status is Approved then make sure only role
             * Boss and WarehouseKeeperManager can do */
            if (request.Status == GoodsReceivingNoteStatus.Approved)
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
                    return new Result<GoodsReceivingNoteResponse>(
                        new BadRequestException(
                            new ApiError("Bạn không có quyền để duyệt phiêu nhập kho"))); 
                }
            }

            /** If goods receiving note is done => update quantity of product
             * in purchase proposal form and in storage */
            if (request.Status == GoodsReceivingNoteStatus.Done)
            {
                var goodsReceivingDetails = await _context.GoodsReceivingDetails
                    .Where(x => x.GoodsReceivingNoteId == request.Id)
                    .ToListAsync();

                await _goodsReceivingNoteServices
                    .UpdateQuantityOfProductWhenGoodsReceivingNoteIsDone(
                        goodsReceivingNote.PurchaseProposalFormId,
                        goodsReceivingDetails,
                        _context);
            }
            
            if (request.SupplierId != goodsReceivingNote.SupplierId)
            {
                /** That's mean the supplier of this goods receiving note is changed
                 * need to check all current products in this goods receiving note 
                 * are belong to the new supplier or not, if not => stop the update process */
                var newSupplier = await _context.Suppliers
                    .SingleOrDefaultAsync(x => x.Id == request.SupplierId);
                if (newSupplier == null)
                {
                    throw new NotFoundException();
                }

                await _goodsReceivingNoteServices
                    .ValidateProductsInGoodsRecevingNoteWhenChangeSupplierId(
                        goodsReceivingNote.Id,
                        newSupplier.Id);

                goodsReceivingNote.SupplierName = newSupplier.Name;
            }

            _mapper.Map<UpdateGoodsReceivingNoteCommand, E.GoodsReceivingNote>(request, goodsReceivingNote);

            _context.GoodsReceivingNotes.Update(goodsReceivingNote);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GoodsReceivingNoteResponse>(
                    _mapper.Map<GoodsReceivingNoteResponse>(goodsReceivingNote)
                );
            }

            return new Result<GoodsReceivingNoteResponse>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa thông tin phiếu nhập kho mua hàng thất bại, xin thử lại"))
            );
        }

        public async Task IncreaseProductQuantityOrderedWhenProcessing(
            int purchaseProposalFormId)
        {
            var purchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId)
                .ToListAsync();

            var productIds = purchaseProposalDetails
                .Select(x => x.ProductId)
                .ToList();

            var products = await _context.Products
                .Where(x => productIds.Contains(x.Id))
                .ToListAsync();

            foreach (var p in products)
            {
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);

                p.QuantityOrdered += matchedPurchaseProposalDetail.Quantity;
            }

            _context.Products.UpdateRange(products);
        }
    }
}