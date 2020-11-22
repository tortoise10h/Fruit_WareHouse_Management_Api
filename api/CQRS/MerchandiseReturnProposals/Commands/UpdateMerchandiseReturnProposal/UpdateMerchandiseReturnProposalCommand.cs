using api.Common.Enums;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnProposal
{
    public class UpdateMerchandiseReturnProposalCommand : IRequest<MerchandiseReturnProposalResponse>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public MerchandiseReturnProposalStatus Status { get; set; }
    }
}