using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_series.Logic
{
    public  class Fibonacci_iterative1 : Iiteration
    {
        private readonly int _input2;

        public Fibonacci_iterative1(int input2)
        {
            _input2= input2;
        }

        public void Fibonacci_iterative()
        {
            int first = 0;
            int second = 1;
            Console.Write(first+" ");
            Console.Write(second +" ");
            for (int i = 2; i < _input2; i++)
            {
                int next = first + second;
                Console.Write(next+" ");
                first = second;
                second = next;
            }
            
        }
    }
}
