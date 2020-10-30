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

namespace api.CQRS.PurchaseProposalForms.Commands.UpdateProducts
{
    public class UpdatePurchaseProposalFormCommand : IRequest<Result<PurchaseProposalFormResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExceptionReason { get; set; }
        public DateTime Deadline { get; set; }
        public PurchaseProposalFormStatus Status { get; set; }
    }

    public class UpdatePurchaseProposalHandler : IRequestHandler<UpdatePurchaseProposalFormCommand, Result<PurchaseProposalFormResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdatePurchaseProposalHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<PurchaseProposalFormResponse>> Handle(UpdatePurchaseProposalFormCommand request, CancellationToken cancellationToken)
        {
            var purchaseProposalForm = await _context.PurchaseProposalForms
                .SingleOrDefaultAsync(x => x.Id == request.Id);
            if (purchaseProposalForm == null)
            {
                return new Result<PurchaseProposalFormResponse>(
                    new NotFoundException()
                );
            }

            /** Only  allow update purchase proposal form when it is new */
            if (!(purchaseProposalForm.Status == PurchaseProposalFormStatus.Processing ||
                purchaseProposalForm.Status == PurchaseProposalFormStatus.New))
            {
                throw new BadRequestException(
                    new ApiError("Chỉ pho phép chỉnh sửa phiếu đề nghị mua hàng khi đang ở trạng thái 'Mới' hoặc 'Đang xử lý'"));
            }

            /** If status is changed then make sure it's valid */
            if (purchaseProposalForm.Status != request.Status)
            {
                ValidateWhenUpdateStatus(purchaseProposalForm, request.Status);
            }

            _mapper.Map<UpdatePurchaseProposalFormCommand, E.PurchaseProposalForm>(request, purchaseProposalForm);

            _context.PurchaseProposalForms.Update(purchaseProposalForm);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<PurchaseProposalFormResponse>(
                    _mapper.Map<PurchaseProposalFormResponse>(purchaseProposalForm)
                );
            }

            return new Result<PurchaseProposalFormResponse>(
                new BadRequestException(
                    new ApiError("Chỉnh sửa thông tin phiếu đề nghị mua hàng thất bại, xin thử lại"))
            );
        }

        public void ValidateWhenUpdateStatus(PurchaseProposalForm purchaseProposalForm, PurchaseProposalFormStatus newStatus)
        {
            if (newStatus == PurchaseProposalFormStatus.Processing)
            {
                if (purchaseProposalForm.Status != PurchaseProposalFormStatus.New)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép thay đổi trạng thái thành 'Đang xử lý' khi phiếu đang ở trạng thái 'Mới'"));
                }
            } else if (newStatus == PurchaseProposalFormStatus.Cancelled)
            {
                // TODO: Handle validate must be no import bill exist
            } else if (newStatus == PurchaseProposalFormStatus.ForceDone)
            {
                if (purchaseProposalForm.Status != PurchaseProposalFormStatus.Processing)
                {
                    throw new BadRequestException(
                        new ApiError("Chỉ cho phép 'Buộc hoàn tất' phiếu đề nghị mua hàng khi nó đang ở trạng thái 'Đang xử lý'"));
                }
                // TODO: Make sure there is at least 1 import bill for it
            }
        }
    }
}