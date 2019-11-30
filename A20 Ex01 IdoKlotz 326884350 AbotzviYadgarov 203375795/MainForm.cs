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

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795
{
    public partial class MainForm : Form
    {
        User m_LoggedInUser;
     
       
        public MainForm()
        {
            InitializeComponent();
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

        private void fetchUserInfo()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            postBox.Text = m_LoggedInUser.Name;
            nameLabel.Text = String.Format("Hi, {0}", m_LoggedInUser.Name);  
        }

        private void fetchFriends()
        {
            friendsListBox.Items.Clear();
            friendsListBox.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
            fetchUserInfo();
            fetchFriends();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonCityFriends_Click(object sender, EventArgs e)
        {
            fetchCitiesFriends();
        }
        
        private void fetchCitiesFriends()
        {
            listBoxFeature2.Items.Clear();
            listBoxFeature2.DisplayMember = "Name";
            Dictionary<String, int> citiesDict = new Dictionary<String, int>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (citiesDict.ContainsKey(friend.Location.Location.City))
                {
                    citiesDict[friend.Location.Location.City] += 1;
                }
                else
                {
                    citiesDict.Add(friend.Location.Location.City, 0);
                }
            }

            listBoxFeature2.Items.Add("The cities of your friends and amount:");
            foreach (KeyValuePair<String, int> entry in citiesDict)
            {
                listBoxFeature2.Items.Add(String.Format("{0} there are {1} friends", entry.Key, entry.Value));
            }

               
            if (m_LoggedInUser.Friends.Count == 0)
            {
                listBoxFeature2.Items.Add("No Friends to retrieve :(");
            }
    }
}
