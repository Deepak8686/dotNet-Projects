using Factory_Fibonacci.Factory.factory_iteration.Interface;
using Factory_Fibonacci.Factory.factory_iteration.Logic;
using Factory_Fibonacci.Factory.Factory_recursive.Interface;
using Factory_Fibonacci.Factory.Factory_recursive.Logic;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Fibonacci.Factory.Main.CallMethods
{
    public class Call_methods : SwitchMethod
    {
        double value;
        string? oparetor;
        public void call_methods()
        {
            try
            {
                Console.WriteLine("Eneter the number to see the out put!");
                value = Convert.ToDouble(Console.ReadLine());
                if (value <= 0)
                {
                    Console.WriteLine("enter possitive number or greater then 0");
                    call_methods();
                }
                check();
            }
            catch (Exception)
            {
                Console.WriteLine("enter number");
                call_methods();
            }
            void check()
            {
                try
                {
                    Console.WriteLine("Eneter the 1 Option to see the recursive. 2 for iteration oparetion!");
                    oparetor = Console.ReadLine();
                    if (oparetor == "1" || oparetor == "2")
                    {
                        Switch(value, oparetor);
                    }
                    else
                    {
                        Console.WriteLine("you must enter 1 or 2 option");
                        check();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("you must enter 1 or 2 option");
                    call_methods();
                }
            }
        }
    }
}
