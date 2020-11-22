using System.Collections.Generic;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnDetail;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkUpdateMerchandiseReturnDetail
{
    public class BulkUpdateMerchandiseReturnDetailCommand : IRequest<MerchandiseReturnProposalResponse>
    {
        public int MerchandiseReturnProposalId { get; set; }
        public ICollection<UpdateMerchandiseReturnDetailCommand> MerchandiseReturnDetails { get; set; }
    }
}