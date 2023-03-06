using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class Units_calculation
    {
        public double Calculation(int units)
        {
            double amount;

            if (units <= 100)
            {
                amount = 0;
            }
            else if (units >= 101 && units <= 1000)
            {
                amount = (units - 100) * 5.0;
            }
            else if (units >= 1001 && units <= 10000)
            {
                amount = (900 * 5) + ((units - 1000) * 10.0);
            }
            else if (units >= 10001 && units <= 30000)
            {
                amount = (900 * 5) + (9000 * 10) + (units - 20000) * 20.0;
            }
            else
            {
                amount = (900 * 5) + (9000 * 10) + (20000 * 20) + (units * 35.0);
            }
            return amount;
        }
    }
}
