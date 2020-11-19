using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkDeleteGoodsDeliveryDetails
{
    public class BulkDeleteGoodsDeliveryDetailsCommandValidator: AbstractValidator<BulkDeleteGoodsDeliveryDetailsCommand>
    {
        public BulkDeleteGoodsDeliveryDetailsCommandValidator()
        {
            RuleFor(x => x.GoodsDeliveryDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải chọn ít nhất một sản phẩm khi xoá");

            RuleForEach(x => x.GoodsDeliveryDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}
