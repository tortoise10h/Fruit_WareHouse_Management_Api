using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.CreateOrderDetails
{
    public class CreateOrderDetailsCommandValidator: AbstractValidator<CreateOrderDetailsCommand>
    {
        public CreateOrderDetailsCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng của sản phẩm trong đơn hàng không được để trống")
                .GreaterThan(0)
                    .WithMessage("Số lượng của sản phẩm trong đơn hàng không được nhỏ hơn 0");

            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");

            RuleFor(x => x.SinglePrice)
                .NotNull()
                    .WithMessage("Đơn giá của sản phẩm trong đơn hàng không được để trống")
                .GreaterThan(0)
                    .WithMessage("Đơn giá của sản phẩm trong đơn hàng không được nhỏ hơn 0");
        }
    }
}
