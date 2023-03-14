using RecItrFibonacci.RecItrClass;
using RecItrFibonacci.RecItrInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecItrFibonacci.RecItrInputs
{
     public class RecursiveIterativeInputs
    {
        public void Inputs()
        {
            while (true)
            {
                try
                {
                    RecursiveIterativeInterface sel1;
                    Console.WriteLine("\nEnter the type of series to be generate: \n 1.Recursive Fibonacci \n 2.Iterative Fibonacci");
                    double selection = int.Parse(Console.ReadLine());
                    if (selection != 1 && selection != 2)
                    {
                        Console.WriteLine("Invalid Option Selection.");
                        continue;
                    }
                    double getin = GetInput("Enter the Number of Terms for Fibonacci series:");
                    Console.WriteLine("Fibonacci Series: ");
                    if (selection == 1)
                    {
                        sel1= new RecursiveIterativeClass(getin);
                        sel1.RecursiveFibonacci();
                    }
                    else if (selection == 2)
                    {
                        sel1 = new RecursiveIterativeClass(getin);
                        sel1.IterativeFibonacci();
                    }
                        while (true)
                        {
                            Console.WriteLine("\n\n Generate Series again?.Press 'y' to Continue,Press 'n' to Exit");
                            char checkdata = Console.ReadKey().KeyChar;
                            if (checkdata == 'y')
                            {
                                Inputs();
                            }
                            else if (checkdata == 'n')
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Press 'y' to Generate Series again.Press 'n' to Exit.");
                            }
                        }
                    }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Option! Please Enter a Number.");
                }
            }
        }
        private double GetInput(string message)
        {
            double num;
            while (true)
            {
                Console.WriteLine(message);
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("Invalid Option! Please Enter a Positive Number.");
                    }
                    else
                    {
                        return num;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Option! Please Enter a Number.");
                }
            }
        }
    }
}
