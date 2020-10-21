using api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Common.Enums
{
    public class PurchaseProposalDetail: BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PurchaseProposalFormId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
        public PurchaseProposalForm PurchaseProposalForm { get; set; }
    }
}
