using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryNotes
{
    public class UpdateGoodsDeliveryNotesCommandValidator: AbstractValidator<UpdateGoodsDeliveryNotesCommand>
    {
        public UpdateGoodsDeliveryNotesCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == GoodsDeliveryNoteStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status == GoodsDeliveryNoteStatus.Pending ||
                x.Status == GoodsDeliveryNoteStatus.Done || 
                x.Status == GoodsDeliveryNoteStatus.New ||
                x.Status == GoodsDeliveryNoteStatus.Approved,
                () =>
                {
                    RuleFor(x => x.ExceptionReason)
                        .Must(x => x == null || x == "")
                            .WithMessage("Không được phép cập nhật lý do");
                });
        }
    }
}
