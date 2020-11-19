using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Entities;
using api.Helpers;
using api.IServices;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public OrderServices(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

            /** Make sure all product id in list is unique */
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

        public async Task ValidateWhenUpdateStatus(Order order, OrderStatus newStatus)
        {
            if (newStatus == OrderStatus.Processing)
            {
                if (order.Status != OrderStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép thay đổi trạng thái thành 'Đang xử lý' khi đơn hàng đang ở trạng thái 'Mới'"));
                }

            } else if (newStatus == OrderStatus.Cancelled)
            {
                if (order.Status == OrderStatus.Processing)
                {
                    // TODO: if order is processing => need to check goods delivery note valid
                }

                /** Make sure all product in order enough quantity */
                var orderDetails = await _context.OrderDetails
                    .Where(x => x.OrderId == order.Id)
                    .Include(x => x.Product)
                    .ToListAsync();
                var products = orderDetails.Select(x => x.Product).ToList();
                ValidateProductsInOrderEnoughQuantity(
                    _mapper.Map<List<ProductInOrder>>(orderDetails),
                    products
                    );
            } else if (newStatus == OrderStatus.Exported)
            {
                throw new BadRequestException(
                    new ApiError("Không được phép chuyển sang trạng thái này"));
            } else if (newStatus == OrderStatus.New)
            {
                /** Do not allow to switch back from Processing to New */
                if (order.Status != OrderStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Không được phép chuyển về trạng thái 'Mới' khi đơn hàng đã được xử lý"));
                }
            } else if (newStatus == OrderStatus.Done)
            {
                if (order.Status != OrderStatus.Exported)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ được phép đơn hàng khi đã xuất kho hoàn tất"));
                }
            }

        }

        public async Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            Order order,
            OrderStatus newStatus)
        {
            /** We don't have a busines with the New status */
            if (newStatus != OrderStatus.New)
            {
                var orderDetails = await ctx.OrderDetails
                    .Where(x => x.OrderId == order.Id)
                    .Include(x => x.Product)
                    .ToListAsync();

                var productIdsShouldBeHandled = orderDetails
                    .Select(x => x.ProductId);

                var productsShouldBeHandled = orderDetails.Select(x => x.Product)
                    .ToList();

                if (newStatus == OrderStatus.Processing &&
                    order.Status != OrderStatus.Processing)
                {
                    /** If purchase proposal form is processing then increase 
                     * the quantity for sale of product in storage */
                    productsShouldBeHandled = IncreaseProductQuantityForSaleWhenProcessing(
                        productsShouldBeHandled,
                        orderDetails);
                } else if (newStatus == OrderStatus.Cancelled)
                {
                    // TODO: Handle product quantity for sale when cancel order
                }
                ctx.Products.UpdateRange(productsShouldBeHandled);
            }

        }

        public List<Product> IncreaseProductQuantityForSaleWhenProcessing(
            List<Product> productsShouldBeHandled,
            List<OrderDetail> orderDetails)
        {
            foreach (var p in productsShouldBeHandled)
            {
                var matchedOrderDetail = orderDetails
                    .SingleOrDefault(x => x.ProductId == p.Id);

                p.QuantityForSale += matchedOrderDetail.Quantity;
            }

            return productsShouldBeHandled;
        }

        public async Task<List<ProductInOrder>> MakeSureProductsValidWhenAddToOrder(
            List<ProductInOrder> productsInOrder)
        {
            /** Make sure all product id in list is uniqe */
            productsInOrder = UniqueListByProductId(productsInOrder);

            var productIds = productsInOrder
                .Select(x => x.ProductId)
                .ToList();
            await MakeSureListProductIdValid(productIds);

            await MakeSureListProductIdDoesNotExistInOrder(productIds);

            return productsInOrder;
        }

        public async Task MakeSureListProductIdValid(List<int> productIds)
        {
            var products = await _context.Products
                .AsNoTracking()
                .Where(p => productIds.Contains(p.Id) && p.Status != ProductStatus.Locked)
                .ToListAsync();
            if (productIds.Count() != products.Count())
            {
                throw new NotFoundException();
            }
        }

        public async Task MakeSureListProductIdDoesNotExistInOrder(List<int> productIds)
        {
            var orderDetails = await _context.OrderDetails
                .AsNoTracking()
                .Where(x => productIds.Contains(x.ProductId))
                .ToListAsync();
            if (orderDetails.Count > 0)
            {
                string errResponse = "";

                foreach (var orderDetail in orderDetails)
                {
                    errResponse += $"Sản phẩm với id [{orderDetail.ProductId}] đã tồn tại trong đơn hàng<br/>";
                }

                throw new BadRequestException(
                    new ApiError(errResponse));
            }
        }

        public async Task<List<ProductInOrder>> MakeSureUpdateProductsInOrderValid(
            int orderId,
            List<ProductInOrder> productsInOrder)
        {
            productsInOrder = UniqueListByProductId(productsInOrder);

            /** Make sure all order details in list are existed */
            var orderDetailIds = productsInOrder
                .Select(x => x.Id)
                .ToList();
            var existedOrderDetails = await _context.OrderDetails
                .AsNoTracking()
                .Where(od => od.OrderId == orderId &&
                    orderDetailIds.Contains(od.Id))
                .ToListAsync();
            if (orderDetailIds.Count() != existedOrderDetails.Count())
            {
                throw new NotFoundException();
            }

            /** Validate product valid */ 
            var productIds = existedOrderDetails
                .Select(x => x.ProductId)
                .ToList();
            await MakeSureListProductIdValid(productIds);

            /** Assign product id to each product in order
             * to prevent map to entity lost productId */
            foreach (var od in existedOrderDetails)
            {
                var matchedProductInOrder = productsInOrder
                    .SingleOrDefault(x => x.Id == od.Id);
                matchedProductInOrder.ProductId = od.ProductId;
            }

            return productsInOrder;
        }
    }
}
