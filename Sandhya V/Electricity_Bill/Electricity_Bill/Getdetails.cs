using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class Getdetails : Calculation
    {
        string again;
        public void data()
        {
            
            do
            {
                Boolean error = false;
                do
                {
                    error = false;
                    try
                    {
                        Console.WriteLine("Enter EB id ");
                        int id = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error = true;
                    }
                }
                while (error);

                Boolean error1 = false;
                do
                {
                    error1 = false;
                    try
                    {
                        Console.WriteLine("Enter Customer name ");
                        string name = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error1 = true;
                    }
                    error1 = false;
                    try
                    {
                        Console.WriteLine("enter units ");
                        int units = Convert.ToInt32(Console.ReadLine());
                        calc(units);


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error1 = true;
                    }
                }
                while (error1);
            } while (again == "1");
        }
    }
}
