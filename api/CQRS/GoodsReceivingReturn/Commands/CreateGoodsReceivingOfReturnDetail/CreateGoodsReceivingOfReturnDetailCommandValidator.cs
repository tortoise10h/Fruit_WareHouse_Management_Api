using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturnDetail
{
    public class CreateGoodsReceivingOfReturnDetailCommandValidator : AbstractValidator<CreateGoodsReceivingOfReturnDetailCommand>
    {
        public CreateGoodsReceivingOfReturnDetailCommandValidator()
        {
            RuleFor(x => x.GoodsReceivingOfReturnId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu nhập kho trả hàng không hợp lệ");

            RuleFor(x => x.Products)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu nhập kho trả hàng cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu nhập kho trả hàng cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.Products)
                .SetValidator(new CreateProductInGoodsReceivingOfReturnDetailValidator());
        }
    }
}