using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using VengSoft.Utilities.Serialize;

namespace VengSoft.DailyMileAPIWrapper
{
    [Serializable]
    public class DailyMileConnectionInfo
    {


        string _dailyMileURL;// = "https://api.dailymile.com";
        string _redirectURL;// = "http://www.transactfutures.com";
        string _clientID;// = "ShJwz7zGcAg0Y9DNyef8XOqN7XJOOV5VEeu5VyXq";
        string _clientSecret;// = "r9JWM6T0uUocDaVjuaQVKHmT8TkEONzTrNlA7q7c";
        DateTime _LastBackupDateUser;

        public DateTime LastBackupDateUser
        {
            get { return _LastBackupDateUser; }
            set { _LastBackupDateUser = value; }
        }
        DateTime _LastBackupDateFriends;

        public DateTime LastBackupDateFriends
        {
            get { return _LastBackupDateFriends; }
            set { _LastBackupDateFriends = value; }
        }

        string _configFileLocation;

        public string ConfigFileLocation
        {
            get { return _configFileLocation; }
            set { _configFileLocation = value; }
        }

        DateTime _securityTokenTimeStamp;

        public DateTime SecurityTokenTimeStamp
        {
            get { return _securityTokenTimeStamp; }
        }

        public string DailyMileURL
        {
            get { return _dailyMileURL; }
            set { _dailyMileURL = value; }
        }
       

        public string RedirectURL
        {
            get { return _redirectURL; }
            set { _redirectURL = value; }
        }

       

        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }

        public string ClientSecret
        {
            get { return _clientSecret; }
            set { _clientSecret = value; }
        }


        string _serverKey;

        public string ServerKey
        {
            get { return _serverKey; }
            set 
            {
                _securityTokenTimeStamp = DateTime.Now;
                _serverKey = value; 
            }
        }

        bool _isLoggedIn;

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }

        public DailyMileConnectionInfo()
        {
            _securityTokenTimeStamp = new DateTime(1970, 1, 1);
            _LastBackupDateUser = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            _LastBackupDateFriends = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day); 

        }

       
        public bool IsTokenStillValid
        {

            get
            {
                bool retValue = false;

                TimeSpan span = DateTime.Now - _securityTokenTimeStamp;
                if (span.TotalMinutes < 60)
                {
                    retValue = true;
                    _isLoggedIn = true; 
                }
                return retValue;
            }
            set
            {
                if (value == true)
                {
                    _securityTokenTimeStamp = DateTime.Now;
                    _isLoggedIn = true;
                }
                else
                {
                    _securityTokenTimeStamp = new DateTime(1970, 1, 1);
                    _isLoggedIn = false;
                }
            }


        }

        public static bool SaveConnectionInfo(string fileName, DailyMileConnectionInfo info)
        {
            try
            {
                byte[] data = Serializers.Serialize(info);
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    fs.Write(data, 0, data.Length);
                }

                return true;
            }
            catch { }

            return false;
        }

        public static DailyMileConnectionInfo ReadConnectionInfo(string fileName)
        {
            byte[] data;

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    return (DailyMileConnectionInfo)Serializers.DeSerialize(data);
                }
            }
            catch { }
            {
                return null;
            }
        }
    }
}
