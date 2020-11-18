using api.Contracts.V1.Dtos;
using FluentValidation;

namespace api.CQRS.InventoryRecordForms.Commands.UpdateInventoryDetail
{
    public class UpdateInventoryDetailCommandValidator : AbstractValidator<UpdateInventoryDetailCommand>
    {
        public UpdateInventoryDetailCommandValidator()
        {
            RuleFor(x => x.InventoryRecordFormId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu kiểm kho không hợp lệ");

            RuleFor(x => x.InventoryRecordDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu kiểm kho khi cập nhật");

            RuleForEach(x => x.InventoryRecordDetails)
                .SetValidator(new UpdateProductInInventoryRecordDetailValidator());
        }
    }
}