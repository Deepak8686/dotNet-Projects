using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill.Factory_Pattern
{
    public interface InterfaceEBill
    {
        int total_amount(int total);
    }
}
