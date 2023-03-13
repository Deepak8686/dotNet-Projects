using Fibonnaci_series.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_series.Main
{
    public class Switch
    {
        int n;
        string subdivision;
        public void selectmethod()
        {
            Iiteration iiteration = null;
            Irecursion irecursion = null;
            try
            {

                Console.WriteLine("enter the value");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("enter number greater than 0");
                   selectmethod();
                }
                else
                {
                    subdivision1();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("enter number only");
                selectmethod();
            }

            void subdivision1()
            {
                try
                {
                    Console.WriteLine("enter 1.for iteration 2. for recursion ");
                    subdivision = Console.ReadLine();
                    if (subdivision == "1" || subdivision == "2")
                    {
                        switch1();
                    }
                   else
                    {
                        Console.WriteLine("please select from above options");
                        subdivision1();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    subdivision1();
                }
            }

            
            void switch1()
            {
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
}

