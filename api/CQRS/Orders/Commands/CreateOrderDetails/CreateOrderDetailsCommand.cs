using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Orders;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = api.Entities;

namespace api.CQRS.Orders.Commands.CreateOrderDetails
{
    public class CreateOrderDetailsCommand : IRequest<Result<OrderDetailResponse>>
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double SinglePrice { get; set; }
    }

    public class CreateOrderDetailsHandler : IRequestHandler<CreateOrderDetailsCommand, Result<OrderDetailResponse>>
    {
        public CreateOrderDetailsHandler()
        {
        }

        public Task<Result<OrderDetailResponse>> Handle(
            CreateOrderDetailsCommand request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
