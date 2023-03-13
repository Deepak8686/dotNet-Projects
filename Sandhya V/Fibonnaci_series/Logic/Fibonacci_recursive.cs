using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_series.Logic
{
    public class Fibonacci_recursive1 : Irecursion
    {
        private readonly int _input1;

        public Fibonacci_recursive1(int input1)
        {
            _input1=input1;

        }
        public void Fibonacci_recursive()
        {
            Console.WriteLine("The fibonacci series is:");
            for (int i = 0; i < _input1; i++)
            {
                Console.Write(Frecursion(i) + " ");
            }
            
        }
        private int Frecursion(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else 
            {
                return Frecursion(n - 1) + Frecursion(n - 2);
            }
        }
        
    }
}
