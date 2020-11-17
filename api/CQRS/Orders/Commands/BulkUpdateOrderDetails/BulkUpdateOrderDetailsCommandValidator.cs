using api.CQRS.Orders.Commands.UpdateOrderDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.BulkUpdateOrderDetails
{
    public class BulkUpdateOrderDetailsCommandValidator: AbstractValidator<BulkUpdateOrderDetailsCommand>
    {
        public BulkUpdateOrderDetailsCommandValidator()
        {
            RuleFor(x => x.OrderDetails)
                .NotNull()
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm");

            RuleForEach(x => x.OrderDetails)
                .SetValidator(new UpdateOrderDetailsCommandValidator());
        }
    }
}
