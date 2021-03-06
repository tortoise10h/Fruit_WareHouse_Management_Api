﻿using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Entities;
using api.Helpers;
using api.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class GoodsDeliveryNoteServices: IGoodsDeliveryNoteServices
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;

        public GoodsDeliveryNoteServices(DataContext context, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<List<ProductInGoodsDeliveryNote>> MakeSureProductsOfNewGoodsDeliveryNoteValid(List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote, List<OrderDetail> orderDetails)
        {
            productsInGoodsDeliveryNote = UniqueListByProductId(productsInGoodsDeliveryNote);

            var productIdsInGoodsDeliveryNote = productsInGoodsDeliveryNote
                .Select(x => x.ProductId)
                .ToList();
            await ValidateListProductIdsExistAndNotLocked(productIdsInGoodsDeliveryNote);

            ValidateProductsValidInOrder(orderDetails, productsInGoodsDeliveryNote);

            return productsInGoodsDeliveryNote;
        }

        public async Task ValidateListProductIdsExistAndNotLocked(List<int> productIds)
        {
            var products = await _context.Products
                .Where(x => productIds.Contains(x.Id) &&
                    x.Status != ProductStatus.Locked)
                .ToListAsync();

            if (productIds.Count != products.Count)
            {
                /** That's mean there some invalid products here */
                var validProductIds = products
                    .Select(x => x.Id)
                    .ToList();

                var inValidProductIds = productIds.Except(validProductIds);

                string errResponse = "";
                foreach (var pId in inValidProductIds)
                {
                    errResponse += $"Sản phẩm với id [{pId}] không tồn tại hoặc đã bị 'Khoá'<br/>";
                }

                throw new BadRequestException(
                    new ApiError(errResponse));
            }
        }

        public List<ProductInGoodsDeliveryNote> UniqueListByProductId(List<ProductInGoodsDeliveryNote> productsInGoodsReceivingNote)
        {

            /** Make sure all product id in list is unique */
            productsInGoodsReceivingNote = productsInGoodsReceivingNote
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            return productsInGoodsReceivingNote;
        }

        public List<ProductInGoodsDeliveryNote> UniqueListById(List<ProductInGoodsDeliveryNote> productsInGoodsReceivingNote)
        {

            /** Make sure all product id in list is unique */
            productsInGoodsReceivingNote = productsInGoodsReceivingNote
                .GroupBy(x => x.Id)
                .Select(x => x.First())
                .ToList();

            return productsInGoodsReceivingNote;
        }

        public void ValidateProductsValidInOrder(
            List<OrderDetail> orderDetails,
            List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote)
        {
            string errorResponse = "";

            foreach (var product in productsInGoodsDeliveryNote)
            {
                var matchedOrderDetail = orderDetails
                    .SingleOrDefault(x => x.ProductId == product.ProductId);
                
                if (matchedOrderDetail == null)
                {
                    errorResponse += $"Sản phẩm với id [{product.ProductId}] không được yêu cầu trong đơn hàng này<br/>";
                } else
                {
                    // If quantity in goods receiving note > quantity need in order detail => false
                    if (product.Quantity > matchedOrderDetail.QuantityNeed)
                    {
                        errorResponse += $"Số lượng xuất kho của sản phẩm với id [{product.ProductId}] là: {product.Quantity} lơn hơn số lượng cần xuất kho còn lại trong đơn hàng là: {matchedOrderDetail.QuantityNeed}<br/>";
                    }
                }

            }

            if (!errorResponse.Equals(""))
            {
                throw new BadRequestException(
                    new ApiError(errorResponse));
            }
        }

        public async Task ValidateWhenUpdateStatus(GoodsDeliveryNote goodsDeliveryNote, GoodsDeliveryNoteStatus newStatus)
        {
            if (newStatus == GoodsDeliveryNoteStatus.Pending)
            {
                if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép thay đổi trạng thái thành 'Chờ duyệt' khi phiếu xuất kho đang ở trạng thái 'Mới'"));
                }

            } else if (newStatus == GoodsDeliveryNoteStatus.New)
            {
                if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.New &&
                    goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Không được phép chuyển về trạng thái 'Mới' khi đơn hàng đã 'chờ duyệt'"));
                }
            } else if (newStatus == GoodsDeliveryNoteStatus.Done)
            {
                if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.Approved)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được hoàn tất phiếu xuất kho chỉ khi phiếu khi đã duyệt"));
                }

                /** Make sure products in goods delivery note are enough quantity in storage */
                var goodsDeliveryDetails = await _context.GoodsDeliveryDetails
                    .Where(x => x.GoodsDeliveryNoteId == goodsDeliveryNote.Id)
                    .Include(x => x.Product)
                    .ToListAsync();
                var products = goodsDeliveryDetails.Select(x => x.Product).ToList();

                CheckProductsEnoughQuantityWhenDone(goodsDeliveryDetails, products);

            } else if (newStatus == GoodsDeliveryNoteStatus.Approved)
            {
                if (goodsDeliveryNote.Status != GoodsDeliveryNoteStatus.Pending)
                {
                    throw new BadRequestException(
                        new ApiError("Không được phép duyệt phiếu khi phiếu chưa chuyển sang trạng thái 'Chờ duyệt'"));
                }

                /** Handle permission */
                var currentUserId = _httpContextAccessor.HttpContext.User
                    .Claims
                        .First(x => x.Type == "id").Value;

                var currentUser = await _userManager.FindByIdAsync(currentUserId);
                var roles = await _userManager.GetRolesAsync(currentUser);
                var userRole = roles.FirstOrDefault();

                if (userRole != RoleName.Boss &&
                    userRole != RoleName.WarehouseKeeperManager)
                {
                    throw new BadRequestException(
                        new ApiError("Bạn không có quyền để duyệt phiêu xuất kho")); 
                }
            }

        }

        public void CheckProductsEnoughQuantityWhenDone(List<GoodsDeliveryDetail> goodsDeliveryDetails, List<Product> products)
        {
            var productIdsToExport = goodsDeliveryDetails.Select(x => x.ProductId).ToList();

            products = products.Where(x => x.Status != ProductStatus.Locked).ToList();

            /** Make sure all exported products are existed and not locked */
            if (productIdsToExport.Count != products.Count)
            {
                var existedProductIds = products.Select(x => x.Id).ToList();

                var inValidProductIds = productIdsToExport.Except(existedProductIds);

                string errResponse = "";
                foreach (var pId in inValidProductIds)
                {
                    errResponse += $"Sản phẩm với id [{pId}] không tồn tại hoặc đã bị khoá<br/>";
                }

                throw new BadRequestException(
                    new ApiError(errResponse));
            }

            /** Make sure all exported products enough quantity */
            string err = "";
            foreach (var gdd in goodsDeliveryDetails)
            {
                var matchedProduct = products
                    .SingleOrDefault(x => x.Id == gdd.ProductId);

                if (gdd.Quantity > matchedProduct.Quantity)
                {
                    err += $"Số lượng còn lại của sản phẩm với id [{gdd.ProductId}] (SL: {matchedProduct.Quantity}) không đủ so với số lượng cần xuất kho (SL: {gdd.Quantity})<br/>"; 
                }
            }

            if (err.Equals("") == false)
            {
                throw new BadRequestException(
                    new ApiError(err));
            }
        }

        public async Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            GoodsDeliveryNote goodsDeliveryNote,
            GoodsDeliveryNoteStatus newStatus)
        {
            /** We don't have a business with the New status */
            if (newStatus != GoodsDeliveryNoteStatus.New)
            {
                if (newStatus == GoodsDeliveryNoteStatus.Done)
                {
                    var goodsDeliveryDetails = await ctx.GoodsDeliveryDetails
                        .Where(x => x.GoodsDeliveryNoteId == goodsDeliveryNote.Id)
                        .ToListAsync();

                    var orderDetailsShouldBeHandled = await ctx.OrderDetails
                        .Include(x => x.Product)
                        .Where(x => x.OrderId == goodsDeliveryNote.OrderId)
                        .ToListAsync();

                    /** Update quantity of product in order and in storage */
                    foreach (var goodsDeliveryDetail in goodsDeliveryDetails)
                    {
                        var matchedOrderDetail = orderDetailsShouldBeHandled
                            .SingleOrDefault(x => x.ProductId == goodsDeliveryDetail.ProductId);

                        matchedOrderDetail.QuantitySold += goodsDeliveryDetail.Quantity;
                        matchedOrderDetail.QuantityNeed = matchedOrderDetail.Quantity - matchedOrderDetail.QuantitySold;

                        matchedOrderDetail.Product.QuantityForSale -= goodsDeliveryDetail.Quantity;
                        matchedOrderDetail.Product.Quantity -= goodsDeliveryDetail.Quantity;
                    }

                    var productsToUpdate = orderDetailsShouldBeHandled
                        .Select(x => x.Product)
                        .ToList();

                    /** Order will be changed to exported status when all quantity need
                     * of each order detail in it = 0 */
                    bool isOrderExported = true;
                    foreach (var od in orderDetailsShouldBeHandled)
                    {
                        if (od.QuantityNeed > 0)
                        {
                            isOrderExported = false;
                        }
                    }

                    if (isOrderExported)
                    {
                        var updatedOrder = new Order { Id = goodsDeliveryNote.OrderId };
                        ctx.Attach(updatedOrder);

                        updatedOrder.Status = OrderStatus.Exported;
                    }

                    ctx.Products.UpdateRange(productsToUpdate);
                    ctx.OrderDetails.UpdateRange(orderDetailsShouldBeHandled);
                } 
            }

        }

        public async Task<List<ProductInGoodsDeliveryNote>> ValidateWhenAddNewProductToExistedGoodsDeliveryNote(
            int goodsDeliveryNoteId,
            List<OrderDetail> orderDetails,
            List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote
            )
        {
            /** Unique list by product Id */
            productsInGoodsDeliveryNote = UniqueListByProductId(productsInGoodsDeliveryNote);
            
            /** Make sure new products don't exist in goods delivery note */
            var productIdsInGoodsDeliveryNote = productsInGoodsDeliveryNote
                .Select(x => x.ProductId)
                .ToList();

            var existedGoodsDeliveryNote = await ValidateProductAlreadyExistInGoodsDeliveryNote(
                productIdsInGoodsDeliveryNote,
                goodsDeliveryNoteId);

            if (existedGoodsDeliveryNote != null)
            {

                string errResponse = "";
                foreach (var gdd in existedGoodsDeliveryNote)
                {
                    errResponse += $"Sản phẩm với id [{gdd.ProductId}] đã tồn tại trong phiếu xuất kho<br/>";
                }

                throw new BadRequestException(
                    new ApiError(errResponse));
            }

            await ValidateListProductIdsExistAndNotLocked(productIdsInGoodsDeliveryNote);

            /** Make sure new product valid in order */
            ValidateProductsValidInOrder(orderDetails, productsInGoodsDeliveryNote);

            return productsInGoodsDeliveryNote;
        }

        public async Task<List<GoodsDeliveryDetail>> ValidateProductAlreadyExistInGoodsDeliveryNote(
            List<int> productIdsInGoodsDeliveryNote,
            int goodsDeliveryNoteId)
        {
            var goodsDeliveryDetails = await _context.GoodsDeliveryDetails
                .Where(x => productIdsInGoodsDeliveryNote.Contains(x.ProductId) && 
                    x.GoodsDeliveryNoteId == goodsDeliveryNoteId)
                .ToListAsync();

            if (goodsDeliveryDetails.Count > 0)
            {
                return goodsDeliveryDetails;
            }

            return null;

        }

        public List<ProductInGoodsDeliveryNote> ValidateWhenUpdateProductsInGoodsDeliveryNote( List<GoodsDeliveryDetail> goodsDeliveryDetails,
            List<OrderDetail> orderDetails,
            List<ProductInGoodsDeliveryNote> productsInGoodsDeliveryNote
            )
        {
            /** Unique list by product Id */
            productsInGoodsDeliveryNote = UniqueListById(productsInGoodsDeliveryNote);
            
            /** Make sure updated products must be existed in goods receiving note */
            if (goodsDeliveryDetails.Count != productsInGoodsDeliveryNote.Count)
            {
                throw new NotFoundException();
            }

            /** Make sure new product valid in purchase proposal */
            ValidateProductsValidInOrder(orderDetails, productsInGoodsDeliveryNote);

            return productsInGoodsDeliveryNote;
        }
    }
}
