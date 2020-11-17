using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.UpdateOrderDetails
{
    public class UpdateOrderDetailsCommandValidator: AbstractValidator<UpdateOrderDetailsCommand>
    {
        public UpdateOrderDetailsCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .GreaterThan(0)
                    .WithMessage("Số lượg không được phép nhỏ hơn 0");

            RuleFor(x => x.SinglePrice)
                .GreaterThan(0)
                    .WithMessage("Đơn giá của sản phẩm trong đơn hàng không được nhỏ hơn 0");

            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id không được bỏ trống")
                .GreaterThan(0)
                    .WithMessage("Id không hợp lệ");
        }
    }
}
