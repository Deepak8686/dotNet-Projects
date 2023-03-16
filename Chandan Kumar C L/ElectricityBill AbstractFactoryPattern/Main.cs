using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_AbstractFactoryPattern
{
    public class Mains
    {
        public static void Main(string[] args)
        { 
            Program Bill = new Program();
            Bill.Bill();

        }
    }
}
