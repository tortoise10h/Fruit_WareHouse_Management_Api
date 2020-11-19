using api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryDetail;
using FluentValidation;

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkUpdateGoodsDeliveryDetail
{
    public class BulkUpdateGoodsDeliveryDetailsCommandValidator: AbstractValidator<BulkUpdateGoodsDeliveryDetailsCommand>
    {
        public BulkUpdateGoodsDeliveryDetailsCommandValidator()
        {
            RuleFor(x => x.GoodsDeliveryDetails)
                .NotNull()
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Danh sách phải có ít nhất một sản phẩm");

            RuleForEach(x => x.GoodsDeliveryDetails)
                .SetValidator(new UpdateGoodsDeliveryDetailsCommandValidator());
        }
    }
}
