using Fibonacci.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Concrete_factories
{
    public class Fibonacci_Iterative:IFibonacci
    {
       

        private readonly double _n;

        public Fibonacci_Iterative(double n)
        {            
            _n = n;
        }
        public int Fibonacci(double n)
        {
            int n1 = 0, n2 = 1, n3 = 0;
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.Write(n1 + " ");
            }

            else
            {
                Console.Write(n1 + " " + n2 + " ");
                for (int i = 2; i < n; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(" " + n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
            return n3;
        }
        
    }
}

