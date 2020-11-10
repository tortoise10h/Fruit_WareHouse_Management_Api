using api.Common.Enums;
using api.Contracts.V1.Exceptions;
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

namespace api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms
{
    public class CreatePurchaseProposalDetailCommand : IRequest<Result<PurchaseProposalDetailResponse>>
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CreatePurchaseProposalDetailHandler : IRequestHandler<CreatePurchaseProposalDetailCommand, Result<PurchaseProposalDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreatePurchaseProposalDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<PurchaseProposalDetailResponse>> Handle(
            CreatePurchaseProposalDetailCommand request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
