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
using A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic.DesignBuilder;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795
{
    public partial class MainForm : Form
    {
        private event Action<int> ReportClickDelegate;
        private Manager m_Manager;
        private ClickStats m_ClickStats;
        private int m_NumOfClicks;
        private SorterUtils m_SorterUtils;

        public MainForm()
        {
            m_Manager = Manager.Create();
            m_ClickStats = new ClickStats(this);
            InitializeComponent();
            initSorterMenu();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void reportClicks()
        {
            m_NumOfClicks++;
            if (ReportClickDelegate != null)
            {
                ReportClickDelegate.Invoke(m_NumOfClicks);
            }
        }

        private void fetchFacebookInfo()
        {
            fetchUserInfo();
            fetchFriends();
            fetchPosts();
            //fetchEvents();
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

        private void fetchFriends()
        {
            friendsListBox.Invoke(new Action(() => userBindingSource.DataSource = m_Manager.User.Friends));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFriendsToUnfriend_Click(object sender, EventArgs e)
        {
            buttonFriendsToUnfriend.Text = "Friends who like Nickelback";
            friendsToUnfriendProgressBar.Increment(100);
            new FeatureUnfriendFacade { ListBox = toUnfriendListBox, Manager = m_Manager }.FriendsToUnfriend();
        }

        private void buttonCityFriends_Click(object sender, EventArgs e)
        {
            friendsCitiesProgressBar.Increment(100);
            new FeatureCitiesFacade { ListBox = toSeeCitiesListBox, Manager = m_Manager }.FetchCitiesFriends();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGreenDesign_Click(object sender, EventArgs e)
        {
            reportClicks();
            Director director = new Director();
            DesignBuilder green = new ConcreteDesignBuilderGreen();
            director.Construct(green);
            Form designForm = green.GetResult();
            designForm.ShowDialog();
        }

        private void buttonBrownDesign_Click_1(object sender, EventArgs e)
        {
            reportClicks();
            Director director = new Director();
            DesignBuilder brown = new ConcreteDesignBuilderBrown();
            director.Construct(brown);
            Form designForm = brown.GetResult();
            designForm.ShowDialog();
        }

        private void buttonDarkDesign_Click(object sender, EventArgs e)
        {
            reportClicks();
            Director director = new Director();
            DesignBuilder dark = new ConcreteDesignBuilderDark();
            director.Construct(dark);
            Form designForm = dark.GetResult();
            designForm.ShowDialog();
        }

        private void postBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(postBox.SelectedItem != null)
            {
                Event selectedPost = postBox.SelectedItem as Event;
                textBoxPostEditor.Text = selectedPost.Description;
            }
        }

        private void eventsListBox_Leave(object sender, EventArgs e)
        {
            (postBox.SelectedItem as Event).Description = textBoxPostEditor.Text;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorBox.Text = m_ClickStats.NumOfClicks.ToString();
        }

        private void initSorterMenu()
        {
            m_SorterUtils = new SorterUtils();
            comboBoxCitiesSorter.Items.Add(new SorterItem { Text = "Highest First", CommandDelegate = m_SorterUtils.HighestFirst });
            comboBoxCitiesSorter.Items.Add(new SorterItem { Text = "Lowest First", CommandDelegate = m_SorterUtils.LowestFirst });
            comboBoxCitiesSorter.Items.Add(new SorterItem { Text = "News Sort Option", CommandDelegate = () => m_SorterUtils.Sorter = new Sorter((num1, num2) => num1 > num2)});
        }

        private void comboBoxCitiesSorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            (comboBoxCitiesSorter.SelectedItem as SorterItem).Selected();
            new FeatureCitiesFacade { ListBox = toSeeCitiesListBox, Manager = m_Manager, SorterUtils = m_SorterUtils }.FetchCitiesFriends();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
