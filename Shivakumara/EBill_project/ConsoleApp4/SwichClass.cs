using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class SwichClass : consoleClass
    {
        public void callswich(int chg)
        {
            int Total_amount;
            try
            {
                char ch;
                console3();
                ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        try
                        {
                            console3();
                            char cds = Convert.ToChar(Console.ReadLine());
                            switch (cds)
                            {
                                case '1':
                                    Total_amount = chg * 5;
                                    console1(Total_amount);
                                    break;

                                case '2':
                                    Total_amount = chg * 2;
                                    console1(Total_amount);
                                    break;

                                case '3':
                                    Total_amount = chg * 0;
                                    console1(Total_amount);
                                    break;

                                default:
                                    Console.WriteLine("please select valied option");
                                    break;
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("while selecting option error accores ");
                            callswich(chg);
                        }
                        break;
                    case '2':
                        Total_amount = chg * 10;
                        console1(Total_amount);
                        break;

                    case '3':
                        Total_amount = chg * 0;
                        console1(Total_amount);
                        break;

                    default:
                        Console.WriteLine("please select valied option");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("while selecting option error accores ");
                callswich(chg);
            }
        }
    }
}
