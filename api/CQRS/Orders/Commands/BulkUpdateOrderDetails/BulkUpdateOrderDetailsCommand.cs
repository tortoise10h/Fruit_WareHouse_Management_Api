using api.Common.Enums;
using api.Contracts.V1.Dtos;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
using api.CQRS.Orders.Commands.UpdateOrderDetails;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
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

namespace api.CQRS.Orders.Commands.BulkUpdateOrderDetails
{ 
    public class BulkUpdateOrderDetailsCommand : IRequest<Result<List<OrderDetailResponse>>>
    {
        public int OrderId { get; set; }
        public List<UpdateOrderDetailsCommand> OrderDetails { get; set; }
    }

    public class BulkUpdateOrderDetailsHandler : IRequestHandler<BulkUpdateOrderDetailsCommand, Result<List<OrderDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IOrderServices _orderServices;
        private readonly IPriceCalculateHelpers _priceCalculateHelpers;

        public BulkUpdateOrderDetailsHandler(DataContext context, IMapper mapper, IOrderServices orderServices, IPriceCalculateHelpers priceCalculateHelpers)
        {
            _context = context;
            _mapper = mapper;
            _orderServices = orderServices;
            _priceCalculateHelpers = priceCalculateHelpers;
        }

        public async Task<Result<List<OrderDetailResponse>>> Handle(
            BulkUpdateOrderDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .SingleOrDefaultAsync(x => x.Id == request.OrderId);

            if (order == null)
            {
                return new Result<List<OrderDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can update products in order when it is New */
            if (order.Status != OrderStatus.New)
            {
                return new Result<List<OrderDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép chỉnh sửa sản phẩm trong đơn hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Make the request order detail list valid */
            var productsInOrder = new List<ProductInOrder>();
            _mapper.Map<List<UpdateOrderDetailsCommand>, List<ProductInOrder>>(
                request.OrderDetails, productsInOrder);

            productsInOrder = await _orderServices.MakeSureUpdateProductsInOrderValid(order.Id, productsInOrder);

            /** Update new change to all updated purchase propposal details */
            var orderDetailIds = productsInOrder
                .Select(x => x.Id);
            var updatedOrderDetailEntities = await _context.OrderDetails
                .Where(x => orderDetailIds.Contains(x.Id))
                .ToListAsync();

            /** Remove the old price of all updated order detail first then update it
             * and add the new price in */
            order.TotalPrice -= updatedOrderDetailEntities.Sum(x => x.TotalPrice);

            foreach(var od in updatedOrderDetailEntities)
            {
                // Map new info
                var matchedProductInOrder = productsInOrder
                    .SingleOrDefault(x => x.Id == od.Id);
                _mapper.Map<ProductInOrder, OrderDetail>(
                    matchedProductInOrder, od);

                od.QuantityNeed = od.Quantity;

                // Update price after update info
                od.TotalPrice = _priceCalculateHelpers.CalculateTotalPriceOfProduct(od.Quantity, od.SinglePrice);
            }

            order.TotalPrice += updatedOrderDetailEntities.Sum(x => x.TotalPrice);

            _context.OrderDetails.UpdateRange(updatedOrderDetailEntities);
            _context.Orders.Update(order);
            var created = await _context.SaveChangesAsync(); 

            if (created > 0)
            {
                return new Result<List<OrderDetailResponse>>(
                    _mapper.Map<List<OrderDetailResponse>>(updatedOrderDetailEntities)
                );
            }

            return new Result<List<OrderDetailResponse>>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa sản phẩm trong đơn hàng thất bại, xin thử lại"))
                );
        }
    }
}
