using Fibonacci.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Concrete_factories
{
    public class Fibonacci_Recursive:IFibonacci
    {
        private readonly double _n;
        public Fibonacci_Recursive(double n)
        {
            _n = n;
        }
        public int Fibonacci(double n)
        {
            
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {                
                return Fibonacci(n-1)+Fibonacci(n-2);
            }
        }
    }
}
