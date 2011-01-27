using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;



namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileFriends
    {
        List<DailyMileFriend> _friends;

        [DataMember(Name = "friends")]
        public List<DailyMileFriend> Friends
        {
            get { return _friends; }
            set { _friends = value; }
        }

        public DailyMileFriends()
        {

        }
    }
}
