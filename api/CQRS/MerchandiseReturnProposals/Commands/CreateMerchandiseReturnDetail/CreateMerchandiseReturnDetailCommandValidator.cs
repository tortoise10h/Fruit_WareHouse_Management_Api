using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail
{
    public class CreateMerchandiseReturnDetailCommandValidator : AbstractValidator<CreateMerchandiseReturnDetailCommand>
    {
        public CreateMerchandiseReturnDetailCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng trả lại của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Số lượng trả lại của sản phẩm không được nhỏ hơn 0");

            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");
        }
    }
}