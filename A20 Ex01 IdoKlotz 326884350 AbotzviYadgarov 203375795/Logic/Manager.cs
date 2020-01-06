using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic
{
    public class Manager
    {
        private const string k_AppId = "724595498038034";
        private readonly string[] r_Permissions = new string[]
        {
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
        };

        public User User { get; private set; }

        public static Manager Create()
        {
            return new Manager();
        }

        public void LoginAndInit()
        {
            LoginResult result = FacebookService.Login(k_AppId, r_Permissions);
              if (!string.IsNullOrEmpty(result.AccessToken))
            {
                User = result.LoggedInUser;
            }
            else
            {
                throw new Exception(result.ErrorMessage);
            }
        }

        public void Logout()
        {
            FacebookService.Logout(null);
        }

        public List<User> GetFriendsToUnfriendByPage(string i_PageId)
        {
            List<User> friendsToUnfriend = new List<User>();

            foreach (User friend in User.Friends)
            {
                foreach (Page page in friend.LikedPages)
                {
                    if (page.Id.Equals(i_PageId)) 
                    {
                        friendsToUnfriend.Add(friend);
                    }
                }
            }

            return friendsToUnfriend;
        }

        public Dictionary<City, int> GetCitiesOfFriendsAndCount()
        {
            Dictionary<City, int> citiesDict = new Dictionary<City, int>();

            foreach (User friend in User.Friends)
            {
                if (citiesDict.ContainsKey(friend.Location))
                {
                    citiesDict[friend.Location] += 1;
                }
                else
                {
                    citiesDict.Add(friend.Location, 1);
                }
            }

            return citiesDict;
        }

    }
}
