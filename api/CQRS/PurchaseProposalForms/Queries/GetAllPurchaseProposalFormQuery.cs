using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace src.CQRS.PurchaseProposalForms.Queries
{
    public class GetAllPurchaseProposalFormQuery : PaginationQuery, IRequest<Result<PagedResponse<PurchaseProposalFormResponse>>>
    {

    }

    public class GetAllPurchaseProposalFormHandler : IRequestHandler<GetAllPurchaseProposalFormQuery, Result<PagedResponse<PurchaseProposalFormResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllPurchaseProposalFormHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<PurchaseProposalFormResponse>>> Handle(GetAllPurchaseProposalFormQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.PurchaseProposalForms.AsQueryable();
            /** TODO: Include import bill */
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    ppf => ppf.CreatedBy,
                    u => u.Id,
                    (ppf, u) =>
                    new E.PurchaseProposalForm
                    {
                        Id = ppf.Id,
                        Deadline = ppf.Deadline,
                        Status = ppf.Status,
                        OnTimeOrNotStatus = ppf.OnTimeOrNotStatus,
                        Description = ppf.Description,
                        ExceptionReason = ppf.ExceptionReason,
                        CreatedAt = ppf.CreatedAt,
                        LastModifiedAt = ppf.LastModifiedAt,
                        User = u
                    }
                );

            var result = await _paginationHelper.Paginate<E.PurchaseProposalForm, PurchaseProposalFormResponse>(
                queryable, query
            );

            return result;
        }
    }
}