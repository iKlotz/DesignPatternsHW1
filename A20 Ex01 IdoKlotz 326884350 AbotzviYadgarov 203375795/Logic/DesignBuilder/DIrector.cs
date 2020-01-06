using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic.DesignBuilder
{
    class Director
    {
        public void Construct(DesignBuilder i_Builder)
        {
            i_Builder.SetBackgroundColor();
            i_Builder.SetButtonsColor();
            i_Builder.SetListboxColor();       
        }
    }
}
