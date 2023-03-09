using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryFibProgram.Interface;

namespace FactoryFibProgram.Classes
{
    public class RecursiveClass : RecursiveInterface
    {
        private readonly int _RecInput;
        public RecursiveClass(int RecInput)
        {
            _RecInput = RecInput;
        }
        public void CalculateFibonacciSeries()
        {
            int n = _RecInput;
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        private int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}



