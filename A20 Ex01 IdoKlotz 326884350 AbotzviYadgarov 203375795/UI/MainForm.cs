using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;
using System.Threading;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795
{
    public partial class MainForm : Form
    {
        User m_LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fetchFacebookInfo()
        {
            fetchUserInfo();
            fetchFriends();
            //fetchCover();
            fetchPosts();
            fetchEvents();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("724595498038034",
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
                "user_hometown");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void logout()
        {
            FacebookService.Logout(null);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
            new Thread(fetchFacebookInfo).Start();

            if (m_LoggedInUser != null)
            {
                buttonLogin.Text = "Logout";
                logout();
            }
        }

        private void fetchUserInfo()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            nameLabel.Invoke(new Action(() => nameLabel.Text = String.Format("Hi, {0}", m_LoggedInUser.Name)));
        }

        private void fetchCover()
        {
            if(m_LoggedInUser.Cover.SourceURL != null)
            {
                coverPicture.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            }    
        }

        private void fetchFriends()
        {
            postBox.Invoke(new Action(() => friendsListBox.Items.Clear()));
            friendsListBox.DisplayMember = "FirstName";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        //throws exception
        private void friendsToUnfriend()
        {
            toUnfriendListBox.Items.Clear();
            toUnfriendListBox.DisplayMember = "Name";

            foreach (User friend in m_LoggedInUser.Friends)
            {
                foreach (Page page in friend.LikedPages)
                {
                    if (page.Id.Equals("6248267085")) //Nickelback facebook page
                    {
                        toUnfriendListBox.Items.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }

            if (toUnfriendListBox.Items.Count == 0)
            {
                MessageBox.Show("No suggestions, your friends are great!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFriendsToUnfriend_Click(object sender, EventArgs e)
        {
            buttonFriendsToUnfriend.Text = "Friends who like Nickelback";
            friendsToUnfriendProgressBar.Increment(100);
            friendsToUnfriend();
        }

        private void buttonCityFriends_Click(object sender, EventArgs e)
        {
            friendsCitiesProgressBar.Increment(100);
            fetchCitiesFriends();
        }

        private void fetchCitiesFriends()
        {
            toSeeCitiesListBox.Items.Clear();
            toSeeCitiesListBox.DisplayMember = "Name";
         
            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No cities to show, you have no friends :(");
            }
            else
            {
                Dictionary<City, int> citiesDict = new Dictionary<City, int>();

                foreach (User friend in m_LoggedInUser.Friends)
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

                toSeeCitiesListBox.Items.Add("The cities of your friends and amount:");
                foreach (KeyValuePair<City, int> entry in citiesDict)
                {
                    toSeeCitiesListBox.Items.Add(String.Format("In {0} there are {1} friends", entry.Key.Name, entry.Value));
                }
            }
        }

        private void fetchPosts()
        {
            postBox.Invoke(new Action(() => postBox.Items.Clear()));
            postBox.DisplayMember = "Message";

            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                postBox.Invoke(new Action(() => postBox.Items.Add(post)));
            }

            if (postBox.Items.Count == 0)
            {
                postBox.Invoke(new Action(() => postBox.Items.Add("No friends, no posts, no problem!")));
            }
        }

        private void myPostBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void publishPostButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(myPostBox.Text);
                //Next line would publish our post to the server if facebook haven't changed their privacy policy 
                //postBox.Items.Add(myPostBox.Text);
            } catch (Exception exc)
            {
                MessageBox.Show("Please sign in first");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            eventsListBox.Items.Clear();
            foreach (Event usersEvent in m_LoggedInUser.Events)
            {
                if (usersEvent.StartTime.Equals(e.Start)){
                    eventsListBox.Items.Add(usersEvent.ToString());
                    usersEvent.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }

            if (eventsListBox.Items.Count == 0)
            {
                eventsListBox.Items.Add("There are no events for selected date");
            }
        }

        private void fetchEvents()
        {
            eventsListBox.Invoke(new Action(() => eventsListBox.Items.Clear()));

            foreach (Event usersEvent in m_LoggedInUser.Events)
            {
                eventsListBox.Invoke(new Action(() => eventsListBox.Items.Add(usersEvent.ToString())));
                usersEvent.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (eventsListBox.Items.Count == 0)
            {
                eventsListBox.Invoke(new Action(() => eventsListBox.Items.Add("There are no events near you")));
            }
        }
    }
}
