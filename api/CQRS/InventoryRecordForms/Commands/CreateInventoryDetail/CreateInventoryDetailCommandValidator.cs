using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.InventoryRecordForms.Commands.CreateInventoryDetail
{
    public class CreateInventoryDetailCommandValidator : AbstractValidator<CreateInventoryDetailCommand>
    {
        public CreateInventoryDetailCommandValidator()
        {
            RuleFor(x => x.InventoryRecordFormId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu kiểm kho không hợp lệ");

            RuleFor(x => x.Products)
                .NotNull()
                    .WithMessage("Khi thêm sản phẩm cho phiếu kiểm kho cần có ít nhất 1 sản phẩm")
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Khi thêm sản phẩm cho phiếu kiểm kho cần có ít nhất 1 sản phẩm");

            RuleForEach(x => x.Products)
                .SetValidator(new CreateProductInInventoryRecordDetailValidator());
        }
    }
}