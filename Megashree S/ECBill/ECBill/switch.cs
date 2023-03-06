using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECBill
{
    public class Switchcase : Console1
    {
        int total = 0;
        public void switchA( int result)
        {
            consoleB();
            int location = Convert.ToInt32(Console.ReadLine());
            switch (location)
            {
                case 1:
                    total = result * 10;
                    break;
                case 2:
                    total = result * 0;
                    break;
                case 3:
                    consoleB();
                    int sublocation=Convert.ToInt32(Console.ReadLine());
                    switch (sublocation)
                    {
                        case 1:
                            total = result * 5;
                            break;
                        case 2:
                            total = result * 2;
                            break;
                        case 3:
                            total = result * 0;
                            break;
                        default:
                            Console.WriteLine("Invalid input for sub-location.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            consoleA(total);
        }
    }
}
