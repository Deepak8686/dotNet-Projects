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
        private readonly int _n;
        public Fibonacci_Iterative(int n)
        {
            _n = n;
        }
        public int Fibonacci(int n)
        {
            int n1 = 0, n2 = 1, n3 = 0;
            if (n <= 0)
            {
                Console.WriteLine("\nEnter number 1 or greater\n");
                Validations v= new Validations();
                v.Valid();
            }
            else if (n == 1)
            {
                Console.Write(n1 + " ");
            }
            else if (n == 2)
            {
                Console.Write(n1 + " " + n2 + " ");
            }
            else
            {
                Console.Write(n1 + " " + n2 + " ");
                for (int i = 2; i < n; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
            return n3;
        }
    }
}
