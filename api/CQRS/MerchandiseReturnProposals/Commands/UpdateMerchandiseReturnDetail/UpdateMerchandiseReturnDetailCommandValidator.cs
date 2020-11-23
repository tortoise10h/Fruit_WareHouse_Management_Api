using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnDetail
{
    public class UpdateMerchandiseReturnDetailCommandValidator : AbstractValidator<UpdateMerchandiseReturnDetailCommand>
    {
        public UpdateMerchandiseReturnDetailCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id của chi tiết phiếu đề nghị trả hàng không được được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của chi tiết phiếu đề nghị trả hàng không hợp lệ");

            RuleFor(x => x.Quantity)
                .GreaterThan(0)
                  .WithMessage("Số lượng trả lại của sản phẩm không được phép nhỏ hơn 0");
        }
    }
}
