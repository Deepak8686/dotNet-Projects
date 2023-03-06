using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciseriesAFP
{
    public class Fibonacciseries
    {
        public void Fibo()
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FIBONACCI SERIES USING ABSTRACT FACTORY PATTERN");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Enter the number of terms you want to generate in the Fibonacci series (or enter 'quit' to exit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (int.TryParse(input, out int n))
                {
                    var generator = new FibonacciGenerator(new RecursiveFibonacciFactory());
                    generator.Generate(n);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'quit'.");
                }
            }
        }
    }
}
