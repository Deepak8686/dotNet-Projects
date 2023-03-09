using Abstract_LightDark_Themes.FactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LightDark_Themes.Theme_Factory

{
    public interface IThemeFactory
    {
        IButton CreateButton();
        ILabel CreateLabel();
        ITextBox CreateTextBox();

    }
}
