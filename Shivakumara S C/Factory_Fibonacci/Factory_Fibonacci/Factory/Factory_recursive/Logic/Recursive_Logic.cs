using Factory_Fibonacci.Factory.Factory_recursive.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Fibonacci.Factory.Factory_recursive.Logic
{
    public class Recursive_Logic : Recursive_Interface
    {
        private readonly Double _Recursive;

        public Recursive_Logic(Double Recursive) 
        {
            _Recursive = Recursive;
        }

        public void Recursive()
        {
            try
            {
                Console.WriteLine("The Fibonacci Series is :\n");
                for (int i = 0; i <= _Recursive; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error in Recursive method ");
            }
        }
        private int Fibonacci(int n)
        {
            try
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("error in Recursive method ");
                return 0;
            }
        }
    }
}
