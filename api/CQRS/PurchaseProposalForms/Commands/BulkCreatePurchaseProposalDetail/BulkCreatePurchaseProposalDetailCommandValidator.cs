using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CQRS.PurchaseProposalForms.Commands.BulkCreatePurchaseProposalDetails
{
    public class BulkCreatePurchaseProposalDetailCommandValidator: AbstractValidator<BulkCreatePurchaseProposalDetailCommand>
    {
        public BulkCreatePurchaseProposalDetailCommandValidator()
        {

        }
    }
}
