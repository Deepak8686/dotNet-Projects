using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaaci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            InputFib inputFib = new InputFib();
            Fibonacci_Cal cal = new Fibonacci_Cal(inputFib);

            cal.Fibonacci_Cal1();
            Console.ReadKey();  
        }


    }
}
