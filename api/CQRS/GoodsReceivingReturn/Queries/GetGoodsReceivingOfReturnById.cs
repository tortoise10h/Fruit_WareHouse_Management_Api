using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using E = api.Entities;

namespace api.CQRS.GoodsReceivingReturn.Queries
{
    public class GetGoodsReceivingOfReturnById : IRequest<Result<GoodsReceivingOfReturnResponse>>
    {
        public GetGoodsReceivingOfReturnById(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

    public class GetGoodsReceivingOfReturnByIdHandler : IRequestHandler<GetGoodsReceivingOfReturnById, Result<GoodsReceivingOfReturnResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetGoodsReceivingOfReturnByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GoodsReceivingOfReturnResponse>> Handle(GetGoodsReceivingOfReturnById request, CancellationToken cancellationToken)
        {
            var queryable = _context.GoodsReceivingOfReturns.AsQueryable();
            queryable = queryable.AsNoTracking();

            queryable = queryable
                .Include(grr => grr.GoodsReceivingOfReturnDetails)
                    .ThenInclude(grrd => grrd.Product)
                        .ThenInclude(p => p.ProductUnits)
                .Where(
                    grr => grr.Id == request.Id);

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

            var goodsReceivingOfReturn = await queryable.FirstOrDefaultAsync();

            if (goodsReceivingOfReturn == null)
            {
                return new Result<GoodsReceivingOfReturnResponse>(
                    new NotFoundException()
                );
            }

            return new Result<GoodsReceivingOfReturnResponse>(
                _mapper.Map<GoodsReceivingOfReturnResponse>(goodsReceivingOfReturn)
            );
        }
    }
}