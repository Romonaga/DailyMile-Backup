using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VengSoft.Collections;
using VengSoft.Utilities;
using VengSoft.DailyMileAPIWrapper;

namespace VengSoft.DMBackUp
{
    public partial class frmViewFriends : Form
    {

        DailyMileAPI _api;
        string _loggedInUser;

        public frmViewFriends(List<DailyMileFriend> friendEntries, DailyMileAPI api, string logedInUser) :base()
        {
            _api = api;
            _loggedInUser = logedInUser;
            BindingListView<DailyMileFriend> friends = new BindingListView<DailyMileFriend>(friendEntries);
            friends.SortFields = "Display_Name";
         
            InitializeComponent();
            
            display_nameComboBox.DataSource = friends.GetList();
            if (friendEntries.Count > 0)
            {
                display_nameComboBox.SelectedIndex = 0;
                UpdateControles();
            }
        }

        private void display_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateControles();
         
        }

        private void UpdateControles()
        {
            DailyMileFriend friend = display_nameComboBox.SelectedItem as DailyMileFriend;
            dailyMileFriendBindingSource.DataSource = friend;
            dmpBox.ImageLocation = friend.Photo_url;
        }

        private void frmViewFriends_Load(object sender, EventArgs e)
        {

        }

        private void frmViewFriends_FormClosing(object sender, FormClosingEventArgs e)
        {
            VengSoft.DMBackUp.Properties.Settings.Default.Save();
        }

        private void btnViewEntries_Click(object sender, EventArgs e)
        {

            string dataPath;
            string fileName;
            DailyMileEntries entries;

            dataPath = HelperFunctions.GetAssemblyRunPath();
            dataPath += "\\Data\\Friends";
            DailyMileFriend friend = display_nameComboBox.SelectedItem as DailyMileFriend;
            
            fileName = string.Format("{0}\\Dailymile_{1}_Entries.dat", dataPath, friend.Username);            

            entries = DailyMileAPI.GetStoredEntries(fileName); 

            BindingListView<DailyMileEntry> viewEntries = new BindingListView<DailyMileEntry>(entries.Entries);
            frmViewEntries frmView = new frmViewEntries(_api, _loggedInUser, viewEntries, frmViewEntries.enumViewType.Friend);
            frmView.Text = "DMBackUp - View Friends Entries";
            frmView.Show();
        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlLinkLabel.Text);
        }

       
    }
}
