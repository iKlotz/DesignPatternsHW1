using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class CityProxy
    {
        public City City { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1} friends)", City.Name, Count);
        }
    }
}
