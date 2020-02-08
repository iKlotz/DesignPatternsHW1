using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class ClickStats
    {
        public int NumOfClicks { get; private set; }

        public ClickStats(MainForm i_Form)
        {
            i_Form.ReportClickDelegate += buttonClicked;
        }

        private void buttonClicked(int i_NumOfClicks)
        {
            NumOfClicks = i_NumOfClicks;
        }
    }
}
