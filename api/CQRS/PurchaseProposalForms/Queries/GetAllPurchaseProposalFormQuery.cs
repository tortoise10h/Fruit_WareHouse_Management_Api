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
            queryable = queryable.AsNoTracking();
            /** TODO: Include import bill */
            var result = await _paginationHelper.Paginate<E.PurchaseProposalForm, PurchaseProposalFormResponse>(
                queryable, query
            );

            return result;
        }
    }
}