using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveDetail
{
    public class CreateProductRemoveDetailCommandValidator : AbstractValidator<CreateProductRemoveDetailCommand>
    {
        public CreateProductRemoveDetailCommandValidator()
        {
            RuleFor(x => x.ProductRemoveFormId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu huỷ sản phẩm không hợp lệ");

            RuleFor(x => x.Products)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu huỷ sản phẩm cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu huỷ sản phẩm cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.Products)
                .SetValidator(new CreateProductInProductRemoveDetailValidator());
        }
    }
}