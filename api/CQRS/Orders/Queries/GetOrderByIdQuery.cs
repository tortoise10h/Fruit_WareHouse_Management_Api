using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Queries
{
    public class GetOrderByIdQuery : IRequest<Result<OrderResponse>>
    {
        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<OrderResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetOrderByIdQueryHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<OrderResponse>> Handle(
            GetOrderByIdQuery request,
            CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(ppd => ppd.Product)
                        .ThenInclude(p => p.ProductUnits)
                .SingleOrDefaultAsync(
                    o => o.Id == request.Id);

            if (order == null)
            {
                return new Result<OrderResponse>(
                    new NotFoundException()
                );
            }

            return new Result<OrderResponse>(
                _mapper.Map<OrderResponse>(order)
            );
        }
    }
}
