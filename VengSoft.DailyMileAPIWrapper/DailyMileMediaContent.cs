using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{

    [DataContract]
    public class DailyMileMediaContent
    {
        string _type;

        [DataMember(Name = "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        string _height;

        [DataMember(Name = "height")]
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }
        string _width;

        [DataMember(Name = "width")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
        string _url;

        [DataMember(Name = "url")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }


        public DailyMileMediaContent()
        {

        }
    }
}
