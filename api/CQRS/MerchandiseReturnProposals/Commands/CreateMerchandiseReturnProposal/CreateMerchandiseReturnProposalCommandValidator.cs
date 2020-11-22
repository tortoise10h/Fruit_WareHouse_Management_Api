using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail;
using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal
{
    public class CreateMerchandiseReturnProposalCommandValidator : AbstractValidator<CreateMerchandiseReturnProposalCommand>
    {
        public CreateMerchandiseReturnProposalCommandValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(255)
                    .WithMessage("Mô tả tối đa là 255 ký tự");

            RuleFor(x => x.GoodsDeliveryNoteId)
                .NotNull()
                    .WithMessage("Id của phiếu xuất kho không được để trống")
                .GreaterThan(0)
                    .WithMessage("Id của phiếu xuất kho không hợp lệ");

            RuleFor(x => x.MerchandiseReturnDetails)
                .Must(x => x != null && x.Count > 0)
                    .WithMessage("Phiếu đề nghị trả hàng phải có ít nhất một sản phẩm");

            RuleForEach(x => x.MerchandiseReturnDetails)
                .SetValidator(new CreateMerchandiseReturnDetailCommandValidator());
        }
    }
}