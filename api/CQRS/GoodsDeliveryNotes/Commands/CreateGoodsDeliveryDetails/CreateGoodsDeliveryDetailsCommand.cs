using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails
{
    public class CreateGoodsDeliveryDetailsCommand : IRequest<Result<GoodsDeliveryDetailResponse>>
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CreateGoodsDeliveryDetailsHandler : IRequestHandler<CreateGoodsDeliveryDetailsCommand, Result<GoodsDeliveryDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGoodsDeliveryDetailsHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<GoodsDeliveryDetailResponse>> Handle(
            CreateGoodsDeliveryDetailsCommand request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
