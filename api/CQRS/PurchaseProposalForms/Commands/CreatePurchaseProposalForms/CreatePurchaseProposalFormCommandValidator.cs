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
                    .WithMessage("Thời hạn mua hàng không được để trống")
                .Must(x => DateTime.Compare(x, DateTime.Now) > 0)
                    .WithMessage("Thời hạn mua hàng không được sớm hơn thời điểm hiện tại");

            RuleFor(x => x.PurchaseProposalDetails)
                .Must(x => x.Count() > 0)
                    .WithMessage("Phiếu đề nghị phải có ít nhất một sản phẩm");

            RuleForEach(x => x.PurchaseProposalDetails)
                .SetValidator(new CreatePurchaseProposalDetailCommandValidator());
        }
    }
}
