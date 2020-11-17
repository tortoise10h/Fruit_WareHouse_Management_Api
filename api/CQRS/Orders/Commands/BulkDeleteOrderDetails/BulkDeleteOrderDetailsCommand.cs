using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
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

namespace api.CQRS.Orders.Commands.BulkDeleteOrderDetails
{ 
    public class BulkDeleteOrderDetailsCommand : IRequest<Result<List<OrderDetailResponse>>>
    {
        public int OrderId { get; set; }
        public List<int> OrderDetailIds { get; set; }
    }

    public class BulkDeleteOrderDetailsHandler : IRequestHandler<BulkDeleteOrderDetailsCommand, Result<List<OrderDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IOrderServices _orderServices;

        public BulkDeleteOrderDetailsHandler(DataContext context, IMapper mapper, IOrderServices orderServices)
        {
            _context = context;
            _mapper = mapper;
            _orderServices = orderServices;
        }

        public async Task<Result<List<OrderDetailResponse>>> Handle(
            BulkDeleteOrderDetailsCommand request,
            CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == request.OrderId);

            if (order == null)
            {
                return new Result<List<OrderDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can delete products to purchase proposal form when it is
             * New or Processing */
            if (order.Status != OrderStatus.New)
            {
                return new Result<List<OrderDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép xoá sản phẩm trong đơn hàng khi đơn hàng đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate deleted list */
            // Unique list
            request.OrderDetailIds = request.OrderDetailIds
                .Distinct()
                .ToList();

            // Make sure all delete items are existed in purchase proposal form
            var deletedOrderDetails = await _context.OrderDetails
                .Where(x => x.OrderId == request.OrderId &&
                    request.OrderDetailIds.Contains(x.Id))
                .ToListAsync();
            if (deletedOrderDetails.Count() != request.OrderDetailIds.Count())
            {
                return new Result<List<OrderDetailResponse>>(
                    new NotFoundException()
                );
            }

            _context.OrderDetails.RemoveRange(deletedOrderDetails);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<OrderDetailResponse>>(
                    _mapper.Map<List<OrderDetailResponse>>(deletedOrderDetails)
                );
            }

            return new Result<List<OrderDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong đơn hàng xảy ra lỗi, xin thử lại"))
                );
        }
    }
}
