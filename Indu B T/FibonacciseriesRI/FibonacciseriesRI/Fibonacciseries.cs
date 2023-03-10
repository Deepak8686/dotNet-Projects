using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesRI
{
    public class Fibonacciseries: IRecursiveIterative
    {
        public void Fibo()
        {
            bool b;
            do
            {
                int n = 0;
                bool check;
                Console.WriteLine("FIBONACCI SERIES USING ABSTRACT FACTORY PATTERN");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Enter a number to generate the Fibonacci sequence up to:");
                do
                {
                    check = false;
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("Enter the number greater than zero");
                            check = true;
                        }
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Enter only number greater than zero");
                        check = true;
                    }
                } while (check);
                IFibonacci factory = new RecursiveFibonacci();
   
                Console.WriteLine("Recursive Fibonacci sequence:");
                for (int i = 0; i <= n; i++)

                {
                    Console.WriteLine(factory.Calculate(i));
                }
                IFibonacci iterative = new IterativeFibonacci();
                Console.WriteLine("Iterative Fibonacci sequence:");
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(iterative.Calculate(i));
                }
                Console.WriteLine("Press Y to execute again or Q to quit");
                string yes=Convert.ToString(Console.ReadLine());
                if (yes.ToLower() == "y")
                {
                    b = false;
                }
                else if (yes.ToLower() == "y")
                {
                    break;
                }
                else
                {
                    b= true;
                }
            } while (!b);
            Console.Read();
        }
    }
}
