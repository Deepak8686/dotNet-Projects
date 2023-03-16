using Factory_Fibonacci.Factory.factory_iteration.Interface;
using Factory_Fibonacci.Factory.factory_iteration.Logic;
using Factory_Fibonacci.Factory.Factory_recursive.Interface;
using Factory_Fibonacci.Factory.Factory_recursive.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Fibonacci.Factory.Main.CallMethods
{
    public class SwitchMethod 
    {

        Recursive_Interface recursive1;
        Iteration_Interface iteration1;
        public void Switch(double value, string oparetor)
        {
            try
            {
                switch (oparetor)
                {
                    case "1":
                        recursive1 = new Recursive_Logic(value);
                        recursive1.Recursive();
                        break;
                    case "2":
                        iteration1 = new Iteration_Logic(value);
                        iteration1.Iteration();
                        break;
                    default:
                        Console.WriteLine("Please enter currect option");
                        Switch(value, oparetor);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error in call_methods method ");
                Switch(value, oparetor);
            }
        }
    }
}
