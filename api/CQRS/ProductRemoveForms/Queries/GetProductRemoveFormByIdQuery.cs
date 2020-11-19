using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.ProductRemoveForms.Queries
{
    public class GetProductRemoveFormByIdQuery : IRequest<Result<ProductRemoveFormResponse>>
    {
        public GetProductRemoveFormByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetProductRemoveFormByIdHandler : IRequestHandler<GetProductRemoveFormByIdQuery, Result<ProductRemoveFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetProductRemoveFormByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<ProductRemoveFormResponse>> Handle(GetProductRemoveFormByIdQuery request, CancellationToken cancellationToken)
        {
            var queryable = _context.ProductRemoveForms.AsQueryable();
            queryable = queryable.AsNoTracking();

            queryable = queryable
                .Include(prf => prf.ProductRemoveDetails)
                    .ThenInclude(prd => prd.Product)
                        .ThenInclude(p => p.ProductUnits)
                .Where(
                    prf => prf.Id == request.Id);

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

            var inventoryRecordForm = await queryable.FirstOrDefaultAsync();

            if (inventoryRecordForm == null)
            {
                return new Result<ProductRemoveFormResponse>(
                    new NotFoundException()
                );
            }

            return new Result<ProductRemoveFormResponse>(
                _mapper.Map<ProductRemoveFormResponse>(inventoryRecordForm)
            );
        }
    }
}