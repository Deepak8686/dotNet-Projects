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

                int n = GetValidInput("Enter the number of terms you want in the Fibonacci series:");
                   
                       Console.WriteLine("The Fibonacci series is: ");

                        if (choice == 1)
                        {
                            RecursiveClass rc = new RecursiveClass(n);
                            rc.CalculateFibonacciSeries();
                        }
                        else if (choice == 2)
                        {
                            IterativeClass ic = new IterativeClass(n);
                            ic.Iterative();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice!");
                        }

                        Console.WriteLine("\n\nPress Enter to calculate the Fibonacci series again or any other key to exit.");
                        if (Console.ReadKey().Key != ConsoleKey.Enter)
                        {
                            break;
                        }
                      }
                
                        catch (FormatException)
                        {
                        Console.WriteLine("Invalid input! Please enter a number.");
                        }
                } 
            }
                 private int GetValidInput(string message)
                 {
                 int n;
                 while (true)
                 {
                 Console.WriteLine(message);
                 try
                 {
                    n = int.Parse(Console.ReadLine());
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


