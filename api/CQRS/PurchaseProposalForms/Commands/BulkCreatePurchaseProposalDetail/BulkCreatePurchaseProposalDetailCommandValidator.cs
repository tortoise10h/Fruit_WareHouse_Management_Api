using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.BulkCreatePurchaseProposalDetails
{
    public class BulkCreatePurchaseProposalDetailCommandValidator: AbstractValidator<BulkCreatePurchaseProposalDetailCommand>
    {
        public BulkCreatePurchaseProposalDetailCommandValidator()
        {
            RuleFor(x => x.PurchaseProposalDetails)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu đề nghị cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu đề nghị cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.PurchaseProposalDetails)
                .SetValidator(new CreatePurchaseProposalDetailCommandValidator());
        }
    }
}
