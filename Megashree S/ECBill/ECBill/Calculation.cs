using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECBill
{
     public class Calculation : Switchcase
    {
        public void Bill(int units)
        {
            var charge= units <= 100 ? units * 0 :
            units <= 1000 ? (units - 100) * 5 :
            units <= 10000 ? (900 * 5) + (units - 1000) * 10 :
            units <= 30000 ? (900 * 5) + (9000 * 10) + (units - 10000) * 20 :
            (900 * 5) + (9000 * 10) + (20000 * 20) + (units - 30000) * 35;
            switchA(charge);
        }
    }
}
