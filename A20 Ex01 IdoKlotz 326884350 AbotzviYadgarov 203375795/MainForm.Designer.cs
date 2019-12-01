namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.myPostBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.coverPicture = new System.Windows.Forms.PictureBox();
            this.postBox = new System.Windows.Forms.ListBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toUnfriendListBox = new System.Windows.Forms.ListBox();
            this.toSeeCitiesListBox = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonFriendsToUnfriend = new System.Windows.Forms.Button();
            this.buttonCityFriends = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(884, 38);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 42);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // myPostBox
            // 
            this.myPostBox.Location = new System.Drawing.Point(448, 38);
            this.myPostBox.Multiline = true;
            this.myPostBox.Name = "myPostBox";
            this.myPostBox.Size = new System.Drawing.Size(404, 42);
            this.myPostBox.TabIndex = 1;
            this.myPostBox.TextChanged += new System.EventHandler(this.myPostBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 632);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.coverPicture);
            this.tabPage1.Controls.Add(this.postBox);
            this.tabPage1.Controls.Add(this.friendsListBox);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.profilePicture);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.myPostBox);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome!";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // coverPicture
            // 
            this.coverPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverPicture.BackgroundImage")));
            this.coverPicture.Location = new System.Drawing.Point(174, 180);
            this.coverPicture.Name = "coverPicture";
            this.coverPicture.Size = new System.Drawing.Size(150, 118);
            this.coverPicture.TabIndex = 15;
            this.coverPicture.TabStop = false;
            this.coverPicture.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // postBox
            // 
            this.postBox.FormattingEnabled = true;
            this.postBox.ItemHeight = 20;
            this.postBox.Location = new System.Drawing.Point(448, 176);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(404, 404);
            this.postBox.TabIndex = 14;
            this.postBox.SelectedIndexChanged += new System.EventHandler(this.postBox_SelectedIndexChanged);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(884, 176);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(130, 404);
            this.friendsListBox.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(800, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 24);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "נא להיפטר ממסיחים";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(677, 137);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I don\'t care!";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.monthCalendar1.Location = new System.Drawing.Point(12, 323);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 157);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Hi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.No;
            this.profilePicture.Location = new System.Drawing.Point(20, 180);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(134, 118);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 5;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.ProfilePic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(304, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Post";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.toUnfriendListBox);
            this.tabPage2.Controls.Add(this.toSeeCitiesListBox);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.buttonFriendsToUnfriend);
            this.tabPage2.Controls.Add(this.buttonCityFriends);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Features";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toUnfriendListBox
            // 
            this.toUnfriendListBox.FormattingEnabled = true;
            this.toUnfriendListBox.ItemHeight = 20;
            this.toUnfriendListBox.Location = new System.Drawing.Point(528, 142);
            this.toUnfriendListBox.Name = "toUnfriendListBox";
            this.toUnfriendListBox.Size = new System.Drawing.Size(379, 344);
            this.toUnfriendListBox.TabIndex = 4;
            // 
            // toSeeCitiesListBox
            // 
            this.toSeeCitiesListBox.FormattingEnabled = true;
            this.toSeeCitiesListBox.ItemHeight = 20;
            this.toSeeCitiesListBox.Location = new System.Drawing.Point(142, 142);
            this.toSeeCitiesListBox.Name = "toSeeCitiesListBox";
            this.toSeeCitiesListBox.Size = new System.Drawing.Size(379, 344);
            this.toSeeCitiesListBox.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(528, 508);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 28);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // buttonFriendsToUnfriend
            // 
            this.buttonFriendsToUnfriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonFriendsToUnfriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonFriendsToUnfriend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFriendsToUnfriend.Location = new System.Drawing.Point(528, 95);
            this.buttonFriendsToUnfriend.Name = "buttonFriendsToUnfriend";
            this.buttonFriendsToUnfriend.Size = new System.Drawing.Size(380, 42);
            this.buttonFriendsToUnfriend.TabIndex = 1;
            this.buttonFriendsToUnfriend.Text = "Friends To Unfriend";
            this.buttonFriendsToUnfriend.UseVisualStyleBackColor = false;
            this.buttonFriendsToUnfriend.Click += new System.EventHandler(this.buttonFriendsToUnfriend_Click);
            // 
            // buttonCityFriends
            // 
            this.buttonCityFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonCityFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCityFriends.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCityFriends.Location = new System.Drawing.Point(142, 95);
            this.buttonCityFriends.Name = "buttonCityFriends";
            this.buttonCityFriends.Size = new System.Drawing.Size(380, 42);
            this.buttonCityFriends.TabIndex = 0;
            this.buttonCityFriends.Text = "Press to see friend\'s cities";
            this.buttonCityFriends.UseVisualStyleBackColor = false;
            this.buttonCityFriends.Click += new System.EventHandler(this.buttonCityFriends_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Guys most common phrase is?";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(144, 508);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(378, 28);
            this.progressBar2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(777, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1058, 629);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "facebook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox myPostBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox toUnfriendListBox;
        private System.Windows.Forms.ListBox toSeeCitiesListBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonFriendsToUnfriend;
        private System.Windows.Forms.Button buttonCityFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox postBox;
        private System.Windows.Forms.PictureBox coverPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button1;
    }
}

