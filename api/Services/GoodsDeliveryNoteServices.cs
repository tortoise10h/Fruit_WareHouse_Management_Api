using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Entities;
using api.Helpers;
using api.IServices;
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

        public GoodsDeliveryNoteServices(DataContext context)
        {
            _context = context;
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
    }
}
