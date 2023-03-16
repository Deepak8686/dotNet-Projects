using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_AbstractFactoryPattern.Concrete_Factory
{
    internal class Calculation
    {
        public double BillCalculation(int units)
        {
            double amount;
            amount = (units <= 100) ? units * 0 :
                  (units > 100 && units <= 1000) ? (units - 100) * 5 :
                  (units > 1000 && units <= 10000) ? (900 * 5) + (units - 1000) * 10 :
                  (units > 10000 && units <= 30000) ? (900 * 5) + (9000 * 10) + (units - 10000) * 20 :
                                                                 (900 * 5) + (9000 * 10) + (units - 10000) * 20;
            return amount;
        }
    }
}
