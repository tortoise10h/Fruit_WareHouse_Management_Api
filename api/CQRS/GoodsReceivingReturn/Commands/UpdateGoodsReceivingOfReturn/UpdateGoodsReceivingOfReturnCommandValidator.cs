using api.Common.Enums;
using FluentValidation;

namespace api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturn
{
    public class UpdateGoodsReceivingOfReturnCommandValidator : AbstractValidator<UpdateGoodsReceivingOfReturnCommand>
    {
        public UpdateGoodsReceivingOfReturnCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == GoodsReceivingOfReturnStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status != GoodsReceivingOfReturnStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .Must(x => x == null || x == "")
                        .WithMessage("Không được phép cập nhật lý do");
            });
        }
    }
}