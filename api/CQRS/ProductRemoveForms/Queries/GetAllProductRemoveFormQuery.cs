using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Helpers;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.ProductRemoveForms.Queries
{
    public class GetAllProductRemoveFormQuery : PaginationQuery, IRequest<Result<PagedResponse<ProductRemoveFormResponse>>>
    {

    }

    public class GetAllProductRemoveFormQueryHandler : IRequestHandler<GetAllProductRemoveFormQuery, Result<PagedResponse<ProductRemoveFormResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        public GetAllProductRemoveFormQueryHandler(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<ProductRemoveFormResponse>>> Handle(GetAllProductRemoveFormQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.ProductRemoveForms.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    prf => prf.CreatedBy,
                    u => u.Id,
                    (prf, u) =>
                    new E.ProductRemoveForm
                    {
                        Id = prf.Id,
                        Description = prf.Description,
                        ExceptionReason = prf.ExceptionReason,
                        Status = prf.Status,
                        CreatedAt = prf.CreatedAt,
                        LastModifiedAt = prf.LastModifiedAt,
                        User = u,
                        ProductRemoveDetails = prf.ProductRemoveDetails
                    }
                );

            var result = await _paginationHelper.Paginate<E.ProductRemoveForm, ProductRemoveFormResponse>(
                queryable, query
            );

            return result;
        }
    }
}