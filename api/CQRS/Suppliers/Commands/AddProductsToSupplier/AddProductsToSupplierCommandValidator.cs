using FluentValidation;
using api.Contracts.V1.Dtos;

namespace api.CQRS.Suppliers.Commands.AddProductsToSupplier
{
    public class AddProductToSupplierCommandValidator : AbstractValidator<AddProductsToSupplierCommand>
    {
        public AddProductToSupplierCommandValidator()
        {
            RuleFor(x => x.SupplierId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của nhà cung cấp không hợp lệ");

            RuleFor(x => x.Products)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải chọn ít nhất một sản phẩm");

            RuleForEach(x => x.Products)
                .SetValidator(new AddProductToSupplierDTOValidator());
        }
    }
}