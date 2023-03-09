using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesAFP
{
    public class FibonacciGenerator
    {
        private readonly IFibonacciFactory _factory;

        public FibonacciGenerator(IFibonacciFactory factory)
        {
            _factory = factory;
        }

        public void Generate(int n)
        {
            IFibonacci fibonacci = _factory.Create();

            for (int i = 0; i < n; i++)
            {
                Console.Write(fibonacci.Calculate(i) + " ");
            }
        }
    }
}
