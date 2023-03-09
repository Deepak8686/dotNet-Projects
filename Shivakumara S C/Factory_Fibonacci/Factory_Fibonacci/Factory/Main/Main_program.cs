using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Fibonacci.Factory.Main
{
    public class Main_program
    {
        public static void Main(string[] args)
        {
            try
            {
                Call_methods call_Methods = new Call_methods();
                call_Methods.call_methods();
            }catch(Exception)
            {
                Console.WriteLine("Methods is not available");
            }

        }
    }
}
