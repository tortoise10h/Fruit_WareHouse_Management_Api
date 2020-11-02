using FluentValidation;

namespace api.CQRS.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommandValidator : AbstractValidator<CreateProductCategoryCommand>
    {
        public CreateProductCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
                   .WithMessage("Tên của loại sản phẩm không được để trống")
               .MaximumLength(255)
                   .WithMessage("Tên của loại sản phẩm tối đa là 255 ký tự");
        }
    }
}