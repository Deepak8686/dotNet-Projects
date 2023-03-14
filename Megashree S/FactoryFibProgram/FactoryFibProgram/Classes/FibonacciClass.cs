using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryFibProgram.Interface;

namespace FactoryFibProgram.Classes
{
    public class FibonacciClass : FibonacciInterface
    {
        private readonly double _RecInput;
        public FibonacciClass(double RecInput)
        {
            _RecInput = RecInput;
        }
        public void CalculateFibonacciSeries()
        {
            int n = RoundToNearestInt(_RecInput);
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


        public void Iterative()
        {
            int n = RoundToNearestInt(_RecInput);
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + a;
            }
        }
        private int RoundToNearestInt(double value)
        {
            return (int)(value >= 0 ? value + 0.5 : value - 0.5);
        }
    }
    }






