using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesRI
{
    // Implement the IterativeFibonacci class that implements the IFibonacci interface iteratively
    public class IterativeFibonacci : IFibonacci
    {
        public int Calculate(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int prevPrev = 0;
            int prev = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = prev + prevPrev;
                prevPrev = prev;
                prev = result;
            }
            return result;
        }
    }
}
