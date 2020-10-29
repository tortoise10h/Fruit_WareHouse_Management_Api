using api.Common.Enums;
using api.Contracts.V1.Exceptions;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
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

namespace api.CQRS.PurchaseProposalForms.Commands.BulkUpdatePurchaseProposalDetails
{ 
    public class BulkUpdatePurchaseProposalDetailCommand : IRequest<Result<List<PurchaseProposalDetailResponse>>>
    {
        public int PurchaseProposalFormId { get; set; }
        public List<UpdatePurchaseProposalDetailCommand> PurchaseProposalDetails { get; set; }
    }

    public class BulkUpdatePurchaseProposalDetailHandler : IRequestHandler<BulkUpdatePurchaseProposalDetailCommand, Result<List<PurchaseProposalDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPurchaseProposalService _purchaseProposalFormService;

        public BulkUpdatePurchaseProposalDetailHandler(DataContext context, IMapper mapper, IPurchaseProposalService purchaseProposalFormService)
        {
            _context = context;
            _mapper = mapper;
            _purchaseProposalFormService = purchaseProposalFormService;
        }

        public async Task<Result<List<PurchaseProposalDetailResponse>>> Handle(
            BulkUpdatePurchaseProposalDetailCommand request,
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

            /** Only can update products to purchase proposal form when it is
             * New or Processing */
            if (!(purchaseProposalForm.Status == PurchaseProposalFormStatus.Processing ||
                purchaseProposalForm.Status == PurchaseProposalFormStatus.New))
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép chỉnh sửa sản phẩm trong phiếu đề nghị mua hàng khi đang ở trạng thái 'Mới' hoặc 'Đang xử lý'"))
                    );
            }

            var updatedPurchaseProposalDetailEntities = await _purchaseProposalFormService.PrepareListProductWhenUpdatePruchaseProposalDetail(request.PurchaseProposalDetails, request.PurchaseProposalFormId);

            _context.PurchaseProposalDetails.UpdateRange(updatedPurchaseProposalDetailEntities);

            var created = await _context.SaveChangesAsync(); 

            if (created > 0)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    _mapper.Map<List<PurchaseProposalDetailResponse>>(updatedPurchaseProposalDetailEntities)
                );
            }

            return new Result<List<PurchaseProposalDetailResponse>>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa sản phẩm trong phiếu đề nghị lỗi, xin thử lại"))
                );
        }
    }
}
