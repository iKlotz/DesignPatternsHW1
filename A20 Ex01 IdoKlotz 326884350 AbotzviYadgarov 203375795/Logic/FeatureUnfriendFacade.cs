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
    public class FeatureUnfriendFacade
    {
        public Manager Manager { private get; set; }

        public ListBox ListBox { private get; set; }

        public void FriendsToUnfriend()
        {
            ListBox.Items.Clear();
            ListBox.DisplayMember = "Name";
            List<User> friendsToUnfriend = Manager.GetFriendsToUnfriendByPage("6248267085"); //Nickelback facebook page

            foreach (User friend in friendsToUnfriend)
            {
                ListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (ListBox.Items.Count == 0)
            {
                MessageBox.Show("No suggestions, your friends are great!");
            }
        }
    }
}
