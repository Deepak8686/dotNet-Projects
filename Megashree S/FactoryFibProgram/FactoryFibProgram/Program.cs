
using FactoryFibProgram;
using FactoryFibProgram.Classes;
using FactoryFibProgram.Interface;
using System;

public class Program
{
    private static int userInput;

    static void Main(string[] args)
    {
       
        IterativeInterface calculator1 = new IterativeClass(userInput);
        calculator1.Iterative();

        RecursiveInterface calculator = new RecursiveClass(userInput);
        calculator.CalculateFibonacciSeries();
      
        CallClass cal = new CallClass();
        cal.userInputs();
        Console.ReadKey();

    }
}


