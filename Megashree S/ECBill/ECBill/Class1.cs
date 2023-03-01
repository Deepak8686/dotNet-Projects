using System;
using System.Data.SqlClient;
namespace ECBill

{
    class EBbill : Calculation, Iebill
    {

        public void UserInputs()
        {
            while (true)
            {
                Console.WriteLine("--------Electricity Bill---------\n");

                int billID = GetIntFromUser("Enter bill id");
                int units = GetIntFromUser("Enter units");
                Bill(units);
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
    }
}


