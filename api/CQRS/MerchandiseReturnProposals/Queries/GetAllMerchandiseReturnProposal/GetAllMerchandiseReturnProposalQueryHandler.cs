using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.MerchandiseReturnProposals.Queries.GetAllMerchandiseReturnProposal
{
    public class GetAllMerchandiseReturnProposalQueryHandler : IRequestHandler<GetAllMerchandiseReturnProposalQuery, PagedResponse<MerchandiseReturnProposalResponse>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllMerchandiseReturnProposalQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<PagedResponse<MerchandiseReturnProposalResponse>> Handle(GetAllMerchandiseReturnProposalQuery query, CancellationToken cancellationToken)
        {
            //TODO: Include phiếu nhập kho trả hàng
            var queryable = _context.MerchandiseReturnProposals.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Include(mrp => mrp.GoodsDeliveryNote);

            queryable = queryable
               .Join(_context.Users,
                   mrp => mrp.CreatedBy,
                   u => u.Id,
                   (mrp, u) =>
                   new MerchandiseReturnProposal
                   {
                       Id = mrp.Id,
                       Description = mrp.Description,
                       ExceptionReason = mrp.ExceptionReason,
                       Status = mrp.Status,
                       GoodsDeliveryNote = mrp.GoodsDeliveryNote,
                       GoodsDeliveryNoteId = mrp.GoodsDeliveryNoteId,
                       CreatedAt = mrp.CreatedAt,
                       User = u,
                   }
               );

            var result = await _paginationHelper.Paginate<MerchandiseReturnProposal, MerchandiseReturnProposalResponse>(
                queryable, query
            );

            return result;
        }
    }
}