using System.Text;


using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;


namespace VengSoft.DailyMileAPIWrapper
{
    public class SerializersJSON
    {
        public static T Deserialise<T>(string json)
        {

            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serialiser = new DataContractJsonSerializer(typeof(T));
                return (T)serialiser.ReadObject(ms);
            }


        }

        public static T Deserialise<T>(byte[] json)
        {

            using (MemoryStream ms = new MemoryStream(json))
            {
                DataContractJsonSerializer serialiser = new DataContractJsonSerializer(typeof(T));
                return (T)serialiser.ReadObject(ms);
            }


        }

        public static byte[] Serialize<T>(T obj)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                serializer.WriteObject(ms, obj);
                return ms.ToArray();
            }
        }

    }
}
