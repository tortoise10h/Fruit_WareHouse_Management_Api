using System;
using FluentValidation;

namespace api.CQRS.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommandValidator : AbstractValidator<UpdateProductCategoryCommand>
    {
        public UpdateProductCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
                  .WithMessage("Tên của loại sản phẩm không được để trống")
              .MaximumLength(255)
                  .WithMessage("Tên của loại sản phẩm tối đa là 255 ký tự");
        }
    }
}
