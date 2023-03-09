using Abstract_LightDark_Themes.Concrete_Theme_properties;
using Abstract_LightDark_Themes.FactoryItems;
using Abstract_LightDark_Themes.Theme_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LightDark_Themes.Concrete_Theme_Factories
{
    public class LightThemeFactory: IThemeFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ILabel CreateLabel()
        {
            return new LightLabel();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}
