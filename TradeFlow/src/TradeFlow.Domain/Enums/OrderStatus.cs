using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFlow.Domain.Enums
{
    public enum OrderStatus
    {
        New,
        Pending,
        Executed,
        Rejected,
        Cancelled
    }
}
