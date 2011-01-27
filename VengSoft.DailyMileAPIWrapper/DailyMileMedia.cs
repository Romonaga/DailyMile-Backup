using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{

    [DataContract]
    public class DailyMileMedia
    {
        DailyMileMediaPreview _preview;

        [DataMember(Name = "preview")]
        public DailyMileMediaPreview Preview
        {
            get { return _preview; }
            set { _preview = value; }
        }
        DailyMileMediaContent _content;

        [DataMember(Name = "content")]
        public DailyMileMediaContent Content
        {
            get { return _content; }
            set { _content = value; }
        }


        public DailyMileMedia()
        {

        }
    }
}
