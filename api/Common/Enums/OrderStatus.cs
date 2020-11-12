using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Common.Enums
{
    public enum OrderStatus
    {
        New = 1,
        Processing = 2,
        Done = 4,
        Exported = 3,
        Cancelled = 5,
    }
}
