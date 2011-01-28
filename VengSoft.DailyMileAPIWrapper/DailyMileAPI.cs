using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;

using System.Net;




namespace VengSoft.DailyMileAPIWrapper
{

    // Cross Training, Cc Skiing, Rock Climbing 

    public enum enumActivityType { Unknown, Core_Fitness, Rock_Climbing, Cc_Skiing, Cross_Training, Spinning, Rowing, Hiking, Elliptical, CrossFit, Running, Cycling, Swimming, Walking, Fitness, Yoga, Weights, Commute };
    public class DailyMileAPI
    {
       
 
        DailyMileConnectionInfo _connectionInfo;
        public DailyMileAPI(DailyMileConnectionInfo connectionInfo)
        {
            _connectionInfo = connectionInfo;
        }

        public bool LogonDailyMile()
        {
            bool retVal = true;
            try
            {
                if (_connectionInfo.IsTokenStillValid == false)
                {
                    DailyMileLogon logon = new DailyMileLogon(_connectionInfo);
                    if (logon.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    {
                        _connectionInfo.IsTokenStillValid = false;
                        _connectionInfo.IsLoggedIn = false;
                        retVal = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new VSException(string.Format("LogonDailyMile Exception {0}", ex.Message));
            }
            return retVal;
        }

        public void TestFunction()
        {
            DailyMileMe profile;
            string jsonResults;

            profile = new DailyMileMe();

            if (LogonDailyMile() == true)
            {
                string getAuth = string.Format("{0}/people/{1}/events/all.json?oauth_token={2}", _connectionInfo.DailyMileURL, "", _connectionInfo.ServerKey);
                Uri reqToken = new Uri(getAuth);

                try
                {

                    jsonResults = RequestData(getAuth);
                }
                catch (VSException ve)
                {

                }
                catch (System.Exception ex)
                {

                }
            }

        }

        private string RequestData(string reqString)
        {
            string jsonResults = "";
            HttpWebRequest request;

            try
            {


                request = (HttpWebRequest)WebRequest.Create(reqString);
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
                            DailyMileConnectionInfo.SaveConnectionInfo(_connectionInfo.ConfigFileLocation, _connectionInfo);
                        }
                    }

                }
                _connectionInfo.IsTokenStillValid = true;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("RequestData reqstring({0} Exception {1}.", reqString, ex.Message));
            }
          
            return jsonResults;
    
        }


        private string PostData(string postUrl, byte[] postData)
        {
            string jsonResults = "";
            HttpWebRequest request;
            

            try
            {

                request = (HttpWebRequest)WebRequest.Create(postUrl);
                request.Method = "POST";
                request.ContentType = "application/json";

                request.ContentLength = postData.Length;
                using (Stream newStream = request.GetRequestStream())
                {
                    newStream.Write(postData, 0, postData.Length);

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        if (response.StatusCode == HttpStatusCode.Created)
                        {
                            using (Stream responseStream = response.GetResponseStream())
                            {
                                using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
                                {

                                    jsonResults = readStream.ReadToEnd();

                                }
                                DailyMileConnectionInfo.SaveConnectionInfo(_connectionInfo.ConfigFileLocation, _connectionInfo);
                            }
                        }

                    }
                }
                _connectionInfo.IsTokenStillValid = true;
            }
            catch (System.Net.WebException we)
            {
                if ( (int)((HttpWebResponse)we.Response).StatusCode != 422)
                {
                    throw new VSException(string.Format("PostData PostURL({0}) Excption {1} WebResponse({2})", postUrl, we.Message, ((HttpWebResponse)we.Response).StatusCode));
                }
                
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("PostData PostURL({0}) Excption {1}", postUrl, ex.Message));
            }

            return jsonResults;

        }


        public DailyMileEntry PostEntry(DailyMileEntry entry)
        {
            DailyMileEntry retVal = null;

            try
            {
                byte[] data = SerializersJSON.Serialize<DailyMileEntry>(entry);

                string results;

                if (LogonDailyMile() == true)
                {
                    string getAuth = string.Format("{0}/entries.json?oauth_token={1}", _connectionInfo.DailyMileURL, _connectionInfo.ServerKey);
                    results = PostData(getAuth, data);
                    retVal = SerializersJSON.Deserialise<DailyMileEntry>(Encoding.ASCII.GetBytes(results));
                }
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (Exception ex)
            {
                throw new VSException(string.Format("PostEntry Exception {0}", ex.Message));
            }
            return retVal;
        }

        public void GetEventID(string id)
        {
           
            string jsonResults;

           

            if (LogonDailyMile() == true)
            {
               
                try
                {
                    string getAuth = string.Format("{0}/events/{1}.json?oauth_token={2}", _connectionInfo.DailyMileURL, id, _connectionInfo.ServerKey);    
                    jsonResults = RequestData(getAuth);
                }
                catch (VSException ve)
                {
                    throw ve;
                }
                catch (System.Exception ex)
                {
                    throw new VSException(string.Format("GetEventID Exception {0}", ex.Message));
                }
            }

        }

        //[{"id":15142,"title":"Hot Chocolate 5K/15K"},{"id":15561,"title":"Santa Hustle 5K"},{"id":15563,"title":"NYD5K"},{"id":24467,"title":"OneAmerica 500 Festival Mini Marathon"},{"id":25555,"title":"Chicago Rock 'n' Roll Half Marathon 2011"},{"id":27154,"title":"2011 Chicago Half Marathon"},{"id":28791,"title":"Chicago Marathon 2011"},{"id":28876,"title":"Bonfield Express"},{"id":29583,"title":"Chicago Spring Half"},{"id":31321,"title":"Warrior Dash Midwest"}]
        public List<DailyMileEvent> GetUsersEvents(string userName)
        {
            List<DailyMileEvent> events;
            string jsonResults;

            events = new List<DailyMileEvent>();

            if (LogonDailyMile() == true)
            {
                
                try
                {

                    string getAuth = string.Format("{0}/people/{1}/events/all.json?oauth_token={2}", _connectionInfo.DailyMileURL, userName, _connectionInfo.ServerKey);
                    jsonResults = RequestData(getAuth);

                    events = SerializersJSON.Deserialise<List<DailyMileEvent>>(jsonResults);
                  

                }
                catch (VSException ve)
                {
                    throw ve;
                }
                catch (System.Exception ex)
                {
                    throw new VSException(string.Format("GetUserEvents Exception ", ex.Message));
                }
            }
                                    
            return events;
        }


        public DailyMileMe GetLoggedOnUsersProfileData()
        {

            DailyMileMe profile;
            string jsonResults;

            profile = new DailyMileMe();

            if (LogonDailyMile() == true)
            {
                try
                {

                    string getAuth = string.Format("{0}/people/me.json?oauth_token={1}", _connectionInfo.DailyMileURL, _connectionInfo.ServerKey);
                    jsonResults = RequestData(getAuth);
                    
                    profile = SerializersJSON.Deserialise<DailyMileMe>(jsonResults);
                }
                catch (VSException ve)
                {
                    throw ve;
                }
                catch (System.Exception ex)
                {
                    throw new VSException(string.Format("GetLoggedOnUsersProfileData Exception {0}", ex.Message));
                }
            }

            return profile;
        }

        public DailyMileFriends GetUsersFriends(string userName)
        {
            string jsonResults;
            string reqData = string.Empty;

            DailyMileFriends friends = new DailyMileFriends();

            try
            {
                
                if (LogonDailyMile() == true)
                {
                    
                        reqData = string.Format("{0}/people/{1}/friends.json?oauth_token={2}", _connectionInfo.DailyMileURL, userName, _connectionInfo.ServerKey);
                        jsonResults = RequestData(reqData);
                        friends = SerializersJSON.Deserialise<DailyMileFriends>(jsonResults);
                    
                }
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("GetUsersFriends User({0}) reqData({1}) Exception {2}", userName, reqData, ex.Message));
            }

            return friends;
        }

        public DailyMileEntries GetUserEntries(string userName)
        {
            string jsonResults;

            DailyMileEntries entries;


            entries = new DailyMileEntries();
            try
            {
                if (LogonDailyMile() == true)
                {
                    string getAuth = string.Format("{0}/people/{1}/entries.json?oauth_token={2}", _connectionInfo.DailyMileURL, userName, _connectionInfo.ServerKey);
                    jsonResults = RequestData(getAuth);
                    entries = SerializersJSON.Deserialise<DailyMileEntries>(jsonResults);
                }
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("GetUserEntries Name({1}) Exception {0}", userName, ex.Message));
            }

            return entries;
        }

        public DailyMileEntries GetUserEntries(string userName, int since, int until)
        {
            string jsonResults;

            DailyMileEntries entries;


            entries = new DailyMileEntries();
            try
            {
                
                if (LogonDailyMile() == true)
                {
                    string getAuth = string.Format("{0}/people/{1}/entries.json?until={2}&since={3}&page=1&oauth_token={4}", _connectionInfo.DailyMileURL, userName, until, since,  _connectionInfo.ServerKey);
                    jsonResults = RequestData(getAuth);

                    entries = SerializersJSON.Deserialise<DailyMileEntries>(jsonResults);

                }
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("GetUserEntries Name({1}) Exception {0}", userName, ex.Message));
            }

            return entries;
        }

        public DailyMileEntries GetFriendsStream()
        {
            string jsonResults;
            DailyMileEntries entries;


            entries = new DailyMileEntries();
            try
            {
       
                string getAuth = string.Format("{0}/entries/friends.json?oauth_token={1}", _connectionInfo.DailyMileURL, _connectionInfo.ServerKey);
                jsonResults = RequestData(getAuth);
                entries = SerializersJSON.Deserialise<DailyMileEntries>(jsonResults);
                
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("GetFriendsStream Exception {0}", ex.Message));
            }

            return entries;
        }



        public static DailyMileEntries GetStoredEntries(string fileName)
        {


            DailyMileEntries storedEntries = new DailyMileEntries();

            try
            {
                if (File.Exists(fileName) == true)
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                    {
                        if (fs.Length > 0)
                        {
                            using (BinaryReader binReader = new BinaryReader(fs))
                            {
                                storedEntries = SerializersJSON.Deserialise<DailyMileEntries>(binReader.ReadBytes((int)fs.Length));
                            }
                        }
                    }
                }
            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("GetStoredEntries FileName({0}) Exception {1}",fileName, ex.Message));
            }



            return storedEntries;
        }

        
        //POST https://api.dailymile.com/entries/id/likes.json 
        public DailyMileLikes PostLike(int id)
        {
            DailyMileLikes retVal = null;

            try
            {
                
                string results;

                if (LogonDailyMile() == true)
                {
                    string getAuth = string.Format("{0}/entries/{1}/likes.json?oauth_token={2}", _connectionInfo.DailyMileURL, id, _connectionInfo.ServerKey);
                    results = PostData(getAuth, new byte[0]);
                    if(string.IsNullOrEmpty(results) == false)
                        retVal = SerializersJSON.Deserialise<DailyMileLikes>(Encoding.ASCII.GetBytes(results));
                }
            }
            catch (VSException ve)
            {
                throw(ve);
            }
            catch (Exception ex)
            {
                throw new VSException(string.Format("PostLike id({0}) Exception {1}", id, ex.Message));
            }
            return retVal;
        }
    }
}
