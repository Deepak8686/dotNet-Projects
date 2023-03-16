using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesRI
{
    public class Fibonacciseries : IRecursiveIterative
    {
        public void Fibo()
        {
            bool repeat = true;
            do
            {
                try
                {
                    //int n = 0;
                    //Console.WriteLine("FIBONACCI SERIES USING ABSTRACT FACTORY PATTERN");
                    //Console.WriteLine("-----------------------------------------------");
                    //Console.WriteLine("Enter a number to generate the Fibonacci sequence up to:");
                    //while (true)
                    //{
                    //    string input = Console.ReadLine();
                    //    if (!int.TryParse(input, out n) || n <= 0)
                    //    {
                    //        Console.WriteLine("Invalid input. Please enter a positive integer:");
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}
                    int n = 0;
                    Console.WriteLine("FIBONACCI SERIES USING ABSTRACT FACTORY PATTERN");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Enter a number to generate the Fibonacci sequence up to:");
                    while (true)
                    {
                        string input = Console.ReadLine();
                        double doubleValue;
                        if (!double.TryParse(input, out doubleValue) || doubleValue <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive number:");
                        }
                        else
                        {
                            n = (int)Math.Round(doubleValue);
                            break;
                        }
                    }

                    IFibonacci recursiveFactory = new RecursiveFibonacci();
                    Console.WriteLine("Recursive Fibonacci sequence:");
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine(recursiveFactory.Calculate(i));
                    }

                    IFibonacci iterativeFactory = new IterativeFibonacci();
                    Console.WriteLine("Iterative Fibonacci sequence:");
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine(iterativeFactory.Calculate(i));
                    }

                    bool validInput = false;
                    do
                    {
                        Console.WriteLine("Press Y to execute again or Q to quit");
                        string input2 = Console.ReadLine().Trim().ToLower();

                        if (input2 == "y")
                        {
                            repeat = true;
                            validInput = true;
                        }
                        else if (input2 == "q")
                        {
                            repeat = false;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Only Y or Q are accepted.");
                        }
                    } while (!validInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (repeat);
        }
    }
}
