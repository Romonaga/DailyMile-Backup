namespace VengSoft.DMBackUp
{
    partial class frmViewEntries
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch{}
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label display_NameLabel;
            System.Windows.Forms.Label photo_urlLabel;
            System.Windows.Forms.Label urlLabel1;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label activity_typeLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label feltLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label unitsLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label localTimeLabel;
            System.Windows.Forms.Label paceLabel;
            System.Windows.Forms.Label urlLabel2;
            this.dailyMileEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyMileEntryComboBox = new System.Windows.Forms.ComboBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.display_NameTextBox = new System.Windows.Forms.TextBox();
            this.photo_urlTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.activity_typeTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.feltTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.grbEntryInfo = new System.Windows.Forms.GroupBox();
            this.llLikeNote = new System.Windows.Forms.LinkLabel();
            this.urlLinkLabelEntryUrl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.likesListBox = new System.Windows.Forms.ListBox();
            this.likesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localTimeTextBox = new System.Windows.Forms.TextBox();
            this.btnViewcomments = new System.Windows.Forms.Button();
            this.numberOfCommentsTextBox = new System.Windows.Forms.TextBox();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.grbWorkout = new System.Windows.Forms.GroupBox();
            this.paceTextBox = new System.Windows.Forms.TextBox();
            this.grbUserInfo = new System.Windows.Forms.GroupBox();
            this.urlLinkableUserURL = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbNumEntries = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.fsDlg = new System.Windows.Forms.SaveFileDialog();
            iDLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            display_NameLabel = new System.Windows.Forms.Label();
            photo_urlLabel = new System.Windows.Forms.Label();
            urlLabel1 = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            activity_typeLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            feltLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            unitsLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            localTimeLabel = new System.Windows.Forms.Label();
            paceLabel = new System.Windows.Forms.Label();
            urlLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileEntryBindingSource)).BeginInit();
            this.grbEntryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).BeginInit();
            this.grbWorkout.SuspendLayout();
            this.grbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(26, 26);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(3, 99);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 5;
            messageLabel.Text = "Message:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(390, 14);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(23, 13);
            urlLabel.TabIndex = 7;
            urlLabel.Text = "Url:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(344, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(51, 13);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Location:";
            // 
            // display_NameLabel
            // 
            display_NameLabel.AutoSize = true;
            display_NameLabel.Location = new System.Drawing.Point(20, 59);
            display_NameLabel.Name = "display_NameLabel";
            display_NameLabel.Size = new System.Drawing.Size(75, 13);
            display_NameLabel.TabIndex = 15;
            display_NameLabel.Text = "Display Name:";
            // 
            // photo_urlLabel
            // 
            photo_urlLabel.AutoSize = true;
            photo_urlLabel.Location = new System.Drawing.Point(20, 89);
            photo_urlLabel.Name = "photo_urlLabel";
            photo_urlLabel.Size = new System.Drawing.Size(52, 13);
            photo_urlLabel.TabIndex = 17;
            photo_urlLabel.Text = "Photo url:";
            // 
            // urlLabel1
            // 
            urlLabel1.AutoSize = true;
            urlLabel1.Location = new System.Drawing.Point(20, 115);
            urlLabel1.Name = "urlLabel1";
            urlLabel1.Size = new System.Drawing.Size(23, 13);
            urlLabel1.TabIndex = 19;
            urlLabel1.Text = "Url:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 21;
            usernameLabel.Text = "Username:";
            // 
            // activity_typeLabel
            // 
            activity_typeLabel.AutoSize = true;
            activity_typeLabel.Location = new System.Drawing.Point(18, 25);
            activity_typeLabel.Name = "activity_typeLabel";
            activity_typeLabel.Size = new System.Drawing.Size(67, 13);
            activity_typeLabel.TabIndex = 23;
            activity_typeLabel.Text = "Activity type:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(33, 54);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 25;
            durationLabel.Text = "Duration:";
            // 
            // feltLabel
            // 
            feltLabel.AutoSize = true;
            feltLabel.Location = new System.Drawing.Point(54, 80);
            feltLabel.Name = "feltLabel";
            feltLabel.Size = new System.Drawing.Size(27, 13);
            feltLabel.TabIndex = 27;
            feltLabel.Text = "Felt:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(272, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 29;
            titleLabel.Text = "Title:";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Location = new System.Drawing.Point(270, 54);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(34, 13);
            unitsLabel.TabIndex = 31;
            unitsLabel.Text = "Units:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(270, 80);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 33;
            valueLabel.Text = "Value:";
            // 
            // localTimeLabel
            // 
            localTimeLabel.AutoSize = true;
            localTimeLabel.Location = new System.Drawing.Point(171, 26);
            localTimeLabel.Name = "localTimeLabel";
            localTimeLabel.Size = new System.Drawing.Size(60, 13);
            localTimeLabel.TabIndex = 11;
            localTimeLabel.Text = "Entry Time:";
            // 
            // paceLabel
            // 
            paceLabel.AutoSize = true;
            paceLabel.Location = new System.Drawing.Point(404, 51);
            paceLabel.Name = "paceLabel";
            paceLabel.Size = new System.Drawing.Size(35, 13);
            paceLabel.TabIndex = 34;
            paceLabel.Text = "Pace:";
            // 
            // urlLabel2
            // 
            urlLabel2.AutoSize = true;
            urlLabel2.Location = new System.Drawing.Point(407, 26);
            urlLabel2.Name = "urlLabel2";
            urlLabel2.Size = new System.Drawing.Size(23, 13);
            urlLabel2.TabIndex = 14;
            urlLabel2.Text = "Url:";
            // 
            // dailyMileEntryBindingSource
            // 
            this.dailyMileEntryBindingSource.DataSource = typeof(VengSoft.DailyMileAPIWrapper.DailyMileEntry);
            // 
            // dailyMileEntryComboBox
            // 
            this.dailyMileEntryComboBox.DataSource = this.dailyMileEntryBindingSource;
            this.dailyMileEntryComboBox.DisplayMember = "WorkOutTitle";
            this.dailyMileEntryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dailyMileEntryComboBox.FormattingEnabled = true;
            this.dailyMileEntryComboBox.Location = new System.Drawing.Point(86, 43);
            this.dailyMileEntryComboBox.Name = "dailyMileEntryComboBox";
            this.dailyMileEntryComboBox.Size = new System.Drawing.Size(655, 21);
            this.dailyMileEntryComboBox.TabIndex = 1;
            this.dailyMileEntryComboBox.ValueMember = "Comments";
            this.dailyMileEntryComboBox.SelectionChangeCommitted += new System.EventHandler(this.dailyMileEntryComboBox_SelectionChangeCommitted);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(58, 26);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(109, 20);
            this.iDTextBox.TabIndex = 4;
            this.iDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(58, 54);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(748, 105);
            this.messageTextBox.TabIndex = 6;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "Url", true));
            this.urlTextBox.Location = new System.Drawing.Point(419, 11);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(387, 20);
            this.urlTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "Location.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(401, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // display_NameTextBox
            // 
            this.display_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "User.Display_Name", true));
            this.display_NameTextBox.Location = new System.Drawing.Point(101, 56);
            this.display_NameTextBox.Name = "display_NameTextBox";
            this.display_NameTextBox.ReadOnly = true;
            this.display_NameTextBox.Size = new System.Drawing.Size(158, 20);
            this.display_NameTextBox.TabIndex = 16;
            // 
            // photo_urlTextBox
            // 
            this.photo_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "User.Photo_url", true));
            this.photo_urlTextBox.Location = new System.Drawing.Point(101, 86);
            this.photo_urlTextBox.Name = "photo_urlTextBox";
            this.photo_urlTextBox.ReadOnly = true;
            this.photo_urlTextBox.Size = new System.Drawing.Size(504, 20);
            this.photo_urlTextBox.TabIndex = 18;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "User.Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(101, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(158, 20);
            this.usernameTextBox.TabIndex = 22;
            // 
            // activity_typeTextBox
            // 
            this.activity_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Activity_type", true));
            this.activity_typeTextBox.Location = new System.Drawing.Point(106, 25);
            this.activity_typeTextBox.Name = "activity_typeTextBox";
            this.activity_typeTextBox.ReadOnly = true;
            this.activity_typeTextBox.Size = new System.Drawing.Size(135, 20);
            this.activity_typeTextBox.TabIndex = 24;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(106, 51);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.ReadOnly = true;
            this.durationTextBox.Size = new System.Drawing.Size(135, 20);
            this.durationTextBox.TabIndex = 26;
            // 
            // feltTextBox
            // 
            this.feltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Felt", true));
            this.feltTextBox.Location = new System.Drawing.Point(106, 77);
            this.feltTextBox.Name = "feltTextBox";
            this.feltTextBox.ReadOnly = true;
            this.feltTextBox.Size = new System.Drawing.Size(135, 20);
            this.feltTextBox.TabIndex = 28;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(313, 22);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(493, 20);
            this.titleTextBox.TabIndex = 30;
            // 
            // grbEntryInfo
            // 
            this.grbEntryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEntryInfo.Controls.Add(this.llLikeNote);
            this.grbEntryInfo.Controls.Add(urlLabel2);
            this.grbEntryInfo.Controls.Add(this.urlLinkLabelEntryUrl);
            this.grbEntryInfo.Controls.Add(this.label2);
            this.grbEntryInfo.Controls.Add(this.likesListBox);
            this.grbEntryInfo.Controls.Add(localTimeLabel);
            this.grbEntryInfo.Controls.Add(this.localTimeTextBox);
            this.grbEntryInfo.Controls.Add(this.btnViewcomments);
            this.grbEntryInfo.Controls.Add(this.numberOfCommentsTextBox);
            this.grbEntryInfo.Controls.Add(iDLabel);
            this.grbEntryInfo.Controls.Add(this.iDTextBox);
            this.grbEntryInfo.Controls.Add(this.messageTextBox);
            this.grbEntryInfo.Controls.Add(messageLabel);
            this.grbEntryInfo.Location = new System.Drawing.Point(12, 79);
            this.grbEntryInfo.Name = "grbEntryInfo";
            this.grbEntryInfo.Size = new System.Drawing.Size(814, 228);
            this.grbEntryInfo.TabIndex = 31;
            this.grbEntryInfo.TabStop = false;
            this.grbEntryInfo.Text = "Entry Info";
            // 
            // llLikeNote
            // 
            this.llLikeNote.AutoSize = true;
            this.llLikeNote.Location = new System.Drawing.Point(581, 165);
            this.llLikeNote.Name = "llLikeNote";
            this.llLikeNote.Size = new System.Drawing.Size(50, 13);
            this.llLikeNote.TabIndex = 16;
            this.llLikeNote.TabStop = true;
            this.llLikeNote.Text = "Like This";
            this.llLikeNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLikeNote_LinkClicked);
            // 
            // urlLinkLabelEntryUrl
            // 
            this.urlLinkLabelEntryUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "Url", true));
            this.urlLinkLabelEntryUrl.Location = new System.Drawing.Point(436, 26);
            this.urlLinkLabelEntryUrl.Name = "urlLinkLabelEntryUrl";
            this.urlLinkLabelEntryUrl.Size = new System.Drawing.Size(293, 20);
            this.urlLinkLabelEntryUrl.TabIndex = 15;
            this.urlLinkLabelEntryUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Likes:";
            // 
            // likesListBox
            // 
            this.likesListBox.DataSource = this.likesBindingSource;
            this.likesListBox.DisplayMember = "Display";
            this.likesListBox.FormattingEnabled = true;
            this.likesListBox.Location = new System.Drawing.Point(302, 165);
            this.likesListBox.Name = "likesListBox";
            this.likesListBox.Size = new System.Drawing.Size(261, 43);
            this.likesListBox.TabIndex = 13;
            this.likesListBox.ValueMember = "Created_at";
            // 
            // likesBindingSource
            // 
            this.likesBindingSource.DataMember = "Likes";
            this.likesBindingSource.DataSource = this.dailyMileEntryBindingSource;
            // 
            // localTimeTextBox
            // 
            this.localTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "LocalTime", true));
            this.localTimeTextBox.Location = new System.Drawing.Point(236, 26);
            this.localTimeTextBox.Name = "localTimeTextBox";
            this.localTimeTextBox.ReadOnly = true;
            this.localTimeTextBox.Size = new System.Drawing.Size(136, 20);
            this.localTimeTextBox.TabIndex = 12;
            this.localTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnViewcomments
            // 
            this.btnViewcomments.Location = new System.Drawing.Point(62, 173);
            this.btnViewcomments.Name = "btnViewcomments";
            this.btnViewcomments.Size = new System.Drawing.Size(107, 23);
            this.btnViewcomments.TabIndex = 10;
            this.btnViewcomments.Text = "View Comments";
            this.btnViewcomments.UseVisualStyleBackColor = true;
            this.btnViewcomments.Click += new System.EventHandler(this.btnViewcomments_Click);
            // 
            // numberOfCommentsTextBox
            // 
            this.numberOfCommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "NumberOfComments", true));
            this.numberOfCommentsTextBox.Location = new System.Drawing.Point(175, 173);
            this.numberOfCommentsTextBox.Name = "numberOfCommentsTextBox";
            this.numberOfCommentsTextBox.ReadOnly = true;
            this.numberOfCommentsTextBox.Size = new System.Drawing.Size(42, 20);
            this.numberOfCommentsTextBox.TabIndex = 9;
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Distance.Units", true));
            this.unitsTextBox.Location = new System.Drawing.Point(313, 51);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.ReadOnly = true;
            this.unitsTextBox.Size = new System.Drawing.Size(69, 20);
            this.unitsTextBox.TabIndex = 32;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Distance.Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(313, 77);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(69, 20);
            this.valueTextBox.TabIndex = 34;
            // 
            // grbWorkout
            // 
            this.grbWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbWorkout.Controls.Add(paceLabel);
            this.grbWorkout.Controls.Add(this.paceTextBox);
            this.grbWorkout.Controls.Add(unitsLabel);
            this.grbWorkout.Controls.Add(this.unitsTextBox);
            this.grbWorkout.Controls.Add(valueLabel);
            this.grbWorkout.Controls.Add(this.valueTextBox);
            this.grbWorkout.Controls.Add(activity_typeLabel);
            this.grbWorkout.Controls.Add(this.activity_typeTextBox);
            this.grbWorkout.Controls.Add(durationLabel);
            this.grbWorkout.Controls.Add(this.durationTextBox);
            this.grbWorkout.Controls.Add(feltLabel);
            this.grbWorkout.Controls.Add(this.feltTextBox);
            this.grbWorkout.Controls.Add(titleLabel);
            this.grbWorkout.Controls.Add(this.titleTextBox);
            this.grbWorkout.Location = new System.Drawing.Point(12, 461);
            this.grbWorkout.Name = "grbWorkout";
            this.grbWorkout.Size = new System.Drawing.Size(814, 117);
            this.grbWorkout.TabIndex = 35;
            this.grbWorkout.TabStop = false;
            this.grbWorkout.Text = "Workout Info";
            // 
            // paceTextBox
            // 
            this.paceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "WorkOut.Pace", true));
            this.paceTextBox.Location = new System.Drawing.Point(445, 48);
            this.paceTextBox.Name = "paceTextBox";
            this.paceTextBox.ReadOnly = true;
            this.paceTextBox.Size = new System.Drawing.Size(100, 20);
            this.paceTextBox.TabIndex = 35;
            // 
            // grbUserInfo
            // 
            this.grbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUserInfo.Controls.Add(this.urlLinkableUserURL);
            this.grbUserInfo.Controls.Add(display_NameLabel);
            this.grbUserInfo.Controls.Add(this.display_NameTextBox);
            this.grbUserInfo.Controls.Add(photo_urlLabel);
            this.grbUserInfo.Controls.Add(this.photo_urlTextBox);
            this.grbUserInfo.Controls.Add(urlLabel1);
            this.grbUserInfo.Controls.Add(usernameLabel);
            this.grbUserInfo.Controls.Add(this.usernameTextBox);
            this.grbUserInfo.Controls.Add(nameLabel);
            this.grbUserInfo.Controls.Add(this.nameTextBox);
            this.grbUserInfo.Location = new System.Drawing.Point(12, 307);
            this.grbUserInfo.Name = "grbUserInfo";
            this.grbUserInfo.Size = new System.Drawing.Size(802, 166);
            this.grbUserInfo.TabIndex = 36;
            this.grbUserInfo.TabStop = false;
            this.grbUserInfo.Text = "User Info";
            // 
            // urlLinkableUserURL
            // 
            this.urlLinkableUserURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileEntryBindingSource, "User.Url", true));
            this.urlLinkableUserURL.Location = new System.Drawing.Point(103, 115);
            this.urlLinkableUserURL.Name = "urlLinkableUserURL";
            this.urlLinkableUserURL.Size = new System.Drawing.Size(502, 23);
            this.urlLinkableUserURL.TabIndex = 23;
            this.urlLinkableUserURL.TabStop = true;
            this.urlLinkableUserURL.Text = "linkLabel1";
            this.urlLinkableUserURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Entries";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.dailyMileEntryBindingSource;
            // 
            // txtbNumEntries
            // 
            this.txtbNumEntries.Location = new System.Drawing.Point(326, 11);
            this.txtbNumEntries.Name = "txtbNumEntries";
            this.txtbNumEntries.ReadOnly = true;
            this.txtbNumEntries.Size = new System.Drawing.Size(58, 20);
            this.txtbNumEntries.TabIndex = 38;
            this.txtbNumEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(199, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmViewEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 597);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtbNumEntries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbUserInfo);
            this.Controls.Add(this.grbEntryInfo);
            this.Controls.Add(this.grbWorkout);
            this.Controls.Add(this.dailyMileEntryComboBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(urlLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DMBackUp.Properties.Settings.Default, "frmViewEntries", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DMBackUp.Properties.Settings.Default.frmViewEntries;
            this.MaximumSize = new System.Drawing.Size(842, 635);
            this.MinimumSize = new System.Drawing.Size(842, 635);
            this.Name = "frmViewEntries";
            this.Text = "DMBackUp - View Entries";
            this.Load += new System.EventHandler(this.frmViewEntries_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewEntries_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileEntryBindingSource)).EndInit();
            this.grbEntryInfo.ResumeLayout(false);
            this.grbEntryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).EndInit();
            this.grbWorkout.ResumeLayout(false);
            this.grbWorkout.PerformLayout();
            this.grbUserInfo.ResumeLayout(false);
            this.grbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dailyMileEntryBindingSource;
        private System.Windows.Forms.ComboBox dailyMileEntryComboBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox display_NameTextBox;
        private System.Windows.Forms.TextBox photo_urlTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox activity_typeTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox feltTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox grbEntryInfo;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.GroupBox grbWorkout;
        private System.Windows.Forms.GroupBox grbUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.Button btnViewcomments;
        private System.Windows.Forms.TextBox numberOfCommentsTextBox;
        private System.Windows.Forms.TextBox txtbNumEntries;
        private System.Windows.Forms.TextBox localTimeTextBox;
        private System.Windows.Forms.BindingSource likesBindingSource;
        private System.Windows.Forms.ListBox likesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paceTextBox;
        private System.Windows.Forms.LinkLabel urlLinkLabelEntryUrl;
        private System.Windows.Forms.LinkLabel urlLinkableUserURL;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog fsDlg;
        private System.Windows.Forms.LinkLabel llLikeNote;

    }
}