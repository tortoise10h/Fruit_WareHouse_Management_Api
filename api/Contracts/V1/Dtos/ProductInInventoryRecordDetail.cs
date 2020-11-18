using FluentValidation;

namespace api.Contracts.V1.Dtos
{
    public class CreateProductInInventoryRecordDetail
    {
        public int ProductId { get; set; }
        public double ActualQuantity { get; set; }
    }

    public class CreateProductInInventoryRecordDetailValidator : AbstractValidator<CreateProductInInventoryRecordDetail>
    {
        public CreateProductInInventoryRecordDetailValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");

            RuleFor(x => x.ActualQuantity)
                .NotNull()
                    .WithMessage("Số lượng thực tế của sản phẩm trong phiếu chi tiết kiểm kho không được để trống");
        }
    }

    public class UpdateProductInInventoryRecordDetail
    {
        public int Id { get; set; }
        public double ActualQuantity { get; set; }
    }

    public class UpdateProductInInventoryRecordDetailValidator : AbstractValidator<UpdateProductInInventoryRecordDetail>
    {
        public UpdateProductInInventoryRecordDetailValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id của phiếu chi tiết kiểm kho không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của phiếu chi tiết kiểm kho không hợp lệ");

            RuleFor(x => x.ActualQuantity)
                .NotNull()
                    .WithMessage("Số lượng thực tế của sản phẩm trong phiếu chi tiết kiểm kho không được để trống");
        }
    }
}