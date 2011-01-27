using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileLocation
    {
        string _name;

        [DataMember(Name = "name", EmitDefaultValue=false)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DailyMileLocation()
        {

        }
    }
}
