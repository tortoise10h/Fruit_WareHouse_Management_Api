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
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Entities;

namespace api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails
{
    public class UpdatePurchaseProposalDetailCommand : IRequest<Result<PurchaseProposalFormResponse>>
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class UpdatePurchaseProposalDetailHandler : IRequestHandler<UpdatePurchaseProposalDetailCommand, Result<PurchaseProposalFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdatePurchaseProposalDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Result<PurchaseProposalFormResponse>> Handle(UpdatePurchaseProposalDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}