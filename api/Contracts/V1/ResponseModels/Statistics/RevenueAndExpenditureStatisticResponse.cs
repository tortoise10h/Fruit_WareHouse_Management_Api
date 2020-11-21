using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Contracts.V1.ResponseModels.Statistics
{
    public class RevenueAndExpenditureStatisticResponse
    {
        public double Revenue { get; set; }
        public double Expenditure { get; set; }
    }
}
