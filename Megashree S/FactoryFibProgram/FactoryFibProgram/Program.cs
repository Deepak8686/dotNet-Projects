
using FactoryFibProgram;
using FactoryFibProgram.Classes;
using FactoryFibProgram.Interface;
using System;

public class Program
{
    private static int userInput;

    static void Main(string[] args)
    { 
        //IterativeInterface calculator1 = new IterativeClass(userInput);
        //calculator1.Iterative();

        FibonacciInterface calculator = new FibonacciClass(userInput);
        calculator.CalculateFibonacciSeries();
        calculator.Iterative();

        CallClass cal = new CallClass();
        cal.userInputs();

        Console.ReadKey();

    }
}


