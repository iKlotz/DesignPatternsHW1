using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class Sorter
    {
        public Func<int, int, bool> ComparerMethod { get; set; }

        public Sorter(Func<int, int, bool> i_ComparerMethod)
        {
            ComparerMethod = i_ComparerMethod;
        }

        public Dictionary<City, int> Sort(KeyValuePair<City, int>[] i_CitiesArray)
        {
            Dictionary<City, int> cityDict = new Dictionary<City, int>();

            for (int g = i_CitiesArray.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_CitiesArray.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (ComparerMethod.Invoke(i_CitiesArray[j].Value, i_CitiesArray[j + g].Value))
                        {
                            doSwap(ref i_CitiesArray[j], ref i_CitiesArray[j + g]);
                        }
                    }
                }
            }

            foreach (KeyValuePair<City, int> entry in i_CitiesArray)
            {
                cityDict.Add(entry.Key, entry.Value);
            }

            return cityDict;
        }

        private void doSwap(ref KeyValuePair<City, int> io_Num1, ref KeyValuePair<City, int> io_Num2)
        {
            KeyValuePair<City, int> temp = io_Num1;
            io_Num1 = io_Num2;
            io_Num2 = temp;
        }
    }
}
