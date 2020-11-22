using api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnDetail;
using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkUpdateMerchandiseReturnDetail
{
    public class BulkUpdateMerchandiseReturnDetailCommandValidator : AbstractValidator<BulkUpdateMerchandiseReturnDetailCommand>
    {
        public BulkUpdateMerchandiseReturnDetailCommandValidator()
        {
            RuleFor(x => x.MerchandiseReturnProposalId)
                .NotNull()
                .GreaterThan(0)
                    .WithMessage("Id của phiếu đề nghị trả hàng không hợp lệ");

            RuleFor(x => x.MerchandiseReturnDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải chọn ít nhất một sản phẩm");

            RuleForEach(x => x.MerchandiseReturnDetails)
                .SetValidator(new UpdateMerchandiseReturnDetailCommandValidator());
        }
    }
}