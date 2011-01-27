using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VengSoft.DailyMileAPIWrapper
{
    [DataContract]
    public class DailyMileWorkOut
    {
        string _duration;

        [DataMember(Name = "duration", EmitDefaultValue=false, Order=2)]
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        string _title;
        [DataMember(Name = "title", EmitDefaultValue=false)]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        string _felt;
        [DataMember(Name = "felt", EmitDefaultValue=false)]
        public string Felt
        {
            get { return _felt; }
            set { _felt = value; }
        }


        [DataMember(Name = "activity_type", EmitDefaultValue=false, Order=1)]
        string _activity_type;
        
        public enumActivityType Activity_type
        {
            get 
            {
                try
                {
                   
                    return (enumActivityType)Enum.Parse(typeof(enumActivityType), _activity_type.Replace(' ', '_'), true);
                }
                catch (Exception)
                {
                    return enumActivityType.Unknown;
                }

                
            }
            set 
            {
                _activity_type = Enum.GetName(typeof(enumActivityType), value).Replace('_',' '); 
            }
        }


        DailyMileDistance _distance;
        [DataMember(Name = "distance", EmitDefaultValue=false)]
        public DailyMileDistance Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }



        public string Pace
        {
            get
            {
                if (_distance != null)
                {
                    double dur = Convert.ToDouble(_duration);
                    double dis = Convert.ToDouble(_distance.Value);
                    double calc = ((dur / dis));


                    int hour = (int)(((calc) / 60) / 60);
                    int min = (int)(calc / 60) % 60;
                    int sec = (int)calc % 60;

                    if (_distance.Units == "miles")
                        return string.Format("{0}:{1}:{2} per {3}.", hour, min, sec, "Mile");
                    else
                        return string.Format("{0}:{1}:{2} per {3}.", hour, min, sec, "Kilometer");
                }

                return string.Empty;
            }
        }

        public DailyMileWorkOut()
        {

        }
    }
}
