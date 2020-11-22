using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkDeleteMerchandiseReturnDetail
{
    public class BulkDeleteMerchandiseReturnDetailCommandValidator : AbstractValidator<BulkDeleteMerchandiseReturnDetailCommand>
    {
        public BulkDeleteMerchandiseReturnDetailCommandValidator()
        {
            RuleFor(x => x.MerchandiseReturnProposalId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu đề nghị trả hàng không hợp lệ");

            RuleFor(x => x.MerchandiseReturnDetailIds)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải chọn ít nhất một sản phẩm cần xóa khỏi phiếu đề nghị trả hàng");

            RuleForEach(x => x.MerchandiseReturnDetailIds)
                .GreaterThan(0)
                    .WithMessage("Id của sản phẩm cần xoá không hợp lệ");
        }
    }
}