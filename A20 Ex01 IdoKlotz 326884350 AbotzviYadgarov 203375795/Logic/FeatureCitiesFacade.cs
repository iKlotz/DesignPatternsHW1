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
    public class FeatureCitiesFacade
    {
        public Manager Manager { private get; set; }

        public ListBox ListBox { private get; set; }

        public void FetchCitiesFriends()
        {
            ListBox.Items.Clear();
            ListBox.DisplayMember = "Name";
            Dictionary<City, int> citiesDict = Manager.GetCitiesOfFriendsAndCount();
            ListBox.Items.Add("The cities of your friends and amount:");

            foreach (KeyValuePair<City, int> entry in citiesDict)
            {

                ListBox.Items.Add(new CityProxy { City = entry.Key, Count = entry.Value });
            }

            if (Manager.User.Friends.Count == 0)
            {
                MessageBox.Show("No cities to show, you have no friends :(");
            }
        }
    }
}
