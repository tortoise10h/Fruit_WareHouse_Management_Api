using api.Common.Enums;
using FluentValidation;

namespace api.CQRS.InventoryRecordForms.Commands.UpdateInventoryForms
{
    public class UpdateInventoryFormCommandValidator : AbstractValidator<UpdateInventoryFormCommand>
    {
        public UpdateInventoryFormCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == InventoryRecordFormStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status != InventoryRecordFormStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .Must(x => x == null || x == "")
                        .WithMessage("Không được phép cập nhật lý do");
            });
        }
    }
}