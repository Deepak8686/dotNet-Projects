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

namespace Factory_Fibonacci.Factory.Main
{
    public class Call_methods
    {
         public void call_methods()
         {
            try
            {
                Recursive_Interface recursive1 = null;
                Iteration_Interface iteration1 = null;
                Console.WriteLine("Eneter the number to see the out put!");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Eneter the 1 Option to see the recursive. 2 for iteration oparetion!");
                int oparetor = Convert.ToInt32(Console.ReadLine()); ;
                //var result = oparetor != 1 ?
                //             oparetor == 2 ?
                //             recursive = new Recursive_Logic(value) :
                //             iteration = new Iteration_Logic(value);
                switch (oparetor)
                {
                    case 1:
                        recursive1 = new Recursive_Logic(value);
                        recursive1.Recursive();
                        break;
                    case 2:
                        iteration1 = new Iteration_Logic(value);
                        iteration1.Iteration();
                        break;
                    default:
                        Console.WriteLine("Please enter currect option");
                        call_methods();
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                call_methods();
            }
         } 
    }
}
