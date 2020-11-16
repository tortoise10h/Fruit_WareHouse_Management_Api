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
        }
    }
}
