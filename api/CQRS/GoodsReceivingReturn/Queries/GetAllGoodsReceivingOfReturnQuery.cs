using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.GoodsReceivingReturn.Queries
{
    public class GetAllGoodsReceivingOfReturnQuery : PaginationQuery, IRequest<Result<PagedResponse<GoodsReceivingOfReturnResponse>>>
    {

    }

    public class GetAllGoodsReceivingOfReturnQueryHandler : IRequestHandler<GetAllGoodsReceivingOfReturnQuery, Result<PagedResponse<GoodsReceivingOfReturnResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGoodsReceivingOfReturnQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GoodsReceivingOfReturnResponse>>> Handle(GetAllGoodsReceivingOfReturnQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GoodsReceivingOfReturns.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    grr => grr.CreatedBy,
                    u => u.Id,
                    (grr, u) =>
                    new E.GoodsReceivingOfReturn
                    {
                        Id = grr.Id,
                        MerchandiseReturnProposalId = grr.MerchandiseReturnProposalId,
                        Status = grr.Status,
                        Description = grr.Description,
                        ExceptionReason = grr.ExceptionReason,
                        CreatedAt = grr.CreatedAt,
                        LastModifiedAt = grr.LastModifiedAt,
                        User = u,
                        GoodsReceivingOfReturnDetails = grr.GoodsReceivingOfReturnDetails
                    }
                );

            var result = await _paginationHelper.Paginate<E.GoodsReceivingOfReturn, GoodsReceivingOfReturnResponse>(
                queryable, query
            );

            return result;
        }
    }
}