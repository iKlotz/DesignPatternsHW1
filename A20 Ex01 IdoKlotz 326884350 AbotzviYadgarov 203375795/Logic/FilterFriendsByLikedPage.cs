using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    internal class FilterFriendsByLikedPage : FriendsFilter
    {
        string m_PageID;

        public FilterFriendsByLikedPage(User i_User, string i_PageID) : base(i_User)
        {
            m_PageID = i_PageID;
            ListFilter();
        }

        public override void Filter()
        {
            if (m_Item.Id.Equals(this.m_PageID))
            {
               m_Filtered.Add(m_Current);
            }
        }
    }
}
