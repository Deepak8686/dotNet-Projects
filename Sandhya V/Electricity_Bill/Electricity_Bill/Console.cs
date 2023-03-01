using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class ConsoleEbill 
    {
        public void console1()
        {
            Console.WriteLine("enter the division \n 1.Domestic-city\n2.Domestic-town\n3.Domestic-Village");
        }
        public void console2(int result) 
        {
            Console.WriteLine("with tax  " + result);
            Console.ReadKey();  
        }
    } 
}
