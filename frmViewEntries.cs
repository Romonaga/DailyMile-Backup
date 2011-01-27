using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



using System.Web;
using System.Net;
using VengSoft.Collections;
using VengSoft.Utilities;
using VengSoft.Utilities.Serialize;
using VengSoft.DailyMileAPIWrapper;



namespace VengSoft.DMBackUp
{
    public partial class frmViewEntries : Form
    {
        public enum enumViewType{Me, Friend, FriendStream};
        BindingListView<DailyMileEntry> _entries;
        string _entriesFileName;
        string _user;

        DailyMileAPI _api;

        enumViewType _viewType;
        string _loggedInUser;

       // DailyMileConnectionInfo _connectionInfo;

        public frmViewEntries(DailyMileAPI api, string loggedInUser, BindingListView<DailyMileEntry> entries, enumViewType viewType)
            : base()
        {
            _api = api;
            _loggedInUser = loggedInUser;
            _entries = entries;
            _viewType = viewType;
            InitializeComponent();
            
        }

        private void frmViewEntries_Load(object sender, EventArgs e)
        {
            string dataPath;
      
            dataPath = HelperFunctions.GetAssemblyRunPath();

            if (_entries.Count > 0)
            {

                switch(_viewType)
                {
                    case enumViewType.Friend:
                        dataPath += "\\Data\\Friends";
                        _user = _entries[0].User.Username;
                        _entriesFileName = string.Format("{0}\\Dailymile_{1}_Entries.dat", dataPath, _user);
                        break;

                    case enumViewType.Me:
                        dataPath += "\\Data";
                        _user = _entries[0].User.Username;
                        _entriesFileName = string.Format("{0}\\DailyMileEntries.dat", dataPath);
                        llLikeNote.Enabled = false;
                        break;

                    case enumViewType.FriendStream:
                        dataPath += "\\Data";
                        _user = "FriendStream";
                        _entriesFileName = string.Format("{0}\\DailyMileFriendEntries.dat", dataPath);
                        break;

                }

               

                dailyMileEntryComboBox.DataSource = _entries;
                dailyMileEntryComboBox.SelectedItem = 0;


                dailyMileEntryBindingSource.DataSource = dailyMileEntryComboBox.SelectedItem as DailyMileEntry;

                NewSelection();

                txtbNumEntries.Text = string.Format("{0}", _entries.Count);
            }
        }

        private void dailyMileEntryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NewSelection();
        }

        private void NewSelection()
        {
            DailyMileEntry entry = dailyMileEntryComboBox.SelectedItem as DailyMileEntry;

            dailyMileEntryBindingSource.DataSource = entry;

            if (entry.NumberOfComments == 0)
                btnViewcomments.Enabled = false;
            else
                btnViewcomments.Enabled = true;

            likesBindingSource.DataSource = entry.Likes;

            
            if (_viewType != enumViewType.Me)
            {
                if (entry.WorkOut == null)
                    llLikeNote.Enabled = true;
                else
                    llLikeNote.Enabled = false;
            }

            foreach (DailyMileLikes like in entry.Likes)
            {
                if (like.User.Username == _loggedInUser)
                {
                    llLikeNote.Enabled = false;
                    llLikeNote.Text = "You Liked This.";
                    break;
                }
            }
        }

        private void frmViewEntries_FormClosing(object sender, FormClosingEventArgs e)
        {
            VengSoft.DMBackUp.Properties.Settings.Default.Save();
        }

        private void btnViewcomments_Click(object sender, EventArgs e)
        {
            DailyMileEntry entry = dailyMileEntryBindingSource.DataSource as DailyMileEntry;
            frmViewComments frmComments = new frmViewComments(entry);
            frmComments.Show();

        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlLinkLabelEntryUrl.Text);

        }

        private void urlLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlLinkableUserURL.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            ExportToXML();
        }

        private void ExportToXML()
        {
           
            int exported = 0;

            try
            {
                fsDlg.AddExtension = true;
                fsDlg.Title = "DMBackUp - Export Xml";
                fsDlg.Filter = "Xml files (*.Xml)|*.Xml";
                fsDlg.FileName = string.Format("DailyMileEntries_{0}.Xml", _user);
                if (fsDlg.ShowDialog() == DialogResult.OK)
                {
                    exported = ExportHelpers.ExportToXML(_entriesFileName, fsDlg.FileName, _user);
                   
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "DMError - Exception");
            }
        }

        private void llLikeNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DailyMileEntry entry = dailyMileEntryBindingSource.DataSource as DailyMileEntry;
            DailyMileLikes like;
            try
            {
                like = _api.PostLike(entry.ID);
                entry.Likes.Add(like);
                DailyMileAPI.MergeEntry(_entriesFileName, entry);
                NewSelection();
            }
            catch (VengSoft.Utilities.Exceptions.VSException vs)
            {
                MessageBox.Show("Exception: " + vs.Message);
            }
        }

     
      
    }
}



/*
 *  private void btnGetEntry_Click(object sender, EventArgs e)
        {
            //GET http://api.dailymile.com/entries/id.json
            DailyMileEntry entry = dailyMileEntryBindingSource.DataSource as DailyMileEntry;

            string jsonResults;

            try
            {
                int nowUnix = VengSoft.Utilities.DateandTime.DateTimeUtilities.ToUnixUtcTime(DateTime.Now);


                string getAuth = string.Format("{0}/entries/{1}.json?oauth_token={2}", _connectionInfo.DailyMileURL, entry.ID, _connectionInfo.ServerKey);
                Uri reqToken = new Uri(getAuth);


                HttpWebRequest request;

                request = (HttpWebRequest)WebRequest.Create(getAuth);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
                            {
                                jsonResults = readStream.ReadToEnd();

                               
                               
                            }
                        }
                    }

                }
            }
            catch (System.Exception ex)
            {

            }

 
        }
*/
