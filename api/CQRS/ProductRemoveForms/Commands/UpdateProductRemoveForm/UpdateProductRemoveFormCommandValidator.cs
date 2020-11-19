using api.Common.Enums;
using FluentValidation;

namespace api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveForm
{
    public class UpdateProductRemoveFormCommandValidator : AbstractValidator<UpdateProductRemoveFormCommand>
    {
        public UpdateProductRemoveFormCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == ProductRemoveFormStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status != ProductRemoveFormStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .Must(x => x == null || x == "")
                        .WithMessage("Không được phép cập nhật lý do");
            });
        }
    }
}