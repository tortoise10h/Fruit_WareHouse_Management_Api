using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryNotes
{
    public class CreateGoodsDeliveryNotesCommandValidator: AbstractValidator<CreateGoodsDeliveryNotesCommand>
    {
        public CreateGoodsDeliveryNotesCommandValidator()
        {
            RuleFor(x => x.OrderId)
                .NotNull()
                    .WithMessage("Id của đơn hàng không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của đơn hàng không hợp lệ");

            RuleFor(x => x.GoodsDeliveryDetails)
                .Must(x => x != null && x.Count() > 0)
                    .WithMessage("Phiếu xuất kho phải có ít nhất một sản phẩm");

            RuleForEach(x => x.GoodsDeliveryDetails)
                .SetValidator(new CreateGoodsDeliveryDetailsCommandValidator());
        }
    }
}
