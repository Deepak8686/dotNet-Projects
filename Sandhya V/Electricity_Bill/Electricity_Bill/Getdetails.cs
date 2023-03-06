using Electricity_Bill.Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class ConsoleEbill 
    {
        public void getdata()
        {
            InterfaceEBill result = null;
           
            Console.WriteLine("Enter EB id ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer name ");
            string name = Console.ReadLine();

            Console.WriteLine("enter units ");
            int units = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the division \n 1.commericial\n2.village\n3.Domestic");
            string location = Convert.ToString(Console.ReadLine());
            switch(location)
            {
                case "1":
                     result = new City(units);
                    break;
                    case"2":
                    result = new Village(units);
                    break;
                    case"3":
                    Console.WriteLine("enter the subdivision \n 1.Domestic-city\n2.Domestic-town\n3.Domestic-Village");
                    string subdivision = Convert.ToString(Console.ReadLine());
                    switch (subdivision)
                    {
                        case "1":
                            result = new City(units);
                            break;
                        case "2":
                            result = new Village(units);
                            break; 
                        case "3":
                            result=new Domestictown(units);
                            break;
                        default:
                            Console.WriteLine("please enter valid subdivision");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("please enter valid location");
                    break;
            }
            var resultq = result.total_amount(units);
            Console.WriteLine("with tax  " + resultq);
            getdata();
        }  
    } 
}
