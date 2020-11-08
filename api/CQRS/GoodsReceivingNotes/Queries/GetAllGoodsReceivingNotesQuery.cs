using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.GoodsReceivingNotes.Queries
{
    public class GetAllGoodsReceivingNotesQuery : PaginationQuery, IRequest<Result<PagedResponse<GoodsReceivingNoteResponse>>>
    {

    }

    public class GetAllGoodsReceivingNotesHandler : IRequestHandler<GetAllGoodsReceivingNotesQuery, Result<PagedResponse<GoodsReceivingNoteResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGoodsReceivingNotesHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GoodsReceivingNoteResponse>>> Handle(GetAllGoodsReceivingNotesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GoodsReceivingNotes.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    grn => grn.CreatedBy,
                    u => u.Id,
                    (grn, u) =>
                    new E.GoodsReceivingNote
                    {
                        Id = grn.Id,
                        Status = grn.Status,
                        SupplierName = grn.SupplierName,
                        SupplierId = grn.SupplierId,
                        ExceptionReason = grn.ExceptionReason,
                        Description = grn.Description,
                        TotalPrice = grn.TotalPrice,
                        CreatedAt = grn.CreatedAt,
                        LastModifiedAt = grn.LastModifiedAt,
                        User = u
                    }
                );

            var result = await _paginationHelper.Paginate<E.GoodsReceivingNote, GoodsReceivingNoteResponse>(
                queryable, query
            );

            return result;
        }
    }
}