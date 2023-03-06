using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECBill
{
    public class Console1
    {
        public void consoleA(int total)
        {
            Console.WriteLine("Bill with tax: " + total);
        }
        public void consoleB()
        {
            Console.WriteLine("Select location:\n1.Domestic-city\n2.Domestic-town\n3.Domestic-Village");
        }
    }
}
