using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class SorterItem
    {
        public Action CommandDelegate { get; set; }
        
        public string Text { get; set; }

        public void Selected()
        {
            if (CommandDelegate != null)
            {
                CommandDelegate.Invoke();
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
