using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingNote
{
    public class UpdateGoodsReceivingNoteCommandValidator: AbstractValidator<UpdateGoodsReceivingNoteCommand>
    {
        public UpdateGoodsReceivingNoteCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == GoodsReceivingNoteStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status == GoodsReceivingNoteStatus.Pending ||
                x.Status == GoodsReceivingNoteStatus.Done || 
                x.Status == GoodsReceivingNoteStatus.New ||
                x.Status == GoodsReceivingNoteStatus.Approved,
                () =>
                {
                    RuleFor(x => x.ExceptionReason)
                        .Must(x => x == null || x == "")
                            .WithMessage("Không được phép cập nhật lý do");
                });
        }
    }
}
