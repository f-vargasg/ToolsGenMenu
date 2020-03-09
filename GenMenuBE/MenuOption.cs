using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenMenuBE
{
    public class MenuOption
    {
        string idMenuOption;

        public string IdMenuOption
        {
            get { return idMenuOption; }
            set { idMenuOption = value; }
        }
        string label;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public MenuOption(string pIdMenuOption, string pLabel)
        {
            this.idMenuOption = pIdMenuOption;
            this.label = pLabel;
        }
    }
}
