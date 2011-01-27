using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileMe 
    {
        string _goal;
        
        
        string _location;

        string _username;


        string _url;

        string _photo_url;

        string _time_zone;

        string _display_name;

        [DataMember(Name="goal")]
        public string Goal
        {
            get { return _goal; }
            set { _goal = value; }
        }

        [DataMember(Name = "location")]
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [DataMember(Name = "username")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DataMember(Name = "url")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        [DataMember(Name = "photo_url")]
        public string Photo_url
        {
            get { return _photo_url; }
            set { _photo_url = value; }
        }

        [DataMember(Name = "time_zone")]
        public string Time_zone
        {
            get { return _time_zone; }
            set { _time_zone = value; }
        }

        [DataMember(Name = "display_name")]
        public string Display_name
        {
            get { return _display_name; }
            set { _display_name = value; }
        }


        public DailyMileMe()
        {

        }



    }
}
