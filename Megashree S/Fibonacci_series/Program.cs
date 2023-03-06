using Fibonacci_series;
using System;

public class Program
{
        static void Main(string[] args)
        {
        InputFib userInput = new InputFib();
        Fibmethod calculator = new Fibmethod(userInput); 
        calculator.CalculateFibonacciSeries();
        Console.ReadKey();
        }
    }


