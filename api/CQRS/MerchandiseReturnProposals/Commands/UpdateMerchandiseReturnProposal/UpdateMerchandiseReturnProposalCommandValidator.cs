using api.Common.Enums;
using FluentValidation;

namespace api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnProposal
{
    public class UpdateMerchandiseReturnProposalCommandValidator : AbstractValidator<UpdateMerchandiseReturnProposalCommand>
    {
        public UpdateMerchandiseReturnProposalCommandValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(255)
                    .WithMessage("Mô tả tối đa là 255 ký tự");

            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            RuleFor(x => x.Status)
                .NotEqual(MerchandiseReturnProposalStatus.Done)
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == MerchandiseReturnProposalStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status != MerchandiseReturnProposalStatus.Cancelled, () =>
                {
                    RuleFor(x => x.ExceptionReason)
                        .Must(x => x == null || x == "")
                            .WithMessage("Không được phép cập nhật lý do");
                });
        }
    }
}