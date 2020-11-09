using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsReceivingNotes.Commands.BulkUpdateGoodsReceivingDetail
{
    public class BulkUpdateGoodsReceivingDetailCommandValidator: AbstractValidator<BulkUpdateGoodsReceivingDetailCommand>
    {
        public BulkUpdateGoodsReceivingDetailCommandValidator()
        {
            RuleFor(x => x.GoodsReceivingDetails)
                .NotNull()
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm");

            RuleForEach(x => x.GoodsReceivingDetails)
                .SetValidator(new UpdateGoodsReceivingDetailCommandValidator());
        }
    }
}
