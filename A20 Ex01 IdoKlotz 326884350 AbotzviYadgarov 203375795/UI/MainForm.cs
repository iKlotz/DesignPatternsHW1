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
using A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795
{
    public partial class MainForm : Form
    {
        public Manager m_Manager ;

        public MainForm()
        {
            m_Manager = Manager.Create();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_Manager.LoginAndInit();
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            new Thread(fetchFacebookInfo).Start();

            if (m_Manager.User != null)
            {
                buttonLogin.Text = "Logout";
                m_Manager.Logout();
            }
        }

        private void fetchUserInfo()
        {
            profilePicture.LoadAsync(m_Manager.User.PictureNormalURL);
            nameLabel.Invoke(new Action(() => nameLabel.Text = String.Format("Hi, {0}", m_Manager.User.Name)));
        }

        private void fetchCover()
        {
            if(m_Manager.User.Cover.SourceURL != null)
            {
                coverPicture.LoadAsync(m_Manager.User.Cover.SourceURL);
            }    
        }

        private void fetchFriends()
        {
            postBox.Invoke(new Action(() => friendsListBox.Items.Clear()));
            friendsListBox.Invoke(new Action(() => friendsListBox.DisplayMember = "FirstName"));

            foreach (User friend in m_Manager.User.Friends)
            {
                friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_Manager.User.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        //throws exception
        private void friendsToUnfriend()
        {
            toUnfriendListBox.Items.Clear();
            toUnfriendListBox.DisplayMember = "Name";
            List<User> friendsToUnfriend = m_Manager.GetFriendsToUnfriendByPage("6248267085"); //Nickelback facebook page

            foreach (User friend in friendsToUnfriend)
            {
                toUnfriendListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
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
            Dictionary<City, int> citiesDict = m_Manager.GetCitiesOfFriendsAndCount();
            toSeeCitiesListBox.Items.Add("The cities of your friends and amount:    ");

            foreach (KeyValuePair<City, int> entry in citiesDict)
            {
                toSeeCitiesListBox.Items.Add(new CityProxy { City = entry.Key, Count = entry.Value });
            }


            if (m_Manager.User.Friends.Count == 0)
            {
                MessageBox.Show("No cities to show, you have no friends :(");
            }
        }

        private void fetchPosts()
        {
            postBox.Invoke(new Action(() => postBox.Items.Clear()));
            postBox.Invoke(new Action(() => postBox.DisplayMember = "Message"));

            foreach (Post post in m_Manager.User.NewsFeed)
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
                m_Manager.User.PostStatus(myPostBox.Text);
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
            foreach (Event usersEvent in m_Manager.User.Events)
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
            eventsListBox.Invoke(new Action(() => eventsListBox.DisplayMember = "Name"));

            foreach (Event usersEvent in m_Manager.User.Events)
            {
                eventsListBox.Invoke(new Action(() => eventsListBox.Items.Add(usersEvent.ToString())));
                usersEvent.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (eventsListBox.Items.Count == 0)
            {
                eventsListBox.Invoke(new Action(() => eventsListBox.Items.Add("There are no events near you")));
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void postBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
