using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattran_Fibonacci
{
    public class Fabonacci_Cal
    {
        private readonly InputFibonacci _inputFibonacci;

        public Fabonacci_Cal(InputFibonacci inputFibonacci)
        {
            _inputFibonacci=inputFibonacci;
        }
        public void Fabonacci_Cal1()
        {
            int n = int.Parse(_inputFibonacci.Getinput("Enter the number to generate fabonacci:"));
            Console.WriteLine("The Fibonacci Series is :\n");
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
