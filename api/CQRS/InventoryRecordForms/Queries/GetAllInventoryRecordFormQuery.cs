using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.InventoryRecordForms.Queries
{
    public class GetAllInventoryRecordFormQuery : PaginationQuery, IRequest<Result<PagedResponse<InventoryRecordFormResponse>>>
    {

    }

    public class GetAllInventoryRecordFormQueryHandle : IRequestHandler<GetAllInventoryRecordFormQuery, Result<PagedResponse<InventoryRecordFormResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllInventoryRecordFormQueryHandle(DataContext context, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<InventoryRecordFormResponse>>> Handle(GetAllInventoryRecordFormQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.InventoryRecordForms.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Join(_context.Users,
                    irf => irf.CreatedBy,
                    u => u.Id,
                    (irf, u) =>
                    new E.InventoryRecordForm
                    {
                        Id = irf.Id,
                        Description = irf.Description,
                        ExceptionReason = irf.ExceptionReason,
                        Status = irf.Status,
                        CreatedAt = irf.CreatedAt,
                        LastModifiedAt = irf.LastModifiedAt,
                        User = u,
                        InventoryRecordDetails = irf.InventoryRecordDetails
                    }
                );

            var result = await _paginationHelper.Paginate<E.InventoryRecordForm, InventoryRecordFormResponse>(
                queryable, query
            );

            return result;
        }
    }
}