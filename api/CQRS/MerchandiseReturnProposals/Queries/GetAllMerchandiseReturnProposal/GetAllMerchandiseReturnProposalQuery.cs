using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Queries.GetAllMerchandiseReturnProposal
{
    public class GetAllMerchandiseReturnProposalQuery : PaginationQuery, IRequest<PagedResponse<MerchandiseReturnProposalResponse>>
    {
    }
}