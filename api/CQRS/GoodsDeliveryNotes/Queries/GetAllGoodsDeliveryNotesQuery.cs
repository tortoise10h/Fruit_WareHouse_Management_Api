using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.GoodsDeliveryNotes.Queries
{
    public class GetAllGoodsDeliveryNotesQuery : PaginationQuery, IRequest<Result<PagedResponse<GoodsDeliveryNoteResponse>>>
    {

    }

    public class GetAllGoodsDeliveryNotesHandler : IRequestHandler<GetAllGoodsDeliveryNotesQuery, Result<PagedResponse<GoodsDeliveryNoteResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGoodsDeliveryNotesHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GoodsDeliveryNoteResponse>>> Handle(GetAllGoodsDeliveryNotesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GoodsDeliveryNotes.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    grn => grn.CreatedBy,
                    u => u.Id,
                    (gdn, u) =>
                    new E.GoodsDeliveryNote
                    {
                        Id = gdn.Id,
                        Status = gdn.Status,
                        ExceptionReason = gdn.ExceptionReason,
                        Description = gdn.Description,
                        CreatedAt = gdn.CreatedAt,
                        LastModifiedAt = gdn.LastModifiedAt,
                        OrderId = gdn.OrderId,
                        TotalPrice = gdn.TotalPrice,
                        User = u
                    }
                );

            var result = await _paginationHelper.Paginate<E.GoodsDeliveryNote, GoodsDeliveryNoteResponse>(
                queryable, query
            );

            return result;
        }
    }
}