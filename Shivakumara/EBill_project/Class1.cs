using System;

public class Class1
{
	public Class1()
	{
        void getdata()
        {
            try
            {
                while (true)
                {
                    int custid, conu;
                    double chg;
                    string connm;
                    Console.WriteLine("\n");
                    Console.WriteLine("Calculate Electricity Bill:\n");
                    Console.WriteLine("----------------------------");
                shiva:
                    try
                    {
                        Console.WriteLine("Input Customer ID :");
                        custid = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter number only");
                        goto shiva;

                    }
                    Console.WriteLine("Input the name of the customer :");
                    connm = Console.ReadLine();
                loop12:
                    try
                    {
                        Console.WriteLine("Input the unit consumed by the customer : ");
                        conu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter number only");
                        goto loop12;

                    }
                    if (conu <= 100)
                    {
                        chg = 0;
                        callswich();
                    }
                    else if (conu >= 101 && conu <= 1000)
                    {
                        chg = (conu - 100) * 5;
                        callswich();
                    }
                    else if (conu >= 1001 && conu <= 10000)
                    {
                        chg = (100 * 5) + (conu - 1001) * 10;
                        callswich();
                    }
                    else if (conu >= 10001 && conu <= 30000)
                    {
                        chg = (100 * 5) + (100 * 10) + (conu - 10001) * 20;
                        callswich();
                    }
                    else
                    {
                        chg = (100 * 5) + (100 * 10) + (100 * 20) + (conu - 30000) * 35;
                        callswich();
                    }
                    void callswich()
                    {
                        try
                        {
                            while (true)
                            {
                                char ch;
                                double val;
                                Console.WriteLine("Enter the site Domestic(1)/ Commercial(2)/ Village(3)");
                                ch = Convert.ToChar(Console.ReadLine());

                                switch (ch)
                                {
                                    case '1':
                                    here:
                                        try
                                        {
                                            while (true)
                                            {
                                                Console.WriteLine("Select your Domestic site City(1)/ Town(2)/ Village(3)");
                                                char cds = Convert.ToChar(Console.ReadLine());
                                                switch (cds)
                                                {
                                                    case '1':
                                                        val = chg * 5;
                                                        Console.WriteLine("Total bill is " + val);
                                                        getdata();
                                                        break;

                                                    case '2':
                                                        val = chg * 2;
                                                        Console.WriteLine("Total bill is " + val);
                                                        getdata();
                                                        break;

                                                    case '3':
                                                        val = chg * 0;
                                                        Console.WriteLine("Total bill is " + val);
                                                        getdata();
                                                        break;

                                                    default:
                                                        Console.WriteLine("please select valied option");
                                                        break;
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("while selecting option error accores ");
                                            goto here;
                                        }

                                    case '2':
                                        val = chg * 10;
                                        Console.WriteLine("Total bill is " + val);
                                        getdata();
                                        break;

                                    case '3':
                                        val = chg * 0;
                                        Console.WriteLine("Total bill is " + val);
                                        getdata();
                                        break;

                                    default:
                                        Console.WriteLine("please select valied option");
                                        break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("while selecting option error accores ");
                            callswich();
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("its a  program error ");
                getdata();
            }
        }
    }
}
