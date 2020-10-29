using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.BulkUpdatePurchaseProposalDetails
{
    public class BulkCreatePurchaseProposalDetailCommandValidator: AbstractValidator<BulkUpdatePurchaseProposalDetailCommand>
    {
        public BulkCreatePurchaseProposalDetailCommandValidator()
        {
            RuleFor(x => x.PurchaseProposalDetails)
                .NotNull()
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm");

            RuleForEach(x => x.PurchaseProposalDetails)
                .SetValidator(new UpdatePurchaseProposalDetailCommandValidator());
        }
    }
}
