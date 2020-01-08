using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic.DesignBuilder
{
    public abstract class DesignBuilder
    {
        public abstract void SetBackgroundColor();

        public abstract void SetButtonsColor();

        public abstract void SetListboxColor();

        public abstract Form GetResult();
    }
}
