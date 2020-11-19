using FluentValidation;

namespace api.CQRS.ProductRemoveForms.Commands.DeleteProductRemoveDetail
{
    public class DeleteProductRemoveDetailCommandValidator : AbstractValidator<DeleteProductRemoveDetailCommand>
    {
        public DeleteProductRemoveDetailCommandValidator()
        {
            RuleFor(x => x.ProductRemoveFormId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu huỷ sản phẩm không hợp lệ");

            RuleFor(x => x.ProductRemoveDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu kiểm kho khi xoá");

            RuleForEach(x => x.ProductRemoveDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}