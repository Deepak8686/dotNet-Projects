using ElectricityBill_AbstractFactoryPattern.Concrete_Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_AbstractFactoryPattern
{
    public class Program
    {
        public void Bill()
        {
            IBill total = null;

            Program prog = new Program();

            Console.WriteLine("- - - - - Electricity Bill- - - - -");
            Console.WriteLine("\nEnter customer name");
            string name = Console.ReadLine();

            int id = 0;
            int units = 0;

            int choice = 0;
            string site = "";
            int ch = 0;
            bool check = false;
            double amt_paying = 0;
            DateTime DT = DateTime.Now;
            String datetime = DT.ToString("yyyy  MMM dd h:mm:ss tt");

            do
            {
                check = false;
                try
                {
                    Console.WriteLine("\nEnter customer Id");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nId should not contain a character\nPlease Enter a Valid Id");
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("An invaid Id");
                    check = true;
                }
            } while (check);

            do
            {
                check = false;
                try
                {
                    Console.WriteLine("\nEnter the number of units");
                    units = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nUnits should not contain a character\nPlease Enter units in number");
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("An invaid units");
                    check = true;
                }
            } while (check);



            do
            {
                choice = 0;

                do
                {
                    check = false;
                    try
                    {
                        Console.WriteLine("\nChoose the site: \n1. Commercial \n2. Village \n3. Domestic\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nPlease choose a valid site from above");
                        check = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (check);

                switch (choice)
                {
                    case 1:
                        site = "Commercial";
                        total = new CommercialBill(units);
                        break;
                    case 2:
                        site = "Village";
                        total = new VillageBill(units);
                        break;
                    case 3:
                        do
                        {
                            ch = 0;
                            do
                            {
                                check = false;
                                try
                                {
                                    Console.WriteLine("\nChoose the commercial sub-division \n1.Domestic-city \n2.Domestic-town \n3.Domestic-village\n");
                                    ch = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nPlease choose a valid site from above");
                                    check = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            } while (check);

                            switch (ch)
                            {
                                case 1:
                                    site = "domestic-city";
                                    total = new DomesticCityBill(units);
                                    break;
                                case 2:
                                    site = "domestic-town";
                                    total = new DomesticTownBill(units);
                                    break;
                                case 3:
                                    site = "domestic-village";
                                    total = new DomesticVillageBill(units);
                                    break;
                                default:
                                    Console.WriteLine("Entered incorrect value!..");
                                    break;
                            }
                        } while (ch <= 0 || ch > 3);
                        break;
                    default:
                        Console.WriteLine("Entered incorrect value!..");
                        break;
                }
            } while (choice <= 0 || choice > 3);

            double total_amt = total.BillCalculation(units);
            Console.WriteLine("\n- - Bill Generated - -");
            Console.WriteLine("\nName:            {0} \nId:              {1} \nUnits:           {2}", name, id, units);
            Console.WriteLine("Total Bill is:   {0}", total_amt);
            Console.WriteLine("\nPlease Enter how much amount do you want to pay?");
            amt_paying = Convert.ToDouble(Console.ReadLine());
            double bal = total_amt - amt_paying;
            Console.WriteLine("\nYour bill balance is {0}", bal);
            Console.Read();
            

            prog.Sql(id, name, units, total_amt, site, amt_paying, bal, datetime);
        }

             public void Sql(int id,string name,int units,double total_amt,string site,double amt_paying,double bal,string datetime)
            {
                try
                {
                    SqlConnection sqlConnection;
                    string connectionString = "Data Source=DESKTOP-VHNARDT;Initial Catalog=system;Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    String query = "INSERT INTO ElecBill (ID,NAME,UNITS,[AMOUNT TO BE PAID],SITE,[AMOUNT PAID],BALANCE,DATE) VALUES ('" + id + "','" + name + "','" + units + "','" + total_amt + "','" + site + "','" + amt_paying + "','" + bal + "','" + datetime + "')";
                    SqlCommand insertCommand = new SqlCommand(query, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
             
            }
            
        }
    }

    

