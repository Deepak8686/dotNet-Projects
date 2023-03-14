using Fibonacci;
using RecItrFibonacci.RecursiveInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecItrFibonacci.RecursiveIterativefib.Recursive_Fibonacci
{
    class RecursiveFibonacciSeries : IFibonacciSeries
    {
        private int n;

        public RecursiveFibonacciSeries(int n)
        {
            this.n = n;
        }

        public void Generate()
        {
            Console.WriteLine("Recursive Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.WriteLine();
        }

        private int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
