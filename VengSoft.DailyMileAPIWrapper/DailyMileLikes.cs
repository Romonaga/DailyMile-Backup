using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileLikes
    {
        string _created_at;

        [DataMember(Name = "created_at")]
        public string Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        DailyMilesUser _user;

        [DataMember(Name = "user")]
        public DailyMilesUser User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Display
        {
            get { return ToString(); }
        }

        public override string ToString()
        {
            return string.Format("{0} Liked this entry on {1}.", _user.Display_Name, DateTime.Parse(_created_at).ToString()); 
        }

        public DailyMileLikes()
        {
          
        }
    }
}


//"likes":[{"created_at":"2011-01-01T21:57:19Z","user":{"username":"julio_cabrera","display_name":"Julio C.","photo_url":"http://s2.dmimg.com/pictures/users/55012/1266596656_avatar.jpg","url":"http://www.dailymile.com/people/julio_cabrera"}}]