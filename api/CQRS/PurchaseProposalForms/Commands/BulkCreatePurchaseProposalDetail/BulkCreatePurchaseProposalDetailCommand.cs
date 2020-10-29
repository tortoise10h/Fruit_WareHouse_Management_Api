using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.Entities;
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

namespace api.CQRS.PurchaseProposalForms.Commands.BulkCreatePurchaseProposalDetails
{ 
    public class BulkCreatePurchaseProposalDetailCommand : IRequest<Result<List<PurchaseProposalDetailResponse>>>
    {
        public int PurchaseProposalFormId { get; set; }
        public List<CreatePurchaseProposalDetailCommand> PurchaseProposalDetails { get; set; }
    }

    public class BulkCreatePurchaseProposalDetailHandler : IRequestHandler<BulkCreatePurchaseProposalDetailCommand, Result<List<PurchaseProposalDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPurchaseProposalService _purchaseProposalFormService;

        public BulkCreatePurchaseProposalDetailHandler(DataContext context, IMapper mapper, IPurchaseProposalService purchaseProposalFormService)
        {
            _context = context;
            _mapper = mapper;
            _purchaseProposalFormService = purchaseProposalFormService;
        }

        public async Task<Result<List<PurchaseProposalDetailResponse>>> Handle(
            BulkCreatePurchaseProposalDetailCommand request,
            CancellationToken cancellationToken)
        {
            var purchaseProposalForm = await _context.PurchaseProposalForms
                .SingleOrDefaultAsync(x => x.Id == request.PurchaseProposalFormId);
            /** Make sure create purchase proposal detail for valid
             * purchase proposal form */
            if (purchaseProposalForm == null)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can add new products to purchase proposal form when it is
             * New or Processing */
            if (purchaseProposalForm.Status != PurchaseProposalFormStatus.New)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép thêm sản phẩm vào phiếu đề nghị mua hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            request.PurchaseProposalDetails = await _purchaseProposalFormService.ValidateAdddedProducts(request.PurchaseProposalDetails);

            await _purchaseProposalFormService.ValidateUniqueProductsInPurchaseProposalForm(request.PurchaseProposalDetails, purchaseProposalForm.Id);

            /** Preapre new list purchase proposal detail entity */
            var purchaseProposalDetailEntities = _mapper.Map<List<PurchaseProposalDetail>>(request.PurchaseProposalDetails);
            foreach(var ppd in purchaseProposalDetailEntities)
            {
                ppd.PurchaseProposalFormId = request.PurchaseProposalFormId;
            }

            await _context.PurchaseProposalDetails.AddRangeAsync(purchaseProposalDetailEntities);

            var created = await _context.SaveChangesAsync(); 

            if (created > 0)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    _mapper.Map<List<PurchaseProposalDetailResponse>>(purchaseProposalDetailEntities)
                );
            }

            return new Result<List<PurchaseProposalDetailResponse>>(
                new BadRequestException(
                    new ApiError("Thêm sản phẩm vào phiếu đề nghị lỗi, xin thử lại"))
                );
        }
    }
}
