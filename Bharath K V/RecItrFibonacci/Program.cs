using RecItrFibonacci.RecItrClass;
using RecItrFibonacci.RecItrInputs;
using RecItrFibonacci.RecItrInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecItrFibonacci
{
    public class Program
    {
        private static int Input;
        static void Main(string[] args)
        {       
            RecursiveIterativeInterface RecItrCal = new RecursiveIterativeClass(Input);
            RecItrCal.RecursiveFibonacci();
            RecItrCal.IterativeFibonacci();
            RecursiveIterativeInputs Calculate = new RecursiveIterativeInputs();
            Calculate.Inputs(); 
            Console.ReadKey();
        }
    }
}
