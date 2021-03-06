﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class FilterFriendsByLikedPage : FriendsFilter
    {
        private string m_PageID;

        public FilterFriendsByLikedPage(User i_User, string i_PageID) : base(i_User)
        {
            m_PageID = i_PageID;
            ListFilter();
        }

        public override void Filter(User i_Friend)
        {
            Current = i_Friend;

            foreach (Page page in i_Friend.LikedPages)
            {
                if (page.Id.Equals(m_PageID))
                {
                    Filtered.Add(Current);
                }
            }
        }
    }
}
