using System.Threading;
using System.Threading.Tasks;
using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Helpers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkDeleteMerchandiseReturnDetail
{
    public class BulkDeleteMerchandiseReturnDetailCommandHandler : IRequestHandler<BulkDeleteMerchandiseReturnDetailCommand>
    {
        private readonly DataContext _context;

        public BulkDeleteMerchandiseReturnDetailCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(BulkDeleteMerchandiseReturnDetailCommand request, CancellationToken cancellationToken)
        {
            var merchandiseReturnProposal = await _context.MerchandiseReturnProposals
               .SingleOrDefaultAsync(mrp => mrp.Id == request.MerchandiseReturnProposalId);

            if (merchandiseReturnProposal == null)
            {
                throw new NotFoundException();
            }

            if (merchandiseReturnProposal.Status != MerchandiseReturnProposalStatus.New)
            {
                throw new BadRequestException(new ApiError("Chỉ được xóa sản phẩm khi phiếu đề nghị trả hàng ở trạng thái 'Mới'"));
            }


            /** Make sure all product id in list is unique */
            var merchandiseReturnDetailIds = request.MerchandiseReturnDetailIds.Distinct();

            // Make sure all delete items are existed in merchandise return proposal
            var deleteMerchandiseReturnDetails = await _context.MerchandiseReturnDetails
              .Where(x => x.MerchandiseReturnProposalId == request.MerchandiseReturnProposalId &&
                  request.MerchandiseReturnDetailIds.Contains(x.Id))
              .ToListAsync();

            if (deleteMerchandiseReturnDetails.Count() != request.MerchandiseReturnDetailIds.Count())
            {
                throw new NotFoundException();
            }

            _context.MerchandiseReturnDetails.RemoveRange(deleteMerchandiseReturnDetails);

            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}