using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.InventoryRecordForms.Queries
{
    public class GetInventoryRecordFormById : IRequest<Result<InventoryRecordFormResponse>>
    {
        public GetInventoryRecordFormById(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetInventoryRecordFormByIdHandler : IRequestHandler<GetInventoryRecordFormById, Result<InventoryRecordFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetInventoryRecordFormByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<InventoryRecordFormResponse>> Handle(GetInventoryRecordFormById request, CancellationToken cancellationToken)
        {
            var queryable = _context.InventoryRecordForms.AsQueryable();
            queryable = queryable.AsNoTracking();

            queryable = queryable
                .Include(irf => irf.InventoryRecordDetails)
                    .ThenInclude(ird => ird.Product)
                        .ThenInclude(p => p.ProductUnits)
                .Where(
                    irf => irf.Id == request.Id);

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

            var inventoryRecordForm = await queryable.FirstOrDefaultAsync();

            if (inventoryRecordForm == null)
            {
                return new Result<InventoryRecordFormResponse>(
                    new NotFoundException()
                );
            }

            return new Result<InventoryRecordFormResponse>(
                _mapper.Map<InventoryRecordFormResponse>(inventoryRecordForm)
            );
        }
    }
}