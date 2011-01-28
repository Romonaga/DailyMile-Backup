using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using VengSoft.Collections;
using VengSoft.Utilities;
using VengSoft.Utilities.Serialize;
using VengSoft.Logging;
using VengSoft.DailyMileAPIWrapper;


namespace VengSoft.DMBackUp
{
    public partial class frmMain : Form
    {


        DailyMileAPI _APIWrapper;

        DailyMileMe _aboutMe = null;
        VengSoftLogger _logger;
        DailyMileConnectionInfo _dmConnectionInfo;
      
        string _dmUserinfoFilename;
        string _friendsInfoFile;
        string _dmEntriesInfoFilename;
        string _dmFriendEntriesInfoFilename;
        string _ConfigFileName;

        public frmMain()
        {
          
            InitializeComponent();

            InitLogger();
            _logger.EnQueueAppTraceMessage("frmMain() Init start");

            
          
            SetUpFileNames();
            SetupDMConnectionInfo();

            if (_dmConnectionInfo.IsTokenStillValid == true)
            {

                btnLogon.Enabled = false;
                SetLoggedOnControlValues(true);
            }

            ReadPersonalData();

            _logger.EnQueueAppTraceMessage("frmMain() Init done");

        }

        private void InitLogger()
        {
            LoggingArgs args = new LoggingArgs();
            args.ApplicationName = "DMBackUp";
            args.LogFilePath = ".\\Logs";
            args.LogLevel = LOG_LEVEL.APPTRACE;
            args.OutPutMode = LoggingOutputMode.File;

            _logger = VengSoftLogger.GetInstance(args);

        }

        private void SetupDMConnectionInfo()
        {


            _logger.EnQueueAppTraceMessage("SetupDMConnectionInfo() Enter");
            //IsTokenStillValid
            _dmConnectionInfo = DailyMileConnectionInfo.ReadConnectionInfo(_ConfigFileName);
            if (_dmConnectionInfo == null)
            {
                _logger.EnQueueAppTraceMessage("SetupDMConnectionInfo() Creating New");
                _dmConnectionInfo = new DailyMileConnectionInfo();
                _dmConnectionInfo.DailyMileURL = "https://api.dailymile.com";

                //Add your API Info here
                _dmConnectionInfo.RedirectURL = "";
                _dmConnectionInfo.ClientID = "";
                _dmConnectionInfo.ClientSecret = "";
                _dmConnectionInfo.IsLoggedIn = false;
                SetLoggedOnControlValues(false);
            }
            else
            {
                _logger.EnQueueAppTraceMessage("SetupDMConnectionInfo() Loaded");
                SetLoggedOnControlValues(_dmConnectionInfo.IsTokenStillValid);

            }

            _dmConnectionInfo.ConfigFileLocation = _ConfigFileName;
           
            _APIWrapper = new DailyMileAPI(_dmConnectionInfo);
  

            //LogonDailyMile
            _logger.EnQueueAppTraceMessage("SetupDMConnectionInfo() Leave");
        }

        private void SetUpFileNames()
        {

            string dataPath;

            _logger.EnQueueAppTraceMessage("SetUpFileNames() Enter");
            dataPath = HelperFunctions.GetAssemblyRunPath();
            dataPath += "\\Data";

            if (Directory.Exists(dataPath) == false)
                Directory.CreateDirectory(dataPath);
       
            _ConfigFileName = string.Format("{0}\\{1}", dataPath, "\\DMBackUp.cfg");
            _logger.EnQueueAppTraceMessage("SetUpFileNames() ConfigFileName: " + _ConfigFileName);

            _dmUserinfoFilename = string.Format("{0}\\{1}", dataPath, "\\DailyMileUserInfo.dat");
            _logger.EnQueueAppTraceMessage("SetUpFileNames() UserInfoFileName: " + _dmUserinfoFilename);

            _friendsInfoFile = string.Format("{0}\\{1}", dataPath, "\\DailyMileFriendsInfo.dat");
            _logger.EnQueueAppTraceMessage("SetUpFileNames() FriendsInfoFileName: " + _friendsInfoFile);

            _dmEntriesInfoFilename = string.Format("{0}\\{1}", dataPath, "\\DailyMileEntries.dat");
            _logger.EnQueueAppTraceMessage("SetUpFileNames() EntriesInfoFileName: " + _dmEntriesInfoFilename);

            _dmFriendEntriesInfoFilename = string.Format("{0}\\{1}", dataPath, "\\DailyMileFriendEntries.dat");
            _logger.EnQueueAppTraceMessage("SetUpFileNames() EntriesFriendInfoFileName: " + _dmFriendEntriesInfoFilename);

            _logger.EnQueueAppTraceMessage("SetUpFileNames() Leave");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }


        private void SetLoggedOnControlValues(bool loggedon)
        {
            _logger.EnQueueAppTraceMessage("SetLoggedOnControlValues(" + loggedon + ") Enter");
            if (loggedon == true)
            {
                

                btnGetPersonalData.Enabled = true;
                btnLogon.Enabled = false;

                _dmConnectionInfo.IsLoggedIn = true;
                btnViewFriendsStream.Enabled = true;
                btnBackUpFriends.Enabled = true;
            }
            else
            {

                

                btnGetPersonalData.Enabled = false;
                btnLogon.Enabled = true;

                _dmConnectionInfo.IsLoggedIn = false;
                btnViewFriendsStream.Enabled = false;
                btnBackUpFriends.Enabled = false;

            }

            _logger.EnQueueAppTraceMessage("SetLoggedOnControlValues(" + loggedon + ") Leave");
        }

        private void brtnGetData_Click(object sender, EventArgs e)
        {


            frmBackUpRange buRange = new frmBackUpRange(_dmConnectionInfo.LastBackupDateUser);
            if (buRange.ShowDialog() == DialogResult.OK)
            {
                grboxViews.Enabled = false;
              


                tsStatus.Text = "Backing Up User Info";
                GetPersonalData();
                tsStatus.Text = "Backing Up User Friends";
                GetFriends();
                tsStatus.Text = "Backing Up User Entries";
                CollectDateRangeEntries(_aboutMe.Username, _dmEntriesInfoFilename, buRange.SinceDateTime, buRange.UntilDateTime);
                grboxViews.Enabled = true;

                tsStatus.Text = "Backing Up Complete";

                _dmConnectionInfo.LastBackupDateUser =  buRange.UntilDateTime.AddDays(-3);
                DailyMileConnectionInfo.SaveConnectionInfo(_ConfigFileName, _dmConnectionInfo);
            }
        }

        private void GetPersonalData()
        {
            _logger.EnQueueAppTraceMessage("GetPersonalData() Enter");
            tsStatus.Text = "Requesting Your user Information";

            try
            {
                _aboutMe = _APIWrapper.GetLoggedOnUsersProfileData();

                tsStatus.Text = "I have your user info";
                dailyMileMeBindingSource.DataSource = _aboutMe;
                SavePersonalData();
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("GetPersonalData() Exception: " + ex.Message);
            }

            _logger.EnQueueAppTraceMessage("GetPersonalData() Leave");
        }

        private void GetFriends()
        {

            _logger.EnQueueAppTraceMessage("GetFriends() Enter");
            try
            {
                DailyMileFriends friends = _APIWrapper.GetUsersFriends(_aboutMe.Username);
                SaveFriendsData(friends);
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("GetFriends() Exception: " + ex.Message);
            }

            _logger.EnQueueAppTraceMessage("GetFriends() Leave");
        }

        private void GetEntries()
        {
             DailyMileEntries entries;

             try
             {
                 _logger.EnQueueAppTraceMessage("GetEntries() Enter");
                 tsStatus.Text = "Getting Your Last 20 Entries (Hope to fix this to get all soon.).";
                 entries = _APIWrapper.GetUserEntries(_aboutMe.Username);
                 tsStatus.Text = "Have your last 20 Entries (Hope to fix this to get all entries soon.).";

                 if (entries.Entries.Count > 1)
                     tsStatus.Text = "GetEntries We have Entries(" + entries.Entries.Count + ") to merge.";
                 else
                     tsStatus.Text = "GetEntries We have one Entry to merge.";

                 _logger.EnQueueAppTraceMessage("GetEntries() " + tsStatus.Text);

                 Helpers.MergeEntries(_dmEntriesInfoFilename, entries);
                 _logger.EnQueueAppTraceMessage("GetEntries() Merge finished");
                 tsStatus.Text = "GetEntries Merge Completed";
             }
             catch (System.Exception ex)
             {
                 _logger.EnQueueFatalMessage("GetEntries() Exception: " + ex.Message);
             }
            _logger.EnQueueAppTraceMessage("GetEntries() Leave");

          

        }


        private void ReadPersonalData()
        {
  

            _logger.EnQueueAppTraceMessage("ReadPersonalData() Enter");
   
            //save file
            tsStatus.Text = "Reading Stored Daily Mile User Data";

            try
            {

                using (FileStream fs = new FileStream(_dmUserinfoFilename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    if (fs.Length > 0)
                    {
                        using (BinaryReader binReader = new BinaryReader(fs))
                        {

                            _aboutMe = VengSoft.DailyMileAPIWrapper.SerializersJSON.Deserialise<DailyMileMe>(binReader.ReadBytes((int)fs.Length));
                            pbUserImage.ImageLocation = _aboutMe.Photo_url;
                        }
                    }
                    else
                    {
                        _aboutMe = new DailyMileMe();
                    }
                }

                dailyMileMeBindingSource.DataSource = _aboutMe;
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("ReadPersonalData() Exception: " + ex.Message);
            }

            _logger.EnQueueAppTraceMessage("ReadPersonalData() Leave");
        }

        private DailyMileFriends ReadFriendsData()
        {
          
            _logger.EnQueueAppTraceMessage("ReadFriendsData() Enter");

            DailyMileFriends friends;

            friends = new DailyMileFriends();
            try
            {
                using (FileStream fs = new FileStream(_friendsInfoFile, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {

                    using (BinaryReader binReader = new BinaryReader(fs))
                    {
                        friends = VengSoft.DailyMileAPIWrapper.SerializersJSON.Deserialise<DailyMileFriends>(binReader.ReadBytes((int)fs.Length));

                    }
                }
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("ReadFriendsData() Exception: " + ex.Message);
            
            }
            _logger.EnQueueAppTraceMessage("ReadFriendsData() Leave");

            return friends;
        }

        private void SaveFriendsData(DailyMileFriends dmFriends)
        {
          
            _logger.EnQueueAppTraceMessage("SaveFriendsData() Enter");
          
            tsStatus.Text = "Saving Daily Mile Friend Data";
            try
            {
                using (FileStream fs = new FileStream(_friendsInfoFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {

                    using (BinaryWriter binWriter = new BinaryWriter(fs))
                    {

                        binWriter.Write(VengSoft.DailyMileAPIWrapper.SerializersJSON.Serialize<DailyMileFriends>(dmFriends));
                    }
                }
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("SaveFriendsData() Exception: " + ex.Message);
            }
            _logger.EnQueueAppTraceMessage("SaveFriendsData() Leave");
        }


        private void SavePersonalData()
        {
            
            _logger.EnQueueAppTraceMessage("SavePersonalData() Enter");
           
  
            tsStatus.Text = "Saving Daily Mile User Data";
            try
            {
                using (FileStream fs = new FileStream(_dmUserinfoFilename, FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    using (BinaryWriter binWriter = new BinaryWriter(fs))
                    {

                        binWriter.Write(VengSoft.DailyMileAPIWrapper.SerializersJSON.Serialize<DailyMileMe>(_aboutMe));
                    }
                }
            }
            catch (System.Exception ex)
            {
                _logger.EnQueueFatalMessage("SavePersonalData() Exception: " + ex.Message);
            }
            _logger.EnQueueAppTraceMessage("SavePersonalData() Leave");
        }

   
     

        void GetAPIToken()
        {
            _logger.EnQueueAppTraceMessage("GetAPIToken() Enter");
            tsStatus.Text = "Requesting API Token From DailyMile";

            try
            {
                bool isLoggedOn = _APIWrapper.LogonDailyMile();

                if (isLoggedOn == true)
                {

                    tsStatus.Text = "We have our API Token";


                }

                SetLoggedOnControlValues(isLoggedOn);
            }
            catch (VengSoft.DailyMileAPIWrapper.VSException vs)
            {
                string exceptionText = string.Format("GetAPIToken() Exception ({0})", vs.Message);
                tsStatus.Text = exceptionText;
                _logger.EnQueueFatalMessage(exceptionText);
            }
            _logger.EnQueueAppTraceMessage("GetAPIToken() Leave");
        }


       
        private void btnLogon_Click(object sender, EventArgs e)
        {
            _logger.EnQueueAppTraceMessage("btnLogon_Click() Enter");
            GetAPIToken();
            _logger.EnQueueAppTraceMessage("btnLogon_Click() Leave");
        }

        private void btnViewFriends_Click(object sender, EventArgs e)
        {
            _logger.EnQueueAppTraceMessage("btnViewFriends_Click() Enter");
   
            frmViewFriends frmFriends = new frmViewFriends(ReadFriendsData().Friends, _APIWrapper, _aboutMe.Username);
            frmFriends.Show();
            _logger.EnQueueAppTraceMessage("btnViewFriends_Click() Leave");
        }

        private void btnViewEntries_Click(object sender, EventArgs e)
        {
            _logger.EnQueueAppTraceMessage("btnViewEntries_Click() Enter");
            BindingListView<DailyMileEntry> entries;

            entries = new BindingListView<DailyMileEntry>(DailyMileAPI.GetStoredEntries(_dmEntriesInfoFilename).Entries);

            frmViewEntries frmEntries = new frmViewEntries(_APIWrapper, _aboutMe.Username, entries, frmViewEntries.enumViewType.Me);
            frmEntries.Show();
            _logger.EnQueueAppTraceMessage("btnViewEntries_Click() Leave");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            VengSoft.DMBackUp.Properties.Settings.Default.Save();
            _logger.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DailyMileEntry entry = new DailyMileEntry();
            entry.WorkOut = new DailyMileWorkOut();
            entry.Message = "Hey";
            entry.WorkOut.Activity_type = enumActivityType.Running;
            entry.WorkOut.Distance = new DailyMileDistance();
            entry.WorkOut.Distance.Units = "miles";
            entry.WorkOut.Distance.Value = 4;

            _APIWrapper.PostEntry(entry);

            //byte[] rew = SerializersJSON.Serialize<DailyMileEntry>(entry);
           // string x = Encoding.ASCII.GetString(rew);

        }

        private void CollectDateRangeEntries(string user, string fileName, DateTime sinceTime, DateTime untilTime)
        {
            DailyMileEntries entries;
            DailyMileEntries retreviedEntries;
            int since;
            int until;

            _logger.EnQueueAppTraceMessage("CollectDateRangeEntries Enter");
            DateTime loopDateTime;

            loopDateTime = sinceTime;
            entries = new DailyMileEntries();
            while (loopDateTime <= untilTime)
            {
                loopDateTime = sinceTime.AddDays(5);

                since = Utilities.DateandTime.DateTimeUtilities.ToUnixUtcTime(sinceTime);
                until = Utilities.DateandTime.DateTimeUtilities.ToUnixUtcTime(loopDateTime);
                tsStatus.Text = string.Format("Collecting {0} Entries {1} - {2}", user, sinceTime.ToString(), loopDateTime.ToString());
                _logger.EnQueueAppTraceMessage(tsStatus.Text);
                Application.DoEvents();
                retreviedEntries = _APIWrapper.GetUserEntries(user, since, until);
                if (retreviedEntries.Entries.Count > 0)
                {
                    tsStatus.Text = string.Format("Collected {0} Entries For {1}", retreviedEntries.Entries.Count, user);
                    _logger.EnQueueAppTraceMessage(tsStatus.Text);
                    Application.DoEvents();

                    entries.Entries.AddRange(retreviedEntries.Entries);
                }
 
                sinceTime = loopDateTime;
                loopDateTime.AddDays(5);

            }
            if (entries.Entries.Count > 0)
            {
                tsStatus.Text = string.Format("Merging User {0} Entries {1}", user, entries.Entries.Count);
                _logger.EnQueueAppTraceMessage(tsStatus.Text);
            }
            else
            {
                tsStatus.Text = string.Format("No Entries For User {0}.", user);
                _logger.EnQueueAppTraceMessage(tsStatus.Text);
            }

            Helpers.MergeEntries(fileName, entries);
            _logger.EnQueueAppTraceMessage("CollectDateRangeEntries Leave");
        }

        private void GetFriendsStream()
        {
      
            DailyMileEntries entries;

            tsStatus.Text = "GetFriendsStream Started";
            _logger.EnQueueAppTraceMessage("GetFriendsStream() Enter");
            try
            {
                tsStatus.Text = "Requesting Friends Stream.";
                _logger.EnQueueAppTraceMessage("GetFriendsStream() " + tsStatus.Text);
                entries = _APIWrapper.GetFriendsStream();


                tsStatus.Text = "Have Friends Stream.";
                _logger.EnQueueAppTraceMessage("GetFriendsStream() " + tsStatus.Text);
                       
                tsStatus.Text = "Merging Friends Stream With Saved.";
                _logger.EnQueueAppTraceMessage("GetFriendsStream() " + tsStatus.Text);
                Helpers.MergeEntries(_dmFriendEntriesInfoFilename, entries);
                tsStatus.Text = "Done Merging Friends Stream.";
                _logger.EnQueueAppTraceMessage("GetFriendsStream() " + tsStatus.Text);

                _logger.EnQueueAppTraceMessage("GetFriendsStream() Leave");
               

            }
            catch (System.Exception ex)
            {
                tsStatus.Text = "GetFriendsStream() Exception: " + ex.Message;   
                _logger.EnQueueFatalMessage(tsStatus.Text);
            }

            _logger.EnQueueAppTraceMessage("GetFriendsStream() Leave");
        }

        private void ViewFriendsStream()
        {

            DailyMileEntries entries;

            entries = DailyMileAPI.GetStoredEntries(_dmFriendEntriesInfoFilename);

            frmViewEntries frmEntries = new frmViewEntries(_APIWrapper, _aboutMe.Username, new BindingListView<DailyMileEntry>(entries.Entries), frmViewEntries.enumViewType.FriendStream);


            frmEntries.Text = "DMBackUp - View Friend Stream";
            frmEntries.Show();
        }

     
        

        private void btnViewFriendsStream_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dmConnectionInfo.IsLoggedIn == true)
                {
                    GetFriendsStream();
                }
                else
                {
                    MessageBox.Show("You are Not Logged In To DailyMile", "DMBackUp - Error");
                }
            }
            catch (VengSoft.DailyMileAPIWrapper.VSException vs)
            {
                string exceptionText = string.Format("btnViewFriendsStream_Click() Exception ({0})", vs.Message);
                tsStatus.Text = exceptionText;
                _logger.EnQueueFatalMessage(exceptionText);
            }
        }

        private void btnViewFriendStream_Click(object sender, EventArgs e)
        {
            try
            {
                ViewFriendsStream();
            }
            catch (VengSoft.DailyMileAPIWrapper.VSException vs)
            {
                string exceptionText = string.Format("btnViewFriendStream_Click() Exception ({0})", vs.Message);
                tsStatus.Text = exceptionText;
                _logger.EnQueueFatalMessage(exceptionText);
            }
        }

        private void btnBackUpFriends_Click(object sender, EventArgs e)
        {
            string dataPath;
            string fileName;

            _logger.EnQueueAppTraceMessage("btnBackUpFriends_Click Enter");
            dataPath = HelperFunctions.GetAssemblyRunPath();
            dataPath += "\\Data\\Friends";
            if (Directory.Exists(dataPath) == false)
                Directory.CreateDirectory(dataPath);

      

            _logger.EnQueueAppTraceMessage("Backing Up Friends Entries");

            frmBackUpRange buRange = new frmBackUpRange(_dmConnectionInfo.LastBackupDateFriends);
            if (buRange.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    DailyMileFriends friends = ReadFriendsData();
                    foreach (DailyMileFriend friend in friends.Friends)
                    {
                        fileName = string.Format("{0}\\Dailymile_{1}_Entries.dat", dataPath, friend.Username);
                        tsStatus.Text = string.Format("Backing Up User {0} to File: {1}", friend.Username, fileName);
                        _logger.EnQueueAppTraceMessage(tsStatus.Text);
                        Application.DoEvents();

                        CollectDateRangeEntries(friend.Username, fileName, buRange.SinceDateTime, buRange.UntilDateTime);

                    }

                    _dmConnectionInfo.LastBackupDateFriends = buRange.UntilDateTime.AddDays(-3);
                    DailyMileConnectionInfo.SaveConnectionInfo(_ConfigFileName, _dmConnectionInfo);
                }
                catch (VengSoft.DailyMileAPIWrapper.VSException vs)
                {
                    string exceptionText = string.Format("btnBackUpFriends_Click() Exception ({0})", vs.Message);
                    tsStatus.Text = exceptionText;
                    _logger.EnQueueFatalMessage(exceptionText);
                }   
            }
            tsStatus.Text = "Done Backing Up Friends Entries";
            _logger.EnQueueAppTraceMessage("btnBackUpFriends_Click Leave");

        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlLinkLabel.Text);
        }

      
       
    }
}



