using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.UpdateProducts
{
    public class PurchaseProposalFormsCommandValidator: AbstractValidator<UpdatePurchaseProposalFormCommand>
    {
        public PurchaseProposalFormsCommandValidator()
        {
            RuleFor(x => x.Deadline)
                .NotNull()
                    .WithMessage("Thời hạn hoàn tất mua hàng không được để trống")
                .GreaterThanOrEqualTo(DateTime.Now)
                    .WithMessage("Thời hạn hoàn tất mua hàng không được trước thời điểm hiện tại");

            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == PurchaseProposalFormStatus.Cancelled || x.Status == PurchaseProposalFormStatus.Cancelled, () =>
            {
                RuleFor(x => x.Description)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });
        }
    }
}
