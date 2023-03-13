using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFibProgram.Classes
{
    public class CallClass
    {
        public void userInputs()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("\nEnter '1' to calculate the Fibonacci series using recursion OR Enter '2' to calculate Fibonacci series using iteration.");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice != 1 && choice != 2)
                    {
                        Console.WriteLine("Invalid choice!");
                        continue;
                    }

                    double n = GetValidInput("Enter the number of terms you want in the Fibonacci series:");

                    Console.WriteLine("The Fibonacci series is: ");

                    if (choice == 1)
                    {
                        FibonacciClass rc = new FibonacciClass(n);
                        rc.CalculateFibonacciSeries();
                    }
                    else if (choice == 2)
                    {
                        FibonacciClass ic = new FibonacciClass(n);
                        ic.Iterative();
                    }
                    //Console.WriteLine("\n\nPress Enter to calculate the Fibonacci series again or any other key to exit.");
                    //if (Console.ReadKey().Key != ConsoleKey.Enter)
                    //{
                    //    break;
                    //}

                    while (true)
                    { 
                    Console.WriteLine("\n\nPress 'y' to calculate the Fibonacci series again, 'n' to exit, or any other key to show an error message.");
                    char checkdata = Console.ReadKey().KeyChar;
                        if (checkdata == 'y')
                        {
                            userInputs();
                        }
                        else if (checkdata == 'n')
                        {
                           Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input. Please enter 'y' to generate the Fibonacci series again, 'n' to exit, or any other key to show an error message.");
                            
                        }
                      
                }

                }

                catch (FormatException)
                {
                Console.WriteLine("Invalid input! Please enter a number.");
                }
            } 
        }
                 private double GetValidInput(string message)
                 {
                 double n;
                 while (true)
                 {
                 Console.WriteLine(message);
                 try
                 {
                    n = double.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Invalid input! Please enter a positive integer.");
                    }
                    else
                    {
                        return n;
                    }
                 }
                 catch (FormatException)
                 {
                    Console.WriteLine("Invalid input! Please enter a number.");
                 }
             }
           }
        }
    }


