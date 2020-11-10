using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.Entities;
using api.Helpers;
using api.IServices;
using api.Services;
using AutoMapper;
using LanguageExt.Common;
using LanguageExt.Pipes;
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
    public class CreatePurchaseProposalFormCommand : IRequest<Result<PurchaseProposalFormResponse>>
    {
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public List<CreatePurchaseProposalDetailCommand> PurchaseProposalDetails { get; set; }
    }

    public class CreatePurchaseProposalFormHandler : IRequestHandler<CreatePurchaseProposalFormCommand, Result<PurchaseProposalFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPurchaseProposalServices _purchaseProposalService;

        public CreatePurchaseProposalFormHandler(DataContext context, IMapper mapper, IPurchaseProposalServices purchaseProposalService)
        {
            _context = context;
            _mapper = mapper;
            _purchaseProposalService = purchaseProposalService;
        }

        public async Task<Result<PurchaseProposalFormResponse>> Handle(
            CreatePurchaseProposalFormCommand request,
            CancellationToken cancellationToken)
        {
            request.PurchaseProposalDetails = await _purchaseProposalService.ValidateAdddedProducts(
               request.PurchaseProposalDetails);

            var purchaseProposalFormEntity = _mapper.Map<PurchaseProposalForm>(
                request
                );

            purchaseProposalFormEntity.Status = PurchaseProposalFormStatus.New;
            purchaseProposalFormEntity.OnTimeOrNotStatus = PurchaseProposalFormOnTimeOrNotStatus.New;

            await _context.AddAsync(purchaseProposalFormEntity);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<PurchaseProposalFormResponse>(
                    _mapper.Map<PurchaseProposalFormResponse>(purchaseProposalFormEntity)
                );
            }
            return new Result<PurchaseProposalFormResponse>(
                _mapper.Map<PurchaseProposalFormResponse>(
                    new BadRequestException(new ApiError("Tạo đề nghị mua hàng xảy ra lỗi, xin thử lại"))
                    )
            );
        }
    }
}
