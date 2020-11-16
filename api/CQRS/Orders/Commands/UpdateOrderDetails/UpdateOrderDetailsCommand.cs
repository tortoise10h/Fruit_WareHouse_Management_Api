using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using api.Contracts.V1.Exceptions;
using api.Common.Enums;
using api.Helpers;
using E = api.Entities;
using api.Entities;
using api.Contracts.V1.ResponseModels.Orders;

namespace api.CQRS.Orders.Commands.UpdateOrderDetails
{
    public class UpdateOrderDetailsCommand : IRequest<Result<OrderDetailResponse>>
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double SinglePrice { get; set; }
    }

    public class UpdateOrderDetailsHandler : IRequestHandler<UpdateOrderDetailsCommand, Result<OrderDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateOrderDetailsHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<OrderDetailResponse>> Handle(UpdateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}