using System;
using System.Data.SqlClient;
namespace ECBill

{
    class EBbill : Iebill
    {
        public int Bill(int units)
        {
         return units <= 100 ? units * 0 :
         units <= 1000 ? (units - 100) * 5 :
         units <= 10000 ? (900 * 5) + (units - 1000) * 10 :
         units <= 30000 ? (900 * 5) + (9000 * 10) + (units - 10000) * 20 :
         (900 * 5) + (9000 * 10) + (20000 * 20) + (units - 30000) * 35;
        }
        public void UserInputs()
        {
            while (true)
            {
                Console.WriteLine("--------Electricity Bill---------\n");

                int billID = GetIntFromUser("Enter bill id");
                int units = GetIntFromUser("Enter units");

                var result = Bill(units);
                Console.WriteLine("Bill without tax: " + result);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter your locality number\n1.commercial\n2.village\n3.Domestic");
                Console.WriteLine("-------------------------------------");

                int location = GetIntFromUser("Enter your locality number");
                int total = 0;

                switch (location)
                {
                    case 1:
                        total = result * 10;
                        break;
                    case 2:
                        total = result * 0;
                        break;
                    case 3:
                        int sublocation = GetIntFromUser("Select a sub-location:\n1.Domestic-city\n2.Domestic-town\n3.Domestic-Village");

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

                Console.WriteLine("Bill with tax: " + total);
                Console.WriteLine("Press 'S' to regenerate the bill or Press any key to go back");
                if (Console.ReadKey().Key != ConsoleKey.S)
                {
                    break;
                }
            }
        }

        public int GetIntFromUser(string message)
        {
            int number = 0;
            while (number == 0)
            {
                try
                {
                    Console.WriteLine(message);
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            return number;
        }


        public void con(int billID, int units, int total)
        {

            string connectionString = "Data Source=DESKTOP-OSL1KJH\\SQLEXPRESS;Initial Catalog=electric_bill;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(connectionString);
            Connection.Open();
            string query = $"INSERT INTO Ebill(billID,units,total) values({billID},{units},{total})";
            SqlCommand insertcmd = new SqlCommand(query, Connection);
            insertcmd.ExecuteNonQuery();
            Connection.Close();
        }


    }
}


