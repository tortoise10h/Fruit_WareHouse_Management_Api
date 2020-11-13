using FluentValidation;

namespace api.CQRS.Suppliers.Commands.RemoveProductsFromSupplier
{
    public class RemoveProductsFromSupplierCommandValidator : AbstractValidator<RemoveProductsFromSupplierCommand>
    {
        public RemoveProductsFromSupplierCommandValidator()
        {
            RuleFor(x => x.SupplierId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của nhà cung cấp không hợp lệ");


            RuleFor(x => x.ProductIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải chọn ít nhất một sản phẩm cần xóa");

            RuleForEach(x => x.ProductIds)
                           .GreaterThan(0)
                               .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}