using api.Common.Enums;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using api.Entities;
using api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.IServices
{
    public interface IPurchaseProposalServices
    {
        Task<List<CreatePurchaseProposalDetailCommand>> ValidateAdddedProducts(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails);

        Task ValidateUniqueProductsInPurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId);

        Task<List<UpdatePurchaseProposalDetailCommand>> MakeSureListPurchaseProposalDetailUpdateValid(List<UpdatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId);

        Task ValidateWhenUpdateStatus(PurchaseProposalForm purchaseProposalForm, PurchaseProposalFormStatus newStatus);

        Task HandleBusinessWhenStatusIsChanged(
            DataContext ctx,
            PurchaseProposalForm purchaseProposalForm,
            PurchaseProposalFormStatus newStatus);
    }
}
