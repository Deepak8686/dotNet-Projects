using Fibonacci;
using RecItrFibonacci.RecursiveInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecItrFibonacci.RecursiveIterativefib.IterativeFibonacci
{
    class IterativeFibonacciSeries : IFibonacciSeries
    {
        private int n;

        public IterativeFibonacciSeries(int n)
        {
            this.n = n;
        }

        public void Generate()
        {
            Console.WriteLine("Iterative Fibonacci:");
            int num1 = 0;
            int num2 = 1;
            int current = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    current = i;
                }
                else
                {
                    current = num1 + num2;
                    num1 = num2;
                    num2 = current;
                }
                Console.Write("{0} ", current);
            }
            Console.WriteLine();
        }
    }
}
