using System.Collections.Generic;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkDeleteMerchandiseReturnDetail
{
    public class BulkDeleteMerchandiseReturnDetailCommand : IRequest
    {
        public int MerchandiseReturnProposalId { get; set; }
        public ICollection<int> MerchandiseReturnDetailIds { get; set; }
    }
}