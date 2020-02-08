using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    abstract class FriendsFilter
    {
        public User m_User { get; }

        public List<User> m_Filtered { get; set; }

        protected Page m_Item { get; set; }

        protected User m_Current { get; set; }



        public FriendsFilter(User i_User)
        {
            m_User = i_User;
        }

        public void ListFilter()
        {
            foreach (User friend in m_User.Friends)
            {
                this.m_Current = friend;

                foreach (Page page in friend.LikedPages)
                {
                    this.m_Item = page;
                    Filter();
                }
            }
        }
      
        public abstract void Filter();
    }
}
