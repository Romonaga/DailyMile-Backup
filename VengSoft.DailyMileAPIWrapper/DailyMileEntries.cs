using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileEntries
    {

        List<DailyMileEntry> _entries;

        
        [DataMember(Name = "entries")]
        public List<DailyMileEntry> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        


        public DailyMileEntries()
        {
            _entries = new List<DailyMileEntry>();
        }
    }
}
