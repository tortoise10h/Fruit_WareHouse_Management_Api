using api.Common.Enums;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.PurchaseProposalForms
{
    public class PurchaseProposalDetailResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PurchaseProposalFormId { get; set; }
        public double Quantity { get; set; }
        public double QuantityPurchased { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }

        public ProductResponse Product { get; set; }
    }
}
