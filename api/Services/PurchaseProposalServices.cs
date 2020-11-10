using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace api.Services
{
    public class PurchaseProposalServices : IPurchaseProposalServices
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PurchaseProposalServices(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CreatePurchaseProposalDetailCommand>> ValidateAdddedProducts(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails)
        {
            /** Make sure all product id in list is uniqe */
            purchaseProposalDetails = purchaseProposalDetails
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            /** Make sure all products in list are existed */
            var productIds = purchaseProposalDetails
                .Select(x => x.ProductId)
                .ToList();

            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (productIds.Count() != products.Count())
            {
                throw new NotFoundException();
            }

            /** Validate max quantity of product */
            string maxQuantityErrorResponse = "";
            foreach (var p in products)
            {
                var requestProduct = purchaseProposalDetails
                    .SingleOrDefault(rp => rp.ProductId == p.Id);

                if (p.MaxQuantity != null)
                {
                    double totalQuantityAfterImport = requestProduct.Quantity + p.Quantity;
                    if (totalQuantityAfterImport > p.MaxQuantity)
                    {
                        maxQuantityErrorResponse += $"Số lượng sau khi nhập vào của sản phẩm '{p.Name}' [{totalQuantityAfterImport}] lớn số lượng tối đa cho phép của sản phẩm [{p.MaxQuantity}]<br/>";
                    }
                }
            }

            if (maxQuantityErrorResponse.Equals("") == false)
            {
                throw new BadRequestException(
                    new ApiError(maxQuantityErrorResponse)
                    );
            }

            return purchaseProposalDetails;
        }

        public async Task ValidateUniqueProductsInPurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId)
        {
            var newProductIds = purchaseProposalDetails
                .Select(x => x.ProductId);

            var existedPurchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId &&
                    newProductIds.Contains(x.ProductId))
                .ToListAsync();

            if (existedPurchaseProposalDetails != null &&
                existedPurchaseProposalDetails.Count() > 0)
            {
                string errResponse = "";
                foreach(var eppd in existedPurchaseProposalDetails)
                {
                    errResponse += $"Sản phẩm với id {eppd.ProductId} đã tồn tại trong phiếu đề nghị<br/>";
                }

                throw new BadRequestException(new ApiError(errResponse));
            }
        }

        public async Task<List<UpdatePurchaseProposalDetailCommand>> MakeSureListPurchaseProposalDetailUpdateValid(List<UpdatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId)
        {
            /** Make sure all product id in list is uniqe */
            purchaseProposalDetails = purchaseProposalDetails
                .GroupBy(x => x.Id)
                .Select(x => x.First())
                .ToList();

            /** Make sure all purchase proposal details exist in list are existed */
            var purchaseProposalDetailIds = purchaseProposalDetails
                .Select(x => x.Id)
                .ToList();

            var existedPurchaseProposalDetails = await _context.PurchaseProposalDetails
                .AsNoTracking()
                .Where(ppd => ppd.PurchaseProposalFormId == purchaseProposalFormId &&
                    purchaseProposalDetailIds.Contains(ppd.Id))
                .Include(ppd => ppd.Product)
                .ToListAsync();

            if (purchaseProposalDetailIds.Count() != existedPurchaseProposalDetails.Count())
            {
                throw new NotFoundException();
            }

            /** Validate max quantity of product */
            string maxQuantityErrorResponse = "";
            foreach (var ppd in purchaseProposalDetails)
            {
                var existedPurchaseProposalDetail = existedPurchaseProposalDetails
                    .SingleOrDefault(eppd => eppd.Id == ppd.Id);

                if (existedPurchaseProposalDetail.Product.MaxQuantity != null)
                {
                    double totalQuantityAfterUpdate = ppd.Quantity + existedPurchaseProposalDetail.Product.Quantity;
                    if (totalQuantityAfterUpdate > existedPurchaseProposalDetail.Product.MaxQuantity)
                    {
                        maxQuantityErrorResponse += $"Số lượng sau khi chỉnh sửa của sản phẩm '{existedPurchaseProposalDetail.Product.Name}' [{totalQuantityAfterUpdate}] lớn số lượng tối đa cho phép của sản phẩm [{existedPurchaseProposalDetail.Product.MaxQuantity}]<br/>";
                    }
                }
            }

            if (maxQuantityErrorResponse.Equals("") == false)
            {
                throw new BadRequestException(
                    new ApiError(maxQuantityErrorResponse)
                    );
            }

            return purchaseProposalDetails;
        }

        public async Task ValidateWhenUpdateStatus(PurchaseProposalForm purchaseProposalForm, PurchaseProposalFormStatus newStatus)
        {
            if (newStatus == PurchaseProposalFormStatus.Processing)
            {
                if (purchaseProposalForm.Status != PurchaseProposalFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép thay đổi trạng thái thành 'Đang xử lý' khi phiếu đang ở trạng thái 'Mới'"));
                }

            } else if (newStatus == PurchaseProposalFormStatus.Cancelled)
            {
                await MakeSureNoGoodsReceivingNoteWhenCancel(
                    purchaseProposalForm.Id);
            } else if (newStatus == PurchaseProposalFormStatus.ForceDone)
            {
                if (purchaseProposalForm.Status != PurchaseProposalFormStatus.Processing)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép 'Buộc hoàn tất' phiếu đề nghị mua hàng khi nó đang ở trạng thái 'Đang xử lý'"));
                }
                await MakkeSureForceDoneValid(purchaseProposalForm.Id);
            } else if (newStatus == PurchaseProposalFormStatus.New)
            {
                /** Do not allow to switch back from Processing to New */
                if (purchaseProposalForm.Status != PurchaseProposalFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Không được phép chuyển về trạng thái 'Mới' khi đề nghị mua hàng đã được xử lý"));
                }
            } else if (newStatus == PurchaseProposalFormStatus.Done)
            {
                throw new BadRequestException(
                    new ApiError("Không được phép chuyển sang trạng thái này"));
            }

        }

        public async Task MakeSureNoGoodsReceivingNoteWhenCancel(
            int purchaseProposalFormId)
        {
            var existedGoodsReceivingNotes = await _context.GoodsReceivingNotes
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId &&
                    x.Status != GoodsReceivingNoteStatus.Cancelled)
                .ToListAsync();

            if (existedGoodsReceivingNotes.Count > 0)
            {
                throw new BadRequestException(
                    new ApiError("Không được huỷ vì đã tồn tại phiếu nhập kho cho đề nghị mua hàng này"));
            }
        }

        public async Task MakkeSureForceDoneValid(
            int purchaseProposalFormId)
        {
            /** At least one "Done" goods receiving note and no others are different 
             * than "Done" */
            var existedGoodsReceivingNotes = await _context.GoodsReceivingNotes
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId)
                .ToListAsync();

            bool isDoneExisted = false;
            bool isOthersAreDifferentThanDoneExisted = false;

            foreach (var grn in existedGoodsReceivingNotes)
            {
                if (grn.Status == GoodsReceivingNoteStatus.Done)
                {
                    isDoneExisted = true;
                } else
                {
                    isOthersAreDifferentThanDoneExisted = true;
                }
            }

            /** At least one goods receiving note is done exist */
            if (!isDoneExisted)
            {
                throw new BadRequestException(
                    new ApiError("Không được 'Buộc hoàn tất' đề nghị mua hàng này vì chưa có phiếu nhập kho nào 'Hoàn tất'"));
            }

            /** Must be no others which are different than done exist */
            if (isOthersAreDifferentThanDoneExisted)
            {
                throw new BadRequestException(
                    new ApiError("Không được 'Buộc hoàn tât' đề nghị mua hàng này vì còn tồn tại phiêus nhập kho chưa hoàn tất"));
            }
        }

        public async Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            PurchaseProposalForm purchaseProposalForm,
            PurchaseProposalFormStatus newStatus)
        {
            /** We don't have a busines with the New status */
            if (newStatus != PurchaseProposalFormStatus.New)
            {
                var purchaseProposalDetails = await ctx.PurchaseProposalDetails
                    .Where(x => x.PurchaseProposalFormId == purchaseProposalForm.Id)
                    .ToListAsync();

                var productIdsShouldBeHandled = purchaseProposalDetails
                    .Select(x => x.ProductId);

                var productsShouldBeHandled = await ctx.Products
                    .Where(x => productIdsShouldBeHandled.Contains(x.Id))
                    .ToListAsync();

                if (newStatus == PurchaseProposalFormStatus.Processing &&
                    purchaseProposalForm.Status != PurchaseProposalFormStatus.Processing)
                {
                    /** If purchase proposal form is processing then increase 
                     * the quantity ordered of product in storage */
                    productsShouldBeHandled = IncreaseProductQuantityOrderedWhenProcessing(
                        productsShouldBeHandled,
                        purchaseProposalDetails);
                } else if (newStatus == PurchaseProposalFormStatus.Cancelled)
                {
                    /** Because we can Cancel when purchase proposal form is both New or Procesing */
                    /** If current status is Processing => quantity ordered of product in storage
                     * is changed => need to undo */
                    if (purchaseProposalForm.Status == PurchaseProposalFormStatus.Processing)
                    {
                        productsShouldBeHandled = UpdateProductQuantityOrderedWhenCancel(
                            productsShouldBeHandled,
                            purchaseProposalDetails);
                    }
                } else if (newStatus == PurchaseProposalFormStatus.ForceDone)
                {
                    if (purchaseProposalForm.Status == PurchaseProposalFormStatus.Processing)
                    {
                        productsShouldBeHandled = UpdateProductQuantityOrderedWhenForceDone(
                            productsShouldBeHandled,
                            purchaseProposalDetails);
                    }
                }

                ctx.Products.UpdateRange(productsShouldBeHandled);
            }

        }
        public List<Product> IncreaseProductQuantityOrderedWhenProcessing(
            List<Product> productsShouldBeHandled,
            List<PurchaseProposalDetail> purchaseProposalDetails)
        {
            foreach (var p in productsShouldBeHandled)
            {
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);

                p.QuantityOrdered += matchedPurchaseProposalDetail.Quantity;
            }

            return productsShouldBeHandled;
        }

        public List<Product> UpdateProductQuantityOrderedWhenCancel(
            List<Product> productsShouldBeHandled,
            List<PurchaseProposalDetail> purchaseProposalDetails)
        {
            foreach (var p in productsShouldBeHandled)
            {
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);

                // Because when purchase proposal form is cancelled, that's mean there
                // no goods receiving note existed so we can ignore quantiy purchase of
                // each product in purchase proposal form
                p.QuantityOrdered -= matchedPurchaseProposalDetail.Quantity;
            }

            return productsShouldBeHandled;
        }

        public List<Product> UpdateProductQuantityOrderedWhenForceDone(
            List<Product> productsShouldBeHandled,
            List<PurchaseProposalDetail> purchaseProposalDetails)
        {
            foreach (var p in productsShouldBeHandled)
            {
                /** If force done, so we should only decrease ONLY the quantity to buy left
                 * of product in purchase proposal form */
                /** quantity to buy left = original quantity - quantity purchased */
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);
                double quantityToBuyLeft = matchedPurchaseProposalDetail.Quantity - matchedPurchaseProposalDetail.QuantityPurchased;

                p.QuantityOrdered -= quantityToBuyLeft;
            }

            return productsShouldBeHandled;
        }
    }
}
