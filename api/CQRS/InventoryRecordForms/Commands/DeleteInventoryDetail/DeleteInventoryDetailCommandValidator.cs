using FluentValidation;

namespace api.CQRS.InventoryRecordForms.Commands.DeleteInventoryDetail
{
    public class DeleteInventoryDetailCommandValidator : AbstractValidator<DeleteInventoryDetailCommand>
    {
        public DeleteInventoryDetailCommandValidator()
        {
            RuleFor(x => x.InventoryDetailsIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải có ít nhất một sản phẩm trong phiếu kiểm kho khi xoá");

            RuleForEach(x => x.InventoryDetailsIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}