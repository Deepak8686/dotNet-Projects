using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaaci_Series
{
    public class Fibonacci_Cal
    {
        private readonly InputFib _inputFib;

        public Fibonacci_Cal(InputFib inputFib)
        {
            _inputFib=inputFib; 
        }
        public void Fibonacci_Cal1()
        {
            int n = int.Parse(_inputFib.Getdata("enter the value:"));
                Console.WriteLine("The fibonacci series is:");
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
