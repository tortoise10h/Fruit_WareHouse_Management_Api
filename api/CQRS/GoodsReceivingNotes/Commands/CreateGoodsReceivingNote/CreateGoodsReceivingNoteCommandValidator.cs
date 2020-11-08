using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingNote
{
    public class CreateGoodsReceivingNoteCommandValidator: AbstractValidator<CreateGoodsReceivingNoteCommand>
    {
        public CreateGoodsReceivingNoteCommandValidator()
        {
            When(x => x.SupplierId == null,
                () =>
                {
                    RuleFor(x => x.SupplierName)
                        .NotEmpty()
                            .WithMessage("Xin hãy nhập vào nơi mua hàng");
                });

            RuleFor(x => x.PurchaseProposalFormId)
                .NotNull()
                    .WithMessage("Id của phiếu đề nghị mua hàng không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của phiếu đề nghị mua hàng không hợp lệ");

            RuleFor(x => x.GoodsReceivingDetails)
                .Must(x => x != null && x.Count() > 0)
                    .WithMessage("Phiếu nhập kho phải có ít nhất một sản phẩm");

            RuleForEach(x => x.GoodsReceivingDetails)
                .SetValidator(new CreateGoodsReceivingDetailCommandValidator());
        }
    }
}
