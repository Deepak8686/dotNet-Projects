using RecItrFibonacci.RecursiveInterface;
using RecItrFibonacci.RecursiveIterativefib.IterativeFibonacci;
using RecItrFibonacci.RecursiveIterativefib.Recursive_Fibonacci;
using System;

namespace Fibonacci
{
    //interface IFibonacciSeries
    //{
    //    void Generate();
    //}

    class FibonacciSeriesFactory
    {
        public static IFibonacciSeries Create(string type, int n)
        {
            switch (type.ToLower())
            {
                case "recursive":
                    return new RecursiveFibonacciSeries(n);
                case "iterative":
                    return new IterativeFibonacciSeries(n);
                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum value of the Fibonacci numbers to generate: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0");
                Console.Write("Enter the maximum value of the Fibonacci numbers to generate: ");
            }

            Console.WriteLine("Select Fibonacci type:");
            Console.WriteLine("1. Recursive");
            Console.WriteLine("2. Iterative");
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 2)
            {
                Console.WriteLine("Please enter a valid selection (1 or 2)");
                Console.WriteLine("Select Fibonacci type:");
                Console.WriteLine("1. Recursive");
                Console.WriteLine("2. Iterative");
            }

            IFibonacciSeries series;
            switch (selection)
            {
                case 1:
                    series = FibonacciSeriesFactory.Create("recursive", n);
                    break;
                case 2:
                    series = FibonacciSeriesFactory.Create("iterative", n);
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    return;
            }

            series.Generate();

            Console.ReadKey(); // Keep console open until user hits enter
        }
    }
}
