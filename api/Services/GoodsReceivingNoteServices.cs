using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
using LanguageExt;
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
    }
}
