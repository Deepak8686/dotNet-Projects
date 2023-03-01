using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    public  class InputClass : CondionsClass , EBill_Interface 
    {
      
        public void gettingdata()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Calculate Electricity Bill:\n");
            Console.WriteLine("----------------------------");

            try
            {
                Console.WriteLine("Input Customer ID :");
                 int id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter number only");
                gettingdata();

            }

            Console.WriteLine("Input the name of the customer :");
            string? name = Console.ReadLine();

            try
            {
                Console.WriteLine("Input the unit consumed by the customer : ");
                int units = Convert.ToInt32(Console.ReadLine());
                Condions(units);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter number only");
                gettingdata();
            }
        }
    }
}
