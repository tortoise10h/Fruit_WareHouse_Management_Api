using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace api.Services
{
    public class GoodsReceivingNoteServices : IGoodsReceivingNoteServices
    {
        private readonly DataContext _context;

        public GoodsReceivingNoteServices(DataContext context)
        {
            _context = context;
        }

        public List<ProductInGoodsReceivingNote> ValidateProductsOfNewGoodsReceivingNote(List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote, List<PurchaseProposalDetail> purchaseProposalDetails)
        {
            productsInGoodsReceivingNote = UniqueListByProductId(productsInGoodsReceivingNote);

            ValidateProductValidInPurchaseProposalForm(purchaseProposalDetails, productsInGoodsReceivingNote);

            return productsInGoodsReceivingNote;
        }

        public List<ProductInGoodsReceivingNote> UniqueListByProductId(List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote)
        {

            /** Make sure all product id in list is uniqe */
            productsInGoodsReceivingNote = productsInGoodsReceivingNote
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            return productsInGoodsReceivingNote;
        }

        public async Task ValidateAllProductInGoodsReceivingDetailListExist(List<int> productIds)
        {
            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (productIds.Count() != products.Count())
            {
                throw new NotFoundException();
            }
        }

        public void ValidateProductValidInPurchaseProposalForm(List<PurchaseProposalDetail> purchaseProposalDetails, List<ProductInGoodsReceivingNote> productsInGoodsReceivingNote)
        {
            var productIdsInPurchaseProposalDetails = purchaseProposalDetails
                .Select(x => x.ProductId)
                .ToList();

            string errorResponse = "";

            foreach (var product in productsInGoodsReceivingNote)
            {
                // Get equivalent of current product purchase proposal detail list */
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == product.ProductId);
                if (matchedPurchaseProposalDetail == null)
                {
                    errorResponse += $"Sản phẩm với id [{product.ProductId}] không được yêu cầu trong phiếu đề nghị mua hàng này<br/>";
                } else
                {
                    // Quantity to buy left of each product in purchase proposal = 
                    // quantity - quantityPurchased
                    // If quantity in goods receiving note > quantity to buy => false
                    double quantityToBuyLeft = matchedPurchaseProposalDetail.Quantity - matchedPurchaseProposalDetail.QuantityPurchased;
                    if (product.Quantity > quantityToBuyLeft)
                    {
                        errorResponse += $"Số lượng nhập vào của sản phẩm với id [{product.ProductId}] là: {product.Quantity} lơn hơn so với số lượng cần mua: {quantityToBuyLeft}<br/>";
                    }
                }

            }

            if (!errorResponse.Equals(""))
            {
                throw new BadRequestException(
                    new ApiError(errorResponse));
            }
        }

        public List<GoodsReceivingDetail> CalculatePriceOfProducsInGoodsReceivingNote(
            List<GoodsReceivingDetail> goodsReceivingDetails)
        {
            foreach(var p in goodsReceivingDetails)
            {
                p.TotalPrice = p.Quantity * p.SinglePurchasePrice;
            }

            return goodsReceivingDetails;
        }

        public void ValidateValidNewStatus(GoodsReceivingNoteStatus oldSatus, GoodsReceivingNoteStatus newStatus)
        {
            if (newStatus == GoodsReceivingNoteStatus.New)
            {
                /** Only allow to switch Pending -> New */
                if (oldSatus != GoodsReceivingNoteStatus.Pending &&
                    oldSatus != GoodsReceivingNoteStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu nhập kho về trạng thái 'Mới' khi trạng thái hiện tại của phiếu là 'Chờ duyệt'"));
                }
            }
            else if (newStatus == GoodsReceivingNoteStatus.Pending)
            {
                /** Only New -> Pending */
                if (oldSatus != GoodsReceivingNoteStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép cập nhật trạng thái của phiếu nhập kho thành 'Chờ duyệt' khi trạng thái hiện tại là 'Mới'"));
                }

            } else if (newStatus == GoodsReceivingNoteStatus.Approved)
            {
                /** Only Pending -> Approved */
                if (oldSatus != GoodsReceivingNoteStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép duyệt phiếu nhập kho khi trạng thái hiện tại là 'Chờ duyệt'"));
                }
            } else if (newStatus == GoodsReceivingNoteStatus.Done)
            {
                /** Only Approved -> Done */
                if (oldSatus != GoodsReceivingNoteStatus.Approved)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép 'Hoàn tất' phiếu nhập kho khi trạng thái hiện tại của phiếu là 'Đã duyệt'"));
                }
            } else if (newStatus == GoodsReceivingNoteStatus.Cancelled)
            {
                if (oldSatus == GoodsReceivingNoteStatus.Done ||
                    oldSatus == GoodsReceivingNoteStatus.Cancelled)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được huỷ phiếu nhập kho khi trạng thái hiện tại của nó khác 'Hoàn tất' và 'Đã huỷ'"));
                }
            }

        }

        public async Task UpdateQuantityOfProductWhenGoodsReceivingNoteIsDone(
            int purchaseProposalFormId,
            List<GoodsReceivingDetail> goodsReceivingDetails,
            DataContext ctx)
        {
            /** Get this to update quantity purchased in purchase proposal form */
            var purchaseProposalDetails = await ctx.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId)
                .ToListAsync();

            /** Get this to update quantity ordered of product in storage */
            var productIdsInGoodsReceivingDetails = goodsReceivingDetails
                .Select(x => x.ProductId)
                .ToList();
            var products = await ctx.Products
                .Where(p => productIdsInGoodsReceivingDetails.Contains(p.Id))
                .ToListAsync();

            foreach (var p in products)
            {
                var matchedGoodsReceivingDetail = goodsReceivingDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);
                p.QuantityOrdered -= matchedGoodsReceivingDetail.Quantity;
            }
            foreach (var grd in goodsReceivingDetails)
            {
                var matchedPurchaseProposalDetail = purchaseProposalDetails
                    .SingleOrDefault(x => x.ProductId == grd.ProductId);
                matchedPurchaseProposalDetail.QuantityPurchased += grd.Quantity;
            }
            ChangePurchaseProposalToDoneWhenQuantityEnough(
                ctx,
                purchaseProposalFormId,
                purchaseProposalDetails);

            ctx.Products.UpdateRange(products);
            ctx.PurchaseProposalDetails.UpdateRange(purchaseProposalDetails);
        }

        public void ChangePurchaseProposalToDoneWhenQuantityEnough(
            DataContext ctx,
            int purchaseProposalFormId,
            List<PurchaseProposalDetail> purchaseProposalDetails)
        {
            int doneCount = 0;

            foreach (var ppd in purchaseProposalDetails)
            {
                if (ppd.Quantity == ppd.QuantityPurchased)
                {
                    doneCount++;
                }
            }

            if (doneCount == purchaseProposalDetails.Count())
            {
                /** This is mean all product in purchase proposal form are purchased enough */
                var updateInfo = new PurchaseProposalForm {
                    Id = purchaseProposalFormId,
                };

                ctx.PurchaseProposalForms.Attach(updateInfo);

                updateInfo.Status = PurchaseProposalFormStatus.Done;
            }
        }
    }
}
