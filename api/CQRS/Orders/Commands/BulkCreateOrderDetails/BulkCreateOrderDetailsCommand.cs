using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
using api.CQRS.Orders.Commands.CreateOrderDetails;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.Entities;
using api.Helpers;
using api.IServices;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.Orders.Commands.BulkCreateOrderDetails
{ 
    public class BulkCreateOrderDetailsCommand : IRequest<Result<List<OrderDetailResponse>>>
    {
        public int OrderId { get; set; }
        public List<CreateOrderDetailsCommand> OrderDetails { get; set; }
    }

    public class BulkCreateOrderDetailsHandler : IRequestHandler<BulkCreateOrderDetailsCommand, Result<List<OrderDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IOrderServices _orderServices;
        private readonly IPriceCalculateHelpers _priceCalculateHelpers;

        public BulkCreateOrderDetailsHandler(DataContext context, IMapper mapper, IOrderServices orderServices, IPriceCalculateHelpers priceCalculateHelpers)
        {
            _context = context;
            _mapper = mapper;
            _orderServices = orderServices;
            _priceCalculateHelpers = priceCalculateHelpers;
        }

        public async Task<Result<List<OrderDetailResponse>>> Handle(
            BulkCreateOrderDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .SingleOrDefaultAsync(x => x.Id == request.OrderId);

            /** Make sure add product to valid order */
            if (order == null)
            {
                return new Result<List<OrderDetailResponse>>(
                    new NotFoundException()
                );
            }
            if (order.Status != OrderStatus.New)
            {
                return new Result<List<OrderDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào đơn hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate valid new products of order */
            var productsInOrder = new List<ProductInOrder>();
            _mapper.Map<List<CreateOrderDetailsCommand>, List<ProductInOrder>>(
                request.OrderDetails, productsInOrder);

            productsInOrder = await _orderServices.MakeSureProductsValidWhenAddToOrder(
                productsInOrder);

            /** Prepare entities to save */
            List<OrderDetail> orderDetailEntities = _mapper.Map<List<OrderDetail>>(
                productsInOrder
                );
            foreach (var od in orderDetailEntities)
            {
                od.QuantityNeed = od.Quantity;
                od.OrderId = order.Id;

                // Because user only give single price of each product in order then
                // we need to calculate total price of each product
                od.TotalPrice = _priceCalculateHelpers.CalculateTotalPriceOfProduct(
                    od.SinglePrice,
                    od.Quantity);
            }

            double newProductsTotalPrice = orderDetailEntities.Sum(x => x.TotalPrice);
            order.TotalPrice += newProductsTotalPrice;

            await _context.OrderDetails.AddRangeAsync(orderDetailEntities);
            _context.Orders.Update(order);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<OrderDetailResponse>>(
                    _mapper.Map<List<OrderDetailResponse>>(orderDetailEntities)
                );
            }

            return new Result<List<OrderDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào đơn hàng thất bại, xin thử lại"))
                );
        }
    }
}
