using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public abstract class FriendsFilter
    {
        public User User { get; }

        public List<User> Filtered { get; set; }

        protected User Current { get; set; }

        public FriendsFilter(User i_User)
        {
            User = i_User;
        }

        public void ListFilter()
        {
            foreach (User friend in User.Friends)
            {
                Filter(friend);
            }
        }
      
        public abstract void Filter(User i_Friend);
    }
}
