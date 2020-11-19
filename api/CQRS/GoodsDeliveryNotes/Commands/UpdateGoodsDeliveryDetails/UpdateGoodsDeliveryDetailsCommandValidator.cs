using FluentValidation;

namespace api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryDetail
{
    public class UpdateGoodsDeliveryDetailsCommandValidator: AbstractValidator<UpdateGoodsDeliveryDetailsCommand>
    {
        public UpdateGoodsDeliveryDetailsCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .GreaterThan(0)
                    .WithMessage("Số lượg không được phép nhỏ hơn 0");

            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");
        }
    }
}
