using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMilesUser
    {
        string _photo_url;
        string _url;
        string _username;
        string _display_name;


        public DailyMilesUser()
        {

        }

        [DataMember(Name = "photo_url")]
        public string Photo_url
        {
            get { return _photo_url; }
            set { _photo_url = value; }
        }

        [DataMember(Name = "url")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        [DataMember(Name = "username")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DataMember(Name = "display_name")]
        public string Display_Name
        {
            get { return _display_name; }
            set { _display_name = value; }
        }
    }
}
