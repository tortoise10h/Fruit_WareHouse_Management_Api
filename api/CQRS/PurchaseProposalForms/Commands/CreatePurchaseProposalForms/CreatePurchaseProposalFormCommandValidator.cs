using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms
{
    public class CreatePurchaseProposalFormCommandValidator: AbstractValidator<CreatePurchaseProposalFormCommand>
    {
        public CreatePurchaseProposalFormCommandValidator()
        {
            RuleFor(x => x.Deadline)
                .NotNull()
                    .WithMessage("Thời hạn mua hàng không được để trống");

            RuleForEach(x => x.PurchaseProposalDetails)
                .SetValidator(new CreatePurchaseProposalDetailCommandValidator());
        }
    }
}
