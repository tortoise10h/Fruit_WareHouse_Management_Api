using FluentValidation;

namespace api.Contracts.V1.Dtos
{
    public class CreateProductInGoodsReceivingOfReturnDetail
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CreateProductInGoodsReceivingOfReturnDetailValidator : AbstractValidator<CreateProductInGoodsReceivingOfReturnDetail>
    {
        public CreateProductInGoodsReceivingOfReturnDetailValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull()
                    .WithMessage("Id của sản phẩm không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm không hợp lệ");

            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng sản phẩm trong phiếu nhập kho trả hàng không được để trống");
        }
    }

    public class UpdateProductInGoodsReceivingOfReturnDetail
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class UpdateProductInGoodsReceivingOfReturnDetailValidator : AbstractValidator<UpdateProductInGoodsReceivingOfReturnDetail>
    {
        public UpdateProductInGoodsReceivingOfReturnDetailValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                    .WithMessage("Id của phiếu nhập kho trả hàng không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của phiếu nhập kho trả hàng không hợp lệ");

            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng sản phẩm trong phiếu nhập kho trả hàng không được để trống");
        }
    }
}