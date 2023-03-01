using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class Switch: ConsoleEbill
    {
        int result;
        public void valid(int charge)
        {
            console1();
            int location = Convert.ToInt32(Console.ReadLine());
            switch (location)
            {
                case 1:
                    result = charge * 10;
                    console2( result);
                    break;

                case 2:
                    result = charge;
                    console2( result);
                    break;

                case 3:
                    try
                    {
                        console1();
                        char Subdivision = Convert.ToChar(Console.ReadLine());
                        switch (Subdivision)
                        {
                            case '1':
                                result = charge * 5;
                                console2(result);
                                break;
                            case '2':
                                result = charge * 2;
                                console2( result);
                                break;

                            case '3':
                                result = charge;
                                console2( result);
                                break;
                        }
                    }catch(Exception ex)
                    {
                            Console.WriteLine(ex.ToString());
                            valid(charge);
                    }
                    break;
            }
        }
    }
}
