using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.Orders;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.Orders.Queries
{
    public class GetAllOrdersQuery : PaginationQuery, IRequest<Result<PagedResponse<OrderResponse>>>
    {

    }

    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, Result<PagedResponse<OrderResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllOrdersHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<OrderResponse>>> Handle(GetAllOrdersQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.Orders.AsQueryable();
            queryable = queryable.AsNoTracking();
            // TODO: Include goods delivery note
            queryable = queryable
                .Join(_context.Users,
                    o => o.CreatedBy,
                    u => u.Id,
                    (o, u) =>
                    new E.Order
                    {
                        Id = o.Id,
                        Status = o.Status,
                        Description = o.Description,
                        ExceptionReason = o.ExceptionReason,
                        CreatedAt = o.CreatedAt,
                        LastModifiedAt = o.LastModifiedAt,
                        TotalPrice = o.TotalPrice,
                        User = u
                    }
                );

            var result = await _paginationHelper.Paginate<E.Order, OrderResponse>(
                queryable, query
            );

            return result;
        }
    }
}