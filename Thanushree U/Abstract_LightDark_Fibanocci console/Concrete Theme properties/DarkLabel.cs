using Abstract_LightDark_Themes.FactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LightDark_Themes.Concrete_Theme_properties
{
    public class DarkLabel : ILabel
    {
        public void getTheme()
        {
            Console.WriteLine("\n\nThis is a Label in Dark theme");
        }
    }
}
