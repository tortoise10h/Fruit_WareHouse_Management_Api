using FluentValidation;

namespace api.Contracts.V1.Dtos
{
    public class AddProductToSupplierDTO
    {
        public int ProductId { get; set; }
        public double Price { get; set; }

    }

    public class AddProductToSupplierDTOValidator : AbstractValidator<AddProductToSupplierDTO>
    {
        public AddProductToSupplierDTOValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull()
                .GreaterThan(0)
                    .WithMessage("Id của nhà cung cấp không hợp lệ");

            RuleFor(x => x.Price)
                .NotNull()
                    .WithMessage("Giá nhập của sản phẩm không được để trống")
                .GreaterThanOrEqualTo(0)
                    .WithMessage("Giá bán của sản phẩm không nhỏ hơn 0 đồng");
        }
    }
}