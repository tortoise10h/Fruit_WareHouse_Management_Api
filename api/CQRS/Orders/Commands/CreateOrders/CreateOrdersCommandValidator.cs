using api.CQRS.Orders.Commands.CreateOrderDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.CreateOrders
{
    public class CreateOrdersCommandValidator: AbstractValidator<CreateOrdersCommand>
    {
        public CreateOrdersCommandValidator()
        {
            RuleFor(x => x.OrderDetails)
                .Must(x => x != null && x.Count() > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm khi tạo đơn hàng");

            RuleForEach(x => x.OrderDetails)
                .SetValidator(new CreateOrderDetailsCommandValidator());
        }
    }
}
