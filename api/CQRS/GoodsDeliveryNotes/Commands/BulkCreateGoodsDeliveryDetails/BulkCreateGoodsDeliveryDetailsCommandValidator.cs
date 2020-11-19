using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails;
using FluentValidation;

namespace api.CQRS.GoodsDeliveryNotes.Commands.BulkCreateGoodsDeliveryDetails
{
    public class BulkCreateGoodsDeliveryDetailsCommandValidator: AbstractValidator<BulkCreateGoodsDeliveryDetailsCommand>
    {
        public BulkCreateGoodsDeliveryDetailsCommandValidator()
        {
            RuleFor(x => x.GoodsDeliveryDetails)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu xuất kho cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu xuất kho cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.GoodsDeliveryDetails)
                .SetValidator(new CreateGoodsDeliveryDetailsCommandValidator());
        }
    }
}
