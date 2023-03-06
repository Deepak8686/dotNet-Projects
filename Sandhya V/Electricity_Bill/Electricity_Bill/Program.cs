using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill {
    class EB
    {
        static void Main(string[] args)
        {
            ConsoleEbill obj = new ConsoleEbill();
            obj.getdata();
        }

    }
}
