using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails
{
    public class CreateGoodsDeliveryDetailsCommandValidator: AbstractValidator<CreateGoodsDeliveryDetailsCommand>
    {
        public CreateGoodsDeliveryDetailsCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng của sản phẩm trong phiếu xuất kho không được để trống")
                .GreaterThan(0)
                    .WithMessage("Số lượng của sản phẩm trong phiếu nhập kho không được nhỏ hơn 0");

            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");
        }
    }
}
