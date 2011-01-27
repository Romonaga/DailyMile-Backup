namespace VengSoft.DMBackUp
{
    partial class frmViewFriends
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
            System.Windows.Forms.Label display_NameLabel1;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label photo_urlLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label usernameLabel;
            this.display_nameComboBox = new System.Windows.Forms.ComboBox();
            this.dailyMileFriendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.display_NameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.photo_urlTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.btnViewEntries = new System.Windows.Forms.Button();
            this.dmpBox = new System.Windows.Forms.PictureBox();
            this.dailyMileMeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urlLinkLabel = new System.Windows.Forms.LinkLabel();
            display_nameLabel = new System.Windows.Forms.Label();
            display_NameLabel1 = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            photo_urlLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileFriendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileMeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // display_nameLabel
            // 
            display_nameLabel.AutoSize = true;
            display_nameLabel.Location = new System.Drawing.Point(135, 7);
            display_nameLabel.Name = "display_nameLabel";
            display_nameLabel.Size = new System.Drawing.Size(73, 13);
            display_nameLabel.TabIndex = 0;
            display_nameLabel.Text = "Display name:";
            // 
            // display_NameLabel1
            // 
            display_NameLabel1.AutoSize = true;
            display_NameLabel1.Location = new System.Drawing.Point(20, 68);
            display_NameLabel1.Name = "display_NameLabel1";
            display_NameLabel1.Size = new System.Drawing.Size(75, 13);
            display_NameLabel1.TabIndex = 2;
            display_NameLabel1.Text = "Display Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(20, 94);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // photo_urlLabel
            // 
            photo_urlLabel.AutoSize = true;
            photo_urlLabel.Location = new System.Drawing.Point(20, 120);
            photo_urlLabel.Name = "photo_urlLabel";
            photo_urlLabel.Size = new System.Drawing.Size(52, 13);
            photo_urlLabel.TabIndex = 6;
            photo_urlLabel.Text = "Photo url:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(20, 146);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(23, 13);
            urlLabel.TabIndex = 8;
            urlLabel.Text = "Url:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 172);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username:";
            // 
            // display_nameComboBox
            // 
            this.display_nameComboBox.DataSource = this.dailyMileFriendBindingSource;
            this.display_nameComboBox.DisplayMember = "Display_Name";
            this.display_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.display_nameComboBox.FormattingEnabled = true;
            this.display_nameComboBox.Location = new System.Drawing.Point(214, 7);
            this.display_nameComboBox.Name = "display_nameComboBox";
            this.display_nameComboBox.Size = new System.Drawing.Size(226, 21);
            this.display_nameComboBox.TabIndex = 1;
            this.display_nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.display_nameComboBox_SelectionChangeCommitted);
            // 
            // dailyMileFriendBindingSource
            // 
            this.dailyMileFriendBindingSource.DataSource = typeof(VengSoft.DailyMileAPIWrapper.DailyMileFriend);
            // 
            // display_NameTextBox
            // 
            this.display_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileFriendBindingSource, "Display_Name", true));
            this.display_NameTextBox.Location = new System.Drawing.Point(101, 65);
            this.display_NameTextBox.Name = "display_NameTextBox";
            this.display_NameTextBox.ReadOnly = true;
            this.display_NameTextBox.Size = new System.Drawing.Size(454, 20);
            this.display_NameTextBox.TabIndex = 3;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileFriendBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(101, 91);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(454, 20);
            this.locationTextBox.TabIndex = 5;
            // 
            // photo_urlTextBox
            // 
            this.photo_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileFriendBindingSource, "Photo_url", true));
            this.photo_urlTextBox.Location = new System.Drawing.Point(101, 117);
            this.photo_urlTextBox.Name = "photo_urlTextBox";
            this.photo_urlTextBox.ReadOnly = true;
            this.photo_urlTextBox.Size = new System.Drawing.Size(454, 20);
            this.photo_urlTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileFriendBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(101, 169);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(454, 20);
            this.usernameTextBox.TabIndex = 11;
            // 
            // btnViewEntries
            // 
            this.btnViewEntries.Location = new System.Drawing.Point(12, 7);
            this.btnViewEntries.Name = "btnViewEntries";
            this.btnViewEntries.Size = new System.Drawing.Size(75, 23);
            this.btnViewEntries.TabIndex = 12;
            this.btnViewEntries.Text = "View Entries";
            this.btnViewEntries.UseVisualStyleBackColor = true;
            this.btnViewEntries.Click += new System.EventHandler(this.btnViewEntries_Click);
            // 
            // dmpBox
            // 
            this.dmpBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dailyMileFriendBindingSource, "Photo_url", true));
            this.dmpBox.Location = new System.Drawing.Point(495, 7);
            this.dmpBox.Name = "dmpBox";
            this.dmpBox.Size = new System.Drawing.Size(68, 50);
            this.dmpBox.TabIndex = 13;
            this.dmpBox.TabStop = false;
            // 
            // dailyMileMeBindingSource
            // 
            this.dailyMileMeBindingSource.DataSource = typeof(VengSoft.DailyMileAPIWrapper.DailyMileMe);
            // 
            // urlLinkLabelEntryUrl
            // 
            this.urlLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileFriendBindingSource, "Url", true));
            this.urlLinkLabel.Location = new System.Drawing.Point(104, 142);
            this.urlLinkLabel.Name = "urlLinkLabelEntryUrl";
            this.urlLinkLabel.Size = new System.Drawing.Size(451, 23);
            this.urlLinkLabel.TabIndex = 14;
            this.urlLinkLabel.TabStop = true;
            this.urlLinkLabel.Text = "linkLabel1";
            this.urlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel_LinkClicked);
            // 
            // frmViewFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(575, 221);
            this.Controls.Add(this.urlLinkLabel);
            this.Controls.Add(this.dmpBox);
            this.Controls.Add(this.btnViewEntries);
            this.Controls.Add(display_NameLabel1);
            this.Controls.Add(this.display_NameTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(photo_urlLabel);
            this.Controls.Add(this.photo_urlTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(display_nameLabel);
            this.Controls.Add(this.display_nameComboBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DMBackUp.Properties.Settings.Default, "frmViewFriends", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DMBackUp.Properties.Settings.Default.frmViewFriends;
            this.MaximumSize = new System.Drawing.Size(591, 259);
            this.MinimumSize = new System.Drawing.Size(591, 259);
            this.Name = "frmViewFriends";
            this.ShowInTaskbar = false;
            this.Text = "DMBackUp - View Friends";
            this.Load += new System.EventHandler(this.frmViewFriends_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewFriends_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileFriendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileMeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox display_nameComboBox;
        private System.Windows.Forms.BindingSource dailyMileFriendBindingSource;
        private System.Windows.Forms.TextBox display_NameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox photo_urlTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button btnViewEntries;
        private System.Windows.Forms.PictureBox dmpBox;
        private System.Windows.Forms.BindingSource dailyMileMeBindingSource;
        private System.Windows.Forms.LinkLabel urlLinkLabel;
    }
}