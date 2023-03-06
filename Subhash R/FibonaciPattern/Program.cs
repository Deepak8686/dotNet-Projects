using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TakeInput takeInput = new TakeInput();
            CalculationFibonaci cal_fib= new CalculationFibonaci(takeInput);
            cal_fib.Fab_call();
            Console.WriteLine("\n");
            cal_fib.Fab_call();
            Console.ReadKey();
        }
    }
}
