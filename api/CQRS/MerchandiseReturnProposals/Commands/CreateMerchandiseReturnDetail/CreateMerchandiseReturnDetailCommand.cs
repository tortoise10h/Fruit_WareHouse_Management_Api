using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail
{
    public class CreateMerchandiseReturnDetailCommand : IRequest<MerchandiseReturnDetailResponse>
    {
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
    }
}