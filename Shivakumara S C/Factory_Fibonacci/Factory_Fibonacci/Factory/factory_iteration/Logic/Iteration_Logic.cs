using Factory_Fibonacci.Factory.factory_iteration.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Fibonacci.Factory.factory_iteration.Logic
{
    public class Iteration_Logic : Iteration_Interface
    {
        private readonly int _Iteration;

        public Iteration_Logic(int Iteration) 
        {
            _Iteration = Iteration;
        }

        public void Iteration()
        {
            try
            {
                int n1 = 0, n2 = 1, n3, i;
                Console.WriteLine("The Fibonacci Series is :\n");
                Console.Write(n1 + " " + n2 + " ");
                for (i = 2; i < _Iteration; ++i)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("enter number");
            }
        }
    }
}


