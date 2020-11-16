using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.Orders.Commands.UpdateOrders
{
    public class UpdateOrdersCommandValidator: AbstractValidator<UpdateOrdersCommand>
    {
        public UpdateOrdersCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == OrderStatus.Cancelled, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status == OrderStatus.Processing ||
                x.Status == OrderStatus.Done || 
                x.Status == OrderStatus.Exported || 
                x.Status == OrderStatus.New,
                () =>
                {
                    RuleFor(x => x.ExceptionReason)
                        .Must(x => x == null || x == "")
                            .WithMessage("Không được phép cập nhật lý do");
                });
        }
    }
}
