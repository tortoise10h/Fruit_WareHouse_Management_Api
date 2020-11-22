using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using MediatR;

namespace api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnDetail
{
    public class UpdateMerchandiseReturnDetailCommand : IRequest<MerchandiseReturnDetailResponse>
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturned { get; set; }
        public string Description { get; set; }
    }
}