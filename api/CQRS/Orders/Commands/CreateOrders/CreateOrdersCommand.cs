using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
using api.CQRS.Orders.Commands.CreateOrderDetails;
using api.Entities;
using api.Helpers;
using api.IServices;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using LanguageExt.Pipes;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.Orders.Commands.CreateOrders
{
    public class CreateOrdersCommand : IRequest<Result<OrderResponse>>
    {
        public string Description { get; set; }
        public List<CreateOrderDetailsCommand> OrderDetails { get; set; }
    }

    public class CreateOrdersHadler : IRequestHandler<CreateOrdersCommand, Result<OrderResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IOrderServices _orderServices;
        private readonly IPriceCalculateHelpers _priceCalculateHelpers;

        public CreateOrdersHadler(DataContext context, IMapper mapper, IOrderServices orderServices, IPriceCalculateHelpers priceCalculateHelpers)
        {
            _context = context;
            _mapper = mapper;
            _orderServices = orderServices;
            _priceCalculateHelpers = priceCalculateHelpers;
        }

        public async Task<Result<OrderResponse>> Handle(
            CreateOrdersCommand request,
            CancellationToken cancellationToken)
        {
            /** Make sure list product of new order valid */ 
            var productsInOrder = _mapper.Map<List<ProductInOrder>>(
                request.OrderDetails);
            productsInOrder = await _orderServices.MakeValidProductsOfNewOrder(
                productsInOrder);
            request.OrderDetails = _mapper.Map<List<CreateOrderDetailsCommand>>(
                productsInOrder);

            /** Prepare new entity (order and list order detail) to save to db */
            var orderEntity = _mapper.Map<Order>(
                request
                );
            orderEntity.Status = OrderStatus.New;

            foreach (var od in orderEntity.OrderDetails)
            {
                od.QuantityNeed = od.Quantity;

                // Because user only give single price of each product in order then
                // we need to calculate total price of each product
                od.TotalPrice = _priceCalculateHelpers.CalculateTotalPriceOfProduct(
                    od.SinglePrice,
                    od.Quantity);
            }

            orderEntity.TotalPrice = orderEntity.OrderDetails.Sum(x => x.TotalPrice);

            await _context.AddAsync(orderEntity);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<OrderResponse>(
                    _mapper.Map<OrderResponse>(orderEntity)
                );
            }
            return new Result<OrderResponse>(
                _mapper.Map<OrderResponse>(
                    new BadRequestException(new ApiError("Tạo đơn hàng thất bại, xin thử lại"))
                    )
            );
        }
    }
}
