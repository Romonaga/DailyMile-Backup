using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace VengSoft.DailyMileAPIWrapper
{
  //  {"id":15142,"title":"Hot Chocolate 5K/15K"}
    [DataContract]
    public class DailyMileEvent
    {
        string _id;

        [DataMember(Name = "id")]
        public string Id
        {
          get { return _id; }
          set { _id = value; }
        }
        string _title;

        [DataMember(Name = "title")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        public DailyMileEvent()
        {

        }


    }
}
