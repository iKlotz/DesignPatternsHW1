using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class FilterFriendsByCity : FriendsFilter
    {
        private string m_CityName;

        public FilterFriendsByCity(User i_User, string i_CityName) : base(i_User)
        {
            m_CityName = i_CityName;
            ListFilter();
        }

        public override void Filter(User i_Friend)
        {
            if (i_Friend.Location.Name.Equals(m_CityName))
            {
                Filtered.Add(Current);
            }
        }
    }
}
