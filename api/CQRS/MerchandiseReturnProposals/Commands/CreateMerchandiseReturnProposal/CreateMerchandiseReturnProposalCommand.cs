using System.Collections.Generic;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal
{
    public class CreateMerchandiseReturnProposalCommand : IRequest<MerchandiseReturnProposalResponse>
    {
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public int GoodsDeliveryNoteId { get; set; }
        public ICollection<CreateMerchandiseReturnDetailCommand> MerchandiseReturnDetails { get; set; }
    }
}