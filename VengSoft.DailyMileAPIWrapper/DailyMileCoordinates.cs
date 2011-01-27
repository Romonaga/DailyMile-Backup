using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;



namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileCoordinates
    {
        string _coordinates;

        [DataMember]
        public string Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }
        
        
    }
}
