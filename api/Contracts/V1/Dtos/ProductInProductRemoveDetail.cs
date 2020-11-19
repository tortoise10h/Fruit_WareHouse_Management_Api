using FluentValidation;

namespace api.Contracts.V1.Dtos
{
    public class CreateProductInProductRemoveDetail
    {
        public int ProductId { get; set; }
        public double RemovedQuantity { get; set; }
    }

    public class CreateProductInProductRemoveDetailValidator : AbstractValidator<CreateProductInProductRemoveDetail>
    {
        public CreateProductInProductRemoveDetailValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");
            RuleFor(x => x.RemovedQuantity)
                .NotNull()
                    .WithMessage("Số lượng huỷ của sản phẩm trong phiếu huỷ sản phẩm không được để trống");
        }
    }

    public class UpdateProductInProductRemoveDetail
    {
        public int Id { get; set; }
        public double RemovedQuantity { get; set; }
    }

    public class UpdateProductInProductRemoveDetailValidator : AbstractValidator<UpdateProductInProductRemoveDetail>
    {
        public UpdateProductInProductRemoveDetailValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id của phiếu huỷ sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của phiếu huỷ sản phẩm không hợp lệ");

            RuleFor(x => x.RemovedQuantity)
                .NotNull()
                    .WithMessage("Số lượng huỷ sản phẩm trong phiếu huỷ không được để trống");
        }
    }

}