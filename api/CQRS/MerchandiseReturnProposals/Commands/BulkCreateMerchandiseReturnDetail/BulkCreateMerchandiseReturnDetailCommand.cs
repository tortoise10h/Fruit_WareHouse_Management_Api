using System.Collections.Generic;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkCreateMerchandiseReturnDetail
{
    public class BulkCreateMerchandiseReturnDetailCommand : IRequest<List<MerchandiseReturnDetailResponse>>
    {
        public int MerchandiseReturnProposalId { get; set; }
        public ICollection<CreateMerchandiseReturnDetailCommand> MerchandiseReturnDetails { get; set; }
    }
}