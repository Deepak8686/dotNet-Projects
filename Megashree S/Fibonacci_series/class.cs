using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    public class Fibmethod 
    {
        private readonly InputFib _userInput; 
        public Fibmethod(InputFib userInput)
        {
            _userInput = userInput;
        }
        public void CalculateFibonacciSeries()
        {
            int n = int.Parse(_userInput.GetUserInput("Enter the number of terms you want in the Fibonacci series: ")); 
            Console.WriteLine("The Fibonacci series is: ");
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

