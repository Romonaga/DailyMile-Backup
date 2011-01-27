using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VengSoft.DailyMileAPIWrapper
{
    public class QueryResponseHolder
    {
        string _key;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public QueryResponseHolder(string key, string value)
        {
            _key = key;
            _value = value;

        }

        public QueryResponseHolder()
        {

        }
    }
}
