using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveDetail
{
    public class UpdateProductRemoveDetailCommandValidator : AbstractValidator<UpdateProductRemoveDetailCommand>
    {
        public UpdateProductRemoveDetailCommandValidator()
        {
            RuleFor(x => x.ProductRemoveFormId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu huỷ sản phẩm không hợp lệ");

            RuleFor(x => x.ProductRemoveDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu huỷ khi cập nhật");

            RuleForEach(x => x.ProductRemoveDetails)
                .SetValidator(new UpdateProductInProductRemoveDetailValidator());
        }
    }
}