using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Helpers;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.CQRS.Products.Queries
{
    public class GetPurchaseProposalFormByIdQuery : IRequest<Result<PurchaseProposalFormResponse>>
    {
        public GetPurchaseProposalFormByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetPurchaseProposalFormByIdQueryHandler : IRequestHandler<GetPurchaseProposalFormByIdQuery, Result<PurchaseProposalFormResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetPurchaseProposalFormByIdQueryHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<PurchaseProposalFormResponse>> Handle(
            GetPurchaseProposalFormByIdQuery request,
            CancellationToken cancellationToken)
        {
            // TODO: include import bill
            var purchaseProposalForm = await _context.PurchaseProposalForms
                .Include(ppf => ppf.PurchaseProposalDetails)
                    .ThenInclude(ppd => ppd.Product)
                        .ThenInclude(p => p.ProductUnits)
                .SingleOrDefaultAsync(
                    ppf => ppf.Id == request.Id);

            if (purchaseProposalForm == null)
            {
                return new Result<PurchaseProposalFormResponse>(
                    new NotFoundException()
                );
            }

            return new Result<PurchaseProposalFormResponse>(
                _mapper.Map<PurchaseProposalFormResponse>(purchaseProposalForm)
            );
        }
    }
}
