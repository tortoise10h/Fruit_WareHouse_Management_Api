using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturnDetail
{
    public class UpdateGoodsReceivingOfReturnDetailCommandValidator : AbstractValidator<UpdateGoodsReceivingOfReturnDetailCommand>
    {
        public UpdateGoodsReceivingOfReturnDetailCommandValidator()
        {
            RuleFor(x => x.GoodsReceivingOfReturnId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu nhập kho trả hàng không hợp lệ");

            RuleFor(x => x.GoodsReceivingOfReturnDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu nhập kho trả hàng khi cập nhật");

            RuleForEach(x => x.GoodsReceivingOfReturnDetails)
                .SetValidator(new UpdateProductInGoodsReceivingOfReturnDetailValidator());
        }
    }
}