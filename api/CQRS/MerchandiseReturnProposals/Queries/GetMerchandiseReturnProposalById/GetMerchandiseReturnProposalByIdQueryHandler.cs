using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.Entities;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace api.CQRS.MerchandiseReturnProposals.Queries.GetMerchandiseReturnProposalById
{
    public class GetMerchandiseReturnProposalByIdQueryHandler : IRequestHandler<GetMerchandiseReturnProposalByIdQuery, MerchandiseReturnProposalResponse>
    {

        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetMerchandiseReturnProposalByIdQueryHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<MerchandiseReturnProposalResponse> Handle(GetMerchandiseReturnProposalByIdQuery request, CancellationToken cancellationToken)
        {

            var queryable = _context.MerchandiseReturnProposals.AsQueryable();
            queryable = queryable.AsNoTracking();
            queryable = queryable
                .Include(mrp => mrp.GoodsDeliveryNote)
                .Include(mrp => mrp.MerchandiseReturnDetails)
                    .ThenInclude(mrd => mrd.Product);

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
                       MerchandiseReturnDetails = mrp.MerchandiseReturnDetails,
                       CreatedAt = mrp.CreatedAt,
                       User = u,
                   }
               );

            var merchandiseReturnProposals = await queryable.SingleOrDefaultAsync(mrp => mrp.Id == request.Id);

            if (merchandiseReturnProposals == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<MerchandiseReturnProposalResponse>(merchandiseReturnProposals);
        }
    }
}