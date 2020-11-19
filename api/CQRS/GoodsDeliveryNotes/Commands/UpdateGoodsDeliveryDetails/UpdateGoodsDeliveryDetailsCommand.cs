using System;
using System.Threading;
using System.Threading.Tasks;
using LanguageExt.Common;
using MediatR;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;

namespace api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryDetail
{
    public class UpdateGoodsDeliveryDetailsCommand : IRequest<Result<GoodsDeliveryDetailResponse>>
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class UpdateGoodsDeliveryDetailsHandler : IRequestHandler<UpdateGoodsDeliveryDetailsCommand, Result<GoodsDeliveryDetailResponse>>
    {
        public UpdateGoodsDeliveryDetailsHandler()
        {
        }

        public Task<Result<GoodsDeliveryDetailResponse>> Handle(UpdateGoodsDeliveryDetailsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}