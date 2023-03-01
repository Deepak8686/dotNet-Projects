using System.Data.SqlClient;
using System.Xml.Linq;

namespace ConsoleApp4
{
    public class CondionsClass : SwichClass
    {
        public void Condions(int units)
        {
            int chg;
            try
            {
                if (units <= 100)
                {
                    chg = 0;
                }
                else if (units >= 101 && units <= 1000)
                {
                    chg = (units - 100) * 5;
                }
                else if (units >= 1001 && units <= 10000)
                {
                    chg = (900 * 5) + (units - 1000) * 10;
                }
                else if (units >= 10001 && units <= 30000)
                {
                    chg = (900 * 5) + (9000 * 10) + (units - 10000) * 20;
                }
                else
                {
                    chg = (900 * 5) + (9000 * 10) + (20000 * 20) + (units - 30000) * 35;
                }
                callswich(chg);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Condions(units);
            }
        }
    }
}
    