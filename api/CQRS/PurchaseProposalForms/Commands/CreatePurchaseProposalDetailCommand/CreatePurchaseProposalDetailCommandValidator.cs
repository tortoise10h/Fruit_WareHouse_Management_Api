﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms
{
    public class CreatePurchaseProposalDetailCommandValidator: AbstractValidator<CreatePurchaseProposalDetailCommand>
    {
        public CreatePurchaseProposalDetailCommandValidator()
        {
            RuleFor(x => x.Quantity)
                .NotNull()
                    .WithMessage("Số lượng cần mua của sản phẩm không được để trống")
                .GreaterThanOrEqualTo(0)
                    .WithMessage("Số lượng cần mua của sản phẩm không được nhỏ hơn 0");

            RuleFor(x => x.ProductId)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Id của sản phẩm không hợp lệ");
        }
    }
}
