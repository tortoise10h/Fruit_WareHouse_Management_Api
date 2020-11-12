using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper.Configuration.Conventions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class OrderServices: IOrderServices
    {
        private readonly DataContext _context;

        public OrderServices(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ProductInOrder>> MakeValidProductsOfNewOrder(
            List<ProductInOrder> productsInNewOrder)
        {
            productsInNewOrder = UniqueListByProductId(productsInNewOrder);

            /** Make sure all products exist */
            var productIds = productsInNewOrder
                .Select(x => x.ProductId)
                .ToList();
            await CheckListProductIdExistedAndNotLocked(productIds);

            return productsInNewOrder;
        }

        public async Task CheckListProductIdExistedAndNotLocked(
            List<int> productIds)
        {
            var existedProducts = await _context.Products
                .Where(x => productIds.Contains(x.Id) &&
                    x.Status != ProductStatus.Locked)
                .ToListAsync();
            if (existedProducts.Count != productIds.Count)
            {
                throw new NotFoundException();
            }
        }

        public List<ProductInOrder> UniqueListByProductId(List<ProductInOrder> productsInOrder)
        {

            /** Make sure all product id in list is uniqe */
            productsInOrder = productsInOrder
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            return productsInOrder;
        }

        public void ValidateProductsInOrderEnoughQuantity(
            List<ProductInOrder> productsInOrder,
            List<Product> products
            )
        {
            /** Make sure all products of order enough quantity */
            string errResponse = "";
            double productAvailableQuantity;
            foreach (var p in productsInOrder)
            {
                var matchedProduct = products.SingleOrDefault(
                    x => x.Id == p.ProductId);
                productAvailableQuantity = matchedProduct.Quantity - matchedProduct.QuantityForSale;

                if (p.Quantity > matchedProduct.Quantity)
                {
                    errResponse += $"Số lượng của sản phẩm '{matchedProduct.Name}' trong kho [{productAvailableQuantity}] không đủ với số lượng yêu cầu trong đơn hàng [{p.Quantity}] <br/>";
                }
            }

            if (!errResponse.Equals(""))
            {
                throw new BadRequestException(
                    new ApiError(errResponse));
            }
        }
    }
}
