using Fibonnaci_series.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_series.Main
{
    public class Switch
    {
        public void selectmethod()
        {
            Iiteration iiteration = null;
            Irecursion irecursion = null;
            Console.WriteLine("enter the value");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 1.for iteration 2. for recursion ");
            string subdivision = Console.ReadLine();
            
            switch (subdivision)
            {
                case "1":
                    iiteration = new Fibonacci_iterative1(n);
                    iiteration.Fibonacci_iterative();
                    break;
                case "2":
                    irecursion = new Fibonacci_recursive1(n);
                    irecursion.Fibonacci_recursive();
                    break;
                default:
                    Console.WriteLine("please select from above options");
                    break;
            }
        }
         
    }
}

