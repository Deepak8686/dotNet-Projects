using Abstract_LightDark_Themes.FactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LightDark_Themes.Concrete_Theme_properties
{
    public class LightLabel : ILabel
    {
        public void getTheme()
        {
            Console.WriteLine("\n\nThis is the Label in Light Theme");
        }
    }
}
