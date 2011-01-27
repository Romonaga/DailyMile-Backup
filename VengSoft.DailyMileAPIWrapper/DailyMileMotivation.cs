using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileMotivation
    {
        string _type;

        [DataMember(Name = "type")]
        public string Type
        {
            get 
            {
                if (_type == null)
                    _type = "";

                return _type; 
            }
            set { _type = value; }
        }
        string _title;

        [DataMember(Name = "title")]
        public string Title
        {
            get { return _title; }
            set 
            {
                if (_title == null)
                    _title = "";

                _title = value; 
            }
        }

        public DailyMileMotivation()
        {

        }
    }
}
//"motivation":{"type":1,"title":"You're an Inspiration"}}]