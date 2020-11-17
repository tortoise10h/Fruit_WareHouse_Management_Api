using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.BulkDeleteOrderDetails
{
    public class BulkDeleteOrderDetailsCommandValidator: AbstractValidator<BulkDeleteOrderDetailsCommand>
    {
        public BulkDeleteOrderDetailsCommandValidator()
        {
            RuleFor(x => x.OrderDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi xoá sản phẩm trong đơn hàng cần ít nhất 1 sản phẩm");

            RuleForEach(x => x.OrderDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}
