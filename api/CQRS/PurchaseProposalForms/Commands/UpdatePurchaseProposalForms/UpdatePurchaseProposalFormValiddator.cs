﻿using api.Common.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.UpdateProducts
{
    public class PurchaseProposalFormsCommandValidator: AbstractValidator<UpdatePurchaseProposalFormCommand>
    {
        public PurchaseProposalFormsCommandValidator()
        {
            RuleFor(x => x.Status)
                .IsInEnum()
                    .WithMessage("Trạng thái không hợp lệ");

            When(x => x.Status == PurchaseProposalFormStatus.Cancelled || x.Status == PurchaseProposalFormStatus.ForceDone, () =>
            {
                RuleFor(x => x.ExceptionReason)
                    .NotEmpty()
                        .WithMessage("Xin hãy nhập vào lý do");
            });

            When(x => x.Status == PurchaseProposalFormStatus.Processing ||
                x.Status == PurchaseProposalFormStatus.Done || 
                x.Status == PurchaseProposalFormStatus.New,
                () =>
                {
                    RuleFor(x => x.ExceptionReason)
                        .Must(x => x == null || x == "")
                            .WithMessage("Không được phép cập nhật lý do");
                });
        }
    }
}
