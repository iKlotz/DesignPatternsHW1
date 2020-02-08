using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class SorterUtils
    {
        public Sorter Sorter { get; set; }

        public void HighestFirst()
        {
            Sorter = new Sorter((num1, num2) => num1 > num2);
        }

        public void LowestFirst()
        {
            Sorter = new Sorter((num1, num2) => num1 < num2);
        }
    }
}
