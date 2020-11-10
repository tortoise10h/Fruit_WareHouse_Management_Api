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

namespace api.CQRS.PurchaseProposalForms.Commands.BulkDeletePurchaseProposalDetails
{ 
    public class BulkDeletePurchaseProposalDetailCommand : IRequest<Result<List<PurchaseProposalDetailResponse>>>
    {
        public int PurchaseProposalFormId { get; set; }
        public List<int> PurchaseProposalDetailIds { get; set; }
    }

    public class BulkDeletePurchaseProposalDetailHandler : IRequestHandler<BulkDeletePurchaseProposalDetailCommand, Result<List<PurchaseProposalDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPurchaseProposalService _purchaseProposalFormService;

        public BulkDeletePurchaseProposalDetailHandler(DataContext context, IMapper mapper, IPurchaseProposalService purchaseProposalFormService)
        {
            _context = context;
            _mapper = mapper;
            _purchaseProposalFormService = purchaseProposalFormService;
        }

        public async Task<Result<List<PurchaseProposalDetailResponse>>> Handle(
            BulkDeletePurchaseProposalDetailCommand request,
            CancellationToken cancellationToken)
        {
            var purchaseProposalForm = await _context.PurchaseProposalForms
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == request.PurchaseProposalFormId);

            if (purchaseProposalForm == null)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new NotFoundException()
                );
            }

            /** Only can delete products to purchase proposal form when it is
             * New or Processing */
            if (purchaseProposalForm.Status != PurchaseProposalFormStatus.New)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ được phép xoá trong phiếu đề nghị mua hàng khi đang ở trạng thái 'Mới'"))
                    );
            }

            /** Validate deleted list */
            // Unique list
            request.PurchaseProposalDetailIds = request.PurchaseProposalDetailIds
                .Distinct()
                .ToList();

            // Make sure all delete items are existed in purchase proposal form
            var deletedPurchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == request.PurchaseProposalFormId &&
                    request.PurchaseProposalDetailIds.Contains(x.Id))
                .ToListAsync();
            if (deletedPurchaseProposalDetails.Count() != request.PurchaseProposalDetailIds.Count())
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    new NotFoundException()
                );
            }

            _context.PurchaseProposalDetails.RemoveRange(deletedPurchaseProposalDetails);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<PurchaseProposalDetailResponse>>(
                    _mapper.Map<List<PurchaseProposalDetailResponse>>(deletedPurchaseProposalDetails)
                );
            }

            return new Result<List<PurchaseProposalDetailResponse>>(
                new BadRequestException(
                    new ApiError("Xoá sản phẩm trong phiếu đề nghị xảy ra lỗi, xin thử lại"))
                );
        }
    }
}
