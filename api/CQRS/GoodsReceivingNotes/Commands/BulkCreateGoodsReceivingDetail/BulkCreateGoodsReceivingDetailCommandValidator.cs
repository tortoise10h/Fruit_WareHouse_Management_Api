using api.CQRS.GoodsReceivingNotes.Commands.BulkCreateGoodsReceivingDetails;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsReceivingNotes.Commands.BulkCreateGoodsReceivingDetail
{
    public class BulkCreateGoodsReceivingDetailCommandValidator: AbstractValidator<BulkCreateGoodsReceivingDetailCommand>
    {
        public BulkCreateGoodsReceivingDetailCommandValidator()
        {
            RuleFor(x => x.GoodsReceivingDetails)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu nhập kho cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu nhập kho cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.GoodsReceivingDetails)
                .SetValidator(new CreateGoodsReceivingDetailCommandValidator());
        }
    }
}
