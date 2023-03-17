using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci_series_Recursion_
{
    public class FibanocciRecursion :IFibonacciMethods
    {
        public int fib(double i)
        {
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 1;
            }
            else
            {
                return fib(i-2) + fib(i-1);
            }
        }
    }
}
