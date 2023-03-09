using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryFibProgram.Interface;

namespace FactoryFibProgram.Classes
{
    public class IterativeClass : IterativeInterface 
    {
        private readonly int _IterInput;

        public IterativeClass(int IterInput)
        {
            _IterInput = IterInput;
        }
        public void Iterative()
        {
            
            int n = _IterInput;
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        private int Fibonacci(int m)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < m; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
    }
}
