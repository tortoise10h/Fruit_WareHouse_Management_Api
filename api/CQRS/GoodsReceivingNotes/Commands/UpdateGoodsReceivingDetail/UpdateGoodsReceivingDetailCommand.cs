using System;
using System.Threading;
using System.Threading.Tasks;
using LanguageExt.Common;
using MediatR;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;

namespace api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail
{
    public class UpdateGoodsReceivingDetailCommand : IRequest<Result<GoodsReceivingDetailResponse>>
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double SinglePurchasePrice { get; set; }
        public string Description { get; set; }
    }

    public class UpdateGoodsReceivingDetailHandler : IRequestHandler<UpdateGoodsReceivingDetailCommand, Result<GoodsReceivingDetailResponse>>
    {
        public UpdateGoodsReceivingDetailHandler()
        {
        }

        public Task<Result<GoodsReceivingDetailResponse>> Handle(UpdateGoodsReceivingDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}