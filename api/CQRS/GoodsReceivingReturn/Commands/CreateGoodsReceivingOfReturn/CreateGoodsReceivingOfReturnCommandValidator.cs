using FluentValidation;

namespace api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturn
{
    public class CreateGoodsReceivingOfReturnCommandValidator : AbstractValidator<CreateGoodsReceivingOfReturnCommand>
    {
        public CreateGoodsReceivingOfReturnCommandValidator()
        {
            RuleFor(x => x.MerchandiseReturnProposalId)
               .NotNull()
               .GreaterThan(0)
                   .WithMessage("Id của phiếu đề nghị trả hàng không hợp lệ");
        }
    }
}