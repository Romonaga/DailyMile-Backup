using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


//"geo":{"type":"Point","coordinates":["-88.0012878","41.8058481"]}


namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileGEO
    {
        string _type;
        
        [DataMember(Name = "type",EmitDefaultValue=false)]
        public string CoordType
        {
            get  { return _type; }
            set { _type = value; }
        }

        string[] _coordinates;
        [DataMember(Name = "coordinates", EmitDefaultValue=false)]
        public string[] Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }


        public DailyMileGEO()
        {

        }

        //List<DailyMileCoordinates> _coordinates;

        //[DataMember(Name = "coordinates")]
        //public List<DailyMileCoordinates> Coordinates
        //{
        //    get { return _coordinates; }
        //    set { _coordinates = value; }
        //}



    }
}
