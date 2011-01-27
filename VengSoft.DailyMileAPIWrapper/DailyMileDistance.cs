using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileDistance
    {
        string _units;


        double _value;

        [DataMember(Name = "value", Order=1)]
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [DataMember(Name = "units", Order=2)]
        public string Units
        {
            get { return _units; }
            set { _units = value; }
        }


       


        public DailyMileDistance()
        {

        }
    }
}
