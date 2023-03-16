using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_AbstractFactoryPattern.Concrete_Factory
{
    internal interface IBill
    {
        double BillCalculation(int units);
    }
}
