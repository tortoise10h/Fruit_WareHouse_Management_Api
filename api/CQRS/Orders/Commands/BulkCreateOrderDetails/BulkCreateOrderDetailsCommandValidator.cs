using api.CQRS.Orders.Commands.CreateOrderDetails;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.BulkCreateOrderDetails
{
    public class BulkCreateOrderDetailsCommandValidator: AbstractValidator<BulkCreateOrderDetailsCommand>
    {
        public BulkCreateOrderDetailsCommandValidator()
        {
            RuleFor(x => x.OrderDetails)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho đơn hàng cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho đơn hàng cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.OrderDetails)
                .SetValidator(new CreateOrderDetailsCommandValidator());
        }
    }
}
