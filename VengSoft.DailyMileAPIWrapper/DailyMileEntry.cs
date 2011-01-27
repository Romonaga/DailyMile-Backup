using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileEntry
    {

        DailyMileLocation _Location;

        [DataMember(Name = "location", EmitDefaultValue=false)]
        public DailyMileLocation Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        List<DailyMileComments> _Comments;

        [DataMember(Name = "comments", EmitDefaultValue=false)]
        public List<DailyMileComments> Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }

        
        string _url;
        [DataMember(Name = "url", EmitDefaultValue=false)]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        int _id;
        [DataMember(Name = "id", EmitDefaultValue=false)]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        DailyMileWorkOut _workOut;
        [DataMember(Name = "workout", EmitDefaultValue=false)]
        public DailyMileWorkOut WorkOut
        {
            get { return _workOut; }
            set { _workOut = value; }
        }

        string _entryDate;
        [DataMember(Name = "at", EmitDefaultValue=false)]
        public string EntryDate
        {
            get { return _entryDate; }
            set 
            { 
                _entryDate = value;
                _localTime = DateTime.Parse(_entryDate);
            }
        }

        List<DailyMileMedia> _media;
        [DataMember(Name = "media", EmitDefaultValue=false)]
        public List<DailyMileMedia> Media
        {
            get { return _media; }
            set { _media = value; }
        }

        DateTime _localTime;

        public DateTime LocalTime
        {
            get { return _localTime; }
            
        }

        public int NumberOfComments
        {
            get { return Comments.Count; }
        }
        //public string LocalTime
        //{
        //    get
        //    {
        //        DateTime cvtDate;

        //        string tstDate = "2010-12-16T13:28:24Z";
        //        DateTime.TryParse(tstDate, out cvtDate);

        //        return cvtDate.ToString();
        //    }
        //}


        DailyMilesUser _user;
        [DataMember(Name = "user",EmitDefaultValue=false)]
        public DailyMilesUser User
        {
            get { return _user; }
            set { _user = value; }
        }

        string _message;
        [DataMember(Name = "message")]
        public string Message
        {
            get 
            {
                return (string.IsNullOrEmpty(_message)) ? "" : _message;
            }
            set { _message = value; }
        }

        DailyMileGEO _geo;

        [DataMember(Name = "geo", EmitDefaultValue=false)]
        public DailyMileGEO Geo
        {
            get{    return _geo;}
            set { _geo = value; }
        }

        List<DailyMileLikes> _likes;
        [DataMember(Name = "likes", EmitDefaultValue=false)]
        public List<DailyMileLikes> Likes
        {
            get { return _likes; }
            set { _likes = value; }
        }


        public int NumberOfLikes
        {
            get { return _likes.Count; }
        }

        public string WorkOutTitle
        {
            get { return ToString(); }
        }


        public override string ToString()
        {
            if (_workOut == null)
            {
                return string.Format("{0} - Note - Comments({1}) - Likes({2})", _localTime.ToString(), NumberOfComments, NumberOfLikes);
            }

            if (_workOut.Title != null)
            {
                return string.Format("{0} - {1} - {2} - Comments({3}) - Likes({4})", _localTime.ToString(), _workOut.Activity_type, _workOut.Title, NumberOfComments, NumberOfLikes);
            }
            else
            {
                return string.Format("{0} - {1} - Entry - Comments({2}) - Likes({3})", _localTime.ToString(), _workOut.Activity_type, NumberOfComments, NumberOfLikes);
            }                
        }

        public DailyMileEntry()
        {

        }
    }
}
