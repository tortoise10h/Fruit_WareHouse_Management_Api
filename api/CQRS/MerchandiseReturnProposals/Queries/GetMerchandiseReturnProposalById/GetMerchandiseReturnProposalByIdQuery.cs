using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Queries.GetMerchandiseReturnProposalById
{
    public class GetMerchandiseReturnProposalByIdQuery : IRequest<MerchandiseReturnProposalResponse>
    {
        public int Id { get; }
        public GetMerchandiseReturnProposalByIdQuery(int id)
        {
            Id = id;
        }
    }
}