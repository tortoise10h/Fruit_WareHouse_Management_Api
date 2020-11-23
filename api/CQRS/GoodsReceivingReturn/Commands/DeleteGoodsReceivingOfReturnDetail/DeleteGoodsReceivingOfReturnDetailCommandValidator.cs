using FluentValidation;

namespace api.CQRS.GoodsReceivingReturn.Commands.DeleteGoodsReceivingOfReturnDetail
{
    public class DeleteGoodsReceivingOfReturnDetailCommandValidator : AbstractValidator<DeleteGoodsReceivingOfReturnDetailCommand>
    {
        public DeleteGoodsReceivingOfReturnDetailCommandValidator()
        {
            RuleFor(x => x.GoodsReceivingOfReturnId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu nhập kho trả hàng không hợp lệ");

            RuleFor(x => x.GoodsReceivingOfReturnDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu nhập kho trả hàng khi xoá");

            RuleForEach(x => x.GoodsReceivingOfReturnDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}