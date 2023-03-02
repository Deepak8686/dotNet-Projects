using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Billing
    {
        public void Bill_recipt()
        {
            IRateCalculator rates = null;

            Console.WriteLine("Enter Customer Name: ");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter Billing ID: ");
            int Bid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the type of site connection:");
            Console.WriteLine("C for Commercial");
            Console.WriteLine("V for Village");
            Console.WriteLine("D for Domestic");

            string siteType = Console.ReadLine();

            switch (siteType.ToUpper())
            {
                case "C":
                    rates = new CommercialRate(units);
                    break;
                case "V":
                    rates = new VillageRate(units);
                    break;
                case "D":
                    Console.WriteLine("Select the type of area connection:");
                    Console.WriteLine("C for Domestic City ");
                    Console.WriteLine("V for Domestic Village ");
                    Console.WriteLine("T for Domestic Town ");
                    string areaType = Console.ReadLine();
                    switch (areaType.ToUpper())
                    {
                        case "C":
                            rates = new DomesticCityRate(units);
                            break;
                        case "V":
                            rates = new DomesticVillageRate(units);
                            break;
                        case "T":
                            rates = new DomesticTownRate(units);
                            break;
                        default:
                            Console.WriteLine("Invalid area type");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid site type");
                    return;
            }
            double total = rates.Calculate(units);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      Electricity Bill         ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Customer name: {cname}");
            Console.WriteLine($"Bill ID name: {Bid}");
            Console.WriteLine($"Units Consumed: {units}");
            Console.WriteLine($"Connection Type: {siteType}");
            Console.WriteLine($"Total Amount: {total}");
            Console.WriteLine("-------------------------------");
            Console.ReadLine();
        }
    }
}
