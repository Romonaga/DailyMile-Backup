namespace VengSoft.DMBackUp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label display_nameLabel;
            System.Windows.Forms.Label goalLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label photo_urlLabel;
            System.Windows.Forms.Label time_zoneLabel;
            System.Windows.Forms.Label urlLabel;
            this.btnGetPersonalData = new System.Windows.Forms.Button();
            this.btnLogon = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.urlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dailyMileMeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.time_zoneTextBox = new System.Windows.Forms.TextBox();
            this.photo_urlTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.goalTextBox = new System.Windows.Forms.TextBox();
            this.display_nameTextBox = new System.Windows.Forms.TextBox();
            this.grpDailyMile = new System.Windows.Forms.GroupBox();
            this.btnBackUpFriends = new System.Windows.Forms.Button();
            this.btnViewFriendsStream = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grboxViews = new System.Windows.Forms.GroupBox();
            this.btnViewFriendStream = new System.Windows.Forms.Button();
            this.btnViewEntries = new System.Windows.Forms.Button();
            this.btnViewFriends = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            display_nameLabel = new System.Windows.Forms.Label();
            goalLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            photo_urlLabel = new System.Windows.Forms.Label();
            time_zoneLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            this.grpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileMeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.grpDailyMile.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.grboxViews.SuspendLayout();
            this.SuspendLayout();
            // 
            // display_nameLabel
            // 
            display_nameLabel.AutoSize = true;
            display_nameLabel.Location = new System.Drawing.Point(26, 28);
            display_nameLabel.Name = "display_nameLabel";
            display_nameLabel.Size = new System.Drawing.Size(73, 13);
            display_nameLabel.TabIndex = 0;
            display_nameLabel.Text = "Display name:";
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Location = new System.Drawing.Point(6, 99);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new System.Drawing.Size(32, 13);
            goalLabel.TabIndex = 2;
            goalLabel.Text = "Goal:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(357, 28);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(199, 28);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username:";
            // 
            // photo_urlLabel
            // 
            photo_urlLabel.AutoSize = true;
            photo_urlLabel.Location = new System.Drawing.Point(41, 165);
            photo_urlLabel.Name = "photo_urlLabel";
            photo_urlLabel.Size = new System.Drawing.Size(52, 13);
            photo_urlLabel.TabIndex = 8;
            photo_urlLabel.Text = "Photo url:";
            // 
            // time_zoneLabel
            // 
            time_zoneLabel.AutoSize = true;
            time_zoneLabel.Location = new System.Drawing.Point(34, 139);
            time_zoneLabel.Name = "time_zoneLabel";
            time_zoneLabel.Size = new System.Drawing.Size(59, 13);
            time_zoneLabel.TabIndex = 10;
            time_zoneLabel.Text = "Time zone:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(30, 51);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(68, 13);
            urlLabel.TabIndex = 13;
            urlLabel.Text = "DailyMile Url:";
            // 
            // btnGetPersonalData
            // 
            this.btnGetPersonalData.Enabled = false;
            this.btnGetPersonalData.Location = new System.Drawing.Point(9, 48);
            this.btnGetPersonalData.Name = "btnGetPersonalData";
            this.btnGetPersonalData.Size = new System.Drawing.Size(75, 23);
            this.btnGetPersonalData.TabIndex = 1;
            this.btnGetPersonalData.Text = "Backup";
            this.btnGetPersonalData.UseVisualStyleBackColor = true;
            this.btnGetPersonalData.Click += new System.EventHandler(this.brtnGetData_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(9, 19);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(75, 23);
            this.btnLogon.TabIndex = 5;
            this.btnLogon.Text = "Logon";
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(urlLabel);
            this.grpUserInfo.Controls.Add(this.urlLinkLabel);
            this.grpUserInfo.Controls.Add(this.pbUserImage);
            this.grpUserInfo.Controls.Add(time_zoneLabel);
            this.grpUserInfo.Controls.Add(this.time_zoneTextBox);
            this.grpUserInfo.Controls.Add(photo_urlLabel);
            this.grpUserInfo.Controls.Add(this.photo_urlTextBox);
            this.grpUserInfo.Controls.Add(usernameLabel);
            this.grpUserInfo.Controls.Add(this.usernameTextBox);
            this.grpUserInfo.Controls.Add(locationLabel);
            this.grpUserInfo.Controls.Add(this.locationTextBox);
            this.grpUserInfo.Controls.Add(goalLabel);
            this.grpUserInfo.Controls.Add(this.goalTextBox);
            this.grpUserInfo.Controls.Add(display_nameLabel);
            this.grpUserInfo.Controls.Add(this.display_nameTextBox);
            this.grpUserInfo.Location = new System.Drawing.Point(12, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(616, 207);
            this.grpUserInfo.TabIndex = 6;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Info";
            // 
            // urlLinkLabel
            // 
            this.urlLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Url", true));
            this.urlLinkLabel.Location = new System.Drawing.Point(102, 51);
            this.urlLinkLabel.Name = "urlLinkLabel";
            this.urlLinkLabel.Size = new System.Drawing.Size(404, 23);
            this.urlLinkLabel.TabIndex = 14;
            this.urlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel_LinkClicked);
            // 
            // dailyMileMeBindingSource
            // 
            this.dailyMileMeBindingSource.DataSource = typeof(VengSoft.DailyMileAPIWrapper.DailyMileMe);
            // 
            // pbUserImage
            // 
            this.pbUserImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dailyMileMeBindingSource, "Photo_url", true));
            this.pbUserImage.Location = new System.Drawing.Point(533, 19);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(63, 49);
            this.pbUserImage.TabIndex = 12;
            this.pbUserImage.TabStop = false;
            // 
            // time_zoneTextBox
            // 
            this.time_zoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Time_zone", true));
            this.time_zoneTextBox.Location = new System.Drawing.Point(99, 136);
            this.time_zoneTextBox.Name = "time_zoneTextBox";
            this.time_zoneTextBox.ReadOnly = true;
            this.time_zoneTextBox.Size = new System.Drawing.Size(152, 20);
            this.time_zoneTextBox.TabIndex = 11;
            // 
            // photo_urlTextBox
            // 
            this.photo_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Photo_url", true));
            this.photo_urlTextBox.Location = new System.Drawing.Point(99, 162);
            this.photo_urlTextBox.Name = "photo_urlTextBox";
            this.photo_urlTextBox.ReadOnly = true;
            this.photo_urlTextBox.Size = new System.Drawing.Size(476, 20);
            this.photo_urlTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(257, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(408, 25);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 5;
            // 
            // goalTextBox
            // 
            this.goalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Goal", true));
            this.goalTextBox.Location = new System.Drawing.Point(55, 85);
            this.goalTextBox.Multiline = true;
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.ReadOnly = true;
            this.goalTextBox.Size = new System.Drawing.Size(520, 36);
            this.goalTextBox.TabIndex = 3;
            // 
            // display_nameTextBox
            // 
            this.display_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileMeBindingSource, "Display_name", true));
            this.display_nameTextBox.Location = new System.Drawing.Point(99, 25);
            this.display_nameTextBox.Name = "display_nameTextBox";
            this.display_nameTextBox.ReadOnly = true;
            this.display_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.display_nameTextBox.TabIndex = 1;
            // 
            // grpDailyMile
            // 
            this.grpDailyMile.Controls.Add(this.btnBackUpFriends);
            this.grpDailyMile.Controls.Add(this.btnViewFriendsStream);
            this.grpDailyMile.Controls.Add(this.btnLogon);
            this.grpDailyMile.Controls.Add(this.btnGetPersonalData);
            this.grpDailyMile.Location = new System.Drawing.Point(11, 225);
            this.grpDailyMile.Name = "grpDailyMile";
            this.grpDailyMile.Size = new System.Drawing.Size(167, 88);
            this.grpDailyMile.TabIndex = 7;
            this.grpDailyMile.TabStop = false;
            this.grpDailyMile.Text = "Daily Mile";
            // 
            // btnBackUpFriends
            // 
            this.btnBackUpFriends.Enabled = false;
            this.btnBackUpFriends.Location = new System.Drawing.Point(90, 48);
            this.btnBackUpFriends.Name = "btnBackUpFriends";
            this.btnBackUpFriends.Size = new System.Drawing.Size(75, 23);
            this.btnBackUpFriends.TabIndex = 7;
            this.btnBackUpFriends.Text = "BU Friends";
            this.btnBackUpFriends.UseVisualStyleBackColor = true;
            this.btnBackUpFriends.Click += new System.EventHandler(this.btnBackUpFriends_Click);
            // 
            // btnViewFriendsStream
            // 
            this.btnViewFriendsStream.Enabled = false;
            this.btnViewFriendsStream.Location = new System.Drawing.Point(90, 19);
            this.btnViewFriendsStream.Name = "btnViewFriendsStream";
            this.btnViewFriendsStream.Size = new System.Drawing.Size(75, 23);
            this.btnViewFriendsStream.TabIndex = 6;
            this.btnViewFriendsStream.Text = "Get FS ";
            this.btnViewFriendsStream.UseVisualStyleBackColor = true;
            this.btnViewFriendsStream.Click += new System.EventHandler(this.btnViewFriendsStream_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 335);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(626, 22);
            this.statusBar.TabIndex = 8;
            this.statusBar.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(101, 17);
            this.tsStatus.Text = "Daily Mile Backup";
            // 
            // grboxViews
            // 
            this.grboxViews.Controls.Add(this.btnViewFriendStream);
            this.grboxViews.Controls.Add(this.btnViewEntries);
            this.grboxViews.Controls.Add(this.btnViewFriends);
            this.grboxViews.Location = new System.Drawing.Point(214, 225);
            this.grboxViews.Name = "grboxViews";
            this.grboxViews.Size = new System.Drawing.Size(167, 88);
            this.grboxViews.TabIndex = 9;
            this.grboxViews.TabStop = false;
            this.grboxViews.Text = "Data Views";
            // 
            // btnViewFriendStream
            // 
            this.btnViewFriendStream.Location = new System.Drawing.Point(89, 20);
            this.btnViewFriendStream.Name = "btnViewFriendStream";
            this.btnViewFriendStream.Size = new System.Drawing.Size(75, 23);
            this.btnViewFriendStream.TabIndex = 2;
            this.btnViewFriendStream.Text = "View FS ";
            this.btnViewFriendStream.UseVisualStyleBackColor = true;
            this.btnViewFriendStream.Click += new System.EventHandler(this.btnViewFriendStream_Click);
            // 
            // btnViewEntries
            // 
            this.btnViewEntries.Location = new System.Drawing.Point(8, 49);
            this.btnViewEntries.Name = "btnViewEntries";
            this.btnViewEntries.Size = new System.Drawing.Size(75, 23);
            this.btnViewEntries.TabIndex = 1;
            this.btnViewEntries.Text = "View Entries";
            this.btnViewEntries.UseVisualStyleBackColor = true;
            this.btnViewEntries.Click += new System.EventHandler(this.btnViewEntries_Click);
            // 
            // btnViewFriends
            // 
            this.btnViewFriends.Location = new System.Drawing.Point(8, 20);
            this.btnViewFriends.Name = "btnViewFriends";
            this.btnViewFriends.Size = new System.Drawing.Size(75, 23);
            this.btnViewFriends.TabIndex = 0;
            this.btnViewFriends.Text = "View Friends";
            this.btnViewFriends.UseVisualStyleBackColor = true;
            this.btnViewFriends.Click += new System.EventHandler(this.btnViewFriends_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grboxViews);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.grpDailyMile);
            this.Controls.Add(this.grpUserInfo);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DMBackUp.Properties.Settings.Default, "frmMainLoc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DMBackUp.Properties.Settings.Default.frmMainLoc;
            this.MaximumSize = new System.Drawing.Size(642, 395);
            this.MinimumSize = new System.Drawing.Size(642, 395);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DMBackUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileMeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.grpDailyMile.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.grboxViews.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPersonalData;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.TextBox time_zoneTextBox;
        private System.Windows.Forms.BindingSource dailyMileMeBindingSource;
        private System.Windows.Forms.TextBox photo_urlTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.TextBox display_nameTextBox;
        private System.Windows.Forms.GroupBox grpDailyMile;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.GroupBox grboxViews;
        private System.Windows.Forms.Button btnViewFriends;
        private System.Windows.Forms.Button btnViewEntries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Button btnViewFriendsStream;
        private System.Windows.Forms.Button btnViewFriendStream;
        private System.Windows.Forms.Button btnBackUpFriends;
        private System.Windows.Forms.LinkLabel urlLinkLabel;
    }
}

