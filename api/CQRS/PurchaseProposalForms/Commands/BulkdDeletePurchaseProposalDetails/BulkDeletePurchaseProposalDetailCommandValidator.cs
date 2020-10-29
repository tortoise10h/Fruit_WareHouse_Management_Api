using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.BulkDeletePurchaseProposalDetails
{
    public class BulkDeletePurchaseProposalDetailCommandValidator: AbstractValidator<BulkDeletePurchaseProposalDetailCommand>
    {
        public BulkDeletePurchaseProposalDetailCommandValidator()
        {
            RuleFor(x => x.PurchaseProposalDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu đề nghị khi xoá");

            RuleForEach(x => x.PurchaseProposalDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}
