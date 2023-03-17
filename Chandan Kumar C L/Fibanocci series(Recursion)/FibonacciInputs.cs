using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci_series_Recursion_
{
    public  class FibonacciInputs: IFibonacci
    {
        public void Inputs()
        {
            double a=0;
            bool check=false;
            Console.WriteLine("----Fibonacci Series----");
            Console.WriteLine("\n\nEnter a number to get a fibonacci series");

            do
            {
                check = false;
                try
                {
                    a = Math.Floor(Convert.ToDouble(Console.ReadLine()));
                    if (a <= 0)
                    {
                        Console.WriteLine("Please enter a positive number");
                        check= true;
                    }
                }
                catch (FormatException)
                { 
                    Console.WriteLine("Please enter a valid number");
                    check= true;
                }
            } while (check);

            Console.WriteLine("\nUsing Recursion Method\n");
            for(int i=0; i<a; i++)
            {
                IFibonacciMethods rec = new FibanocciRecursion();
                Console.WriteLine(rec.fib(i)); 
            }

            Console.WriteLine("\nUsing Iterative Method\n");
            IFibonacciMethods iter = new FibonacciIterative();
            iter.fib(a);
        }

        public bool FromStart()
        {
            Console.WriteLine("\nDo you want to repeat(y/n)");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo.ToLower() == "y")
            {
                Inputs();
                FromStart();
                return true;
            }
            else if (yesOrNo.ToLower() == "n")
            {
                return false;
            }
            else 
            {
                Console.WriteLine("\nPlease enter either 'y' for 'yes' or 'n' for 'no'");
                FromStart();
                return true;
            }
        }
    }
}
