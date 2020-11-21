using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.Statistics
{
    public class ExportAndImportStatisticResponse
    {
        public dynamic Order { get; set; }
        public dynamic GoodsDeliveryNote { get; set; }
        public dynamic PurchaseProposalForm { get; set; }
        public dynamic GoodsReceivingNote { get; set; }
    }
}
