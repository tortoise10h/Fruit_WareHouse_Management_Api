using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using api.Contracts.V1.Exceptions;
using api.Common.Enums;
using api.Helpers;
using E = api.Entities;
using api.IServices;
using api.Contracts.V1.ResponseModels.Orders;

namespace api.CQRS.Orders.Commands.UpdateOrders
{
    public class UpdateOrdersCommand : IRequest<Result<OrderResponse>>
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
    }

    public class UpdateOrdersHandler : IRequestHandler<UpdateOrdersCommand, Result<OrderResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IOrderServices _orderServices;

        public UpdateOrdersHandler(DataContext context, IMapper mapper, IOrderServices purchaseProposalServices)
        {
            _context = context;
            _mapper = mapper;
            _orderServices = purchaseProposalServices;
        }

        public async Task<Result<OrderResponse>> Handle(UpdateOrdersCommand request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .SingleOrDefaultAsync(x => x.Id == request.Id);

            if (order == null)
            {
                return new Result<OrderResponse>(
                    new NotFoundException()
                );
            }
            if (order.Status == OrderStatus.Done || order.Status == OrderStatus.Cancelled)
            {
                throw new BadRequestException(
                    new ApiError("Đơn hàng này không được phép chỉnh sửa"));
            }

            /** If status is changed then make sure it's valid and do business
             * base on each status */
            if (order.Status != request.Status)
            {
                await _orderServices.ValidateWhenUpdateStatus(order, request.Status);

                await _orderServices.HandleBusinessWhenStatusIsChanged(
                    _context,
                    order,
                    request.Status);
            }

            _mapper.Map<UpdateOrdersCommand, E.Order>(request, order);

            _context.Orders.Update(order);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<OrderResponse>(
                    _mapper.Map<OrderResponse>(order)
                );
            }

            return new Result<OrderResponse>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa thông tin của đơn hàng thất bại, xin thử lại"))
            );
        }
    }
}