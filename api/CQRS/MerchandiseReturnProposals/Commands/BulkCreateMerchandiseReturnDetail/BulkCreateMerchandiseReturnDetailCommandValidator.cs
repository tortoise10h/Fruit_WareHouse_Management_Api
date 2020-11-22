using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail;
using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.BulkCreateMerchandiseReturnDetail
{
    public class BulkCreateMerchandiseReturnDetailCommandValidator : AbstractValidator<BulkCreateMerchandiseReturnDetailCommand>
    {
        public BulkCreateMerchandiseReturnDetailCommandValidator()
        {
            RuleFor(x => x.MerchandiseReturnProposalId)
                .NotNull()
                .GreaterThan(0)
                    .WithMessage("Id của phiếu đề nghị trả hàng không hợp lệ");

            RuleFor(x => x.MerchandiseReturnDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phải thêm ít nhất một sản phẩm");

            RuleForEach(x => x.MerchandiseReturnDetails)
                .SetValidator(new CreateMerchandiseReturnDetailCommandValidator());
        }
    }
}