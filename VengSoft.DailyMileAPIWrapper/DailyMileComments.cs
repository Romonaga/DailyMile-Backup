using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;



namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileComments
    {
        string _created_at;

        [DataMember(Name = "created_at")]
        public string Created_at
        {
            get { return _created_at; }
            set 
            { 
                _created_at = value;
                _localTime = DateTime.Parse(_created_at);
            }
        }
        DateTime _localTime;

        public DateTime LocalTime
        {
            get { return _localTime; }
            
        }


        string _body;

        [DataMember(Name = "body")]
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        DailyMilesUser _user;
        [DataMember(Name = "user")]
        public DailyMilesUser User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Display_Name
        {
            get { return _user.Display_Name; }
        }

        DailyMileMotivation _motivation;
        [DataMember(Name = "motivation")]
        public DailyMileMotivation Motivation
        {
            get 
            {
                if (_motivation == null)
                    _motivation = new DailyMileMotivation();

                return _motivation; 
            }
            set { _motivation = value; }
        }

        public string MotovationTitle
        {
            get { return _motivation.Title; }
        }

        public DailyMileComments()
        {

        }
    }
}
