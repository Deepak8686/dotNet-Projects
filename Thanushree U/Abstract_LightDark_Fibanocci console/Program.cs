using Abstract_LightDark_Themes.Concrete_Theme_Factories;
using Abstract_LightDark_Themes.FactoryItems;
using Abstract_LightDark_Themes.Theme_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_LightDark_Themes.final;

namespace Abstract_LightDark_Themes
{
    internal class Program
    {
        static void Main()
        {
            final theme = new final();
            theme.Choice();

            Console.ReadKey();
        }
    }
}
