using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;



namespace VengSoft.DailyMileAPIWrapper
{
	public class Serializers
	{
		public static byte[] Serialize(object sourceObject)
		{
			BinaryFormatter formatter;

			try
			{
				using (MemoryStream transStream = new MemoryStream())
				{
					formatter = new BinaryFormatter();
					formatter.Serialize(transStream, sourceObject);
					return transStream.GetBuffer();
				}
			}
			catch (Exception e)
			{
				throw new VSException(e.Message + ":" + e.Source);
			}


		}

		public static string SerializeToXML(object sourceObject)
		{
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(sourceObject.GetType());
				using (MemoryStream transStream = new MemoryStream())
				{
					xmlSerializer.Serialize(transStream, sourceObject);
					return Encoding.ASCII.GetString(transStream.ToArray());
				}
			}
			catch (Exception e)
			{
				throw new VSException(e.Message + ":" + e.Source);
			}

		}


		public static object DeSerialize(byte[] source)
		{
			MemoryStream sStream;
			BinaryFormatter formatter;

			try
			{
				using (sStream = new MemoryStream(source))
				{
					formatter = new BinaryFormatter();
					return formatter.Deserialize(sStream);
				}
			}
			catch (Exception e)
			{
				throw new VSException(e.Message + ":" + e.Source);
			}

		}

		public static object DeSerializeXML(Type objType, string xml)
		{

			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(objType);
				MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(xml));
				return xmlSerializer.Deserialize(ms);

			}
			catch (Exception e)
			{
				throw new VSException(e.Message + ":" + e.Source);
			}
		}

		public static object RawDeserialize(byte[] rawdatas, Type anytype)
		{
			object retobj;
			try
			{
				int rawsize = Marshal.SizeOf(anytype);
				if (rawsize > rawdatas.Length)
					return null;
				IntPtr buffer = Marshal.AllocHGlobal(rawsize);
				Marshal.Copy(rawdatas, 0, buffer, rawsize);
				retobj = Marshal.PtrToStructure(buffer, anytype);
				Marshal.FreeHGlobal(buffer);
			}
			catch (Exception e)			
			{
				throw new VSException(e.Message + ":" + e.Source);
			}
			return retobj;
		}


		public static byte[] RawSerialize(object anything)
		{
			byte[] rawdatas;
			try
			{
				int rawsize = Marshal.SizeOf(anything.GetType());
				IntPtr buffer = Marshal.AllocHGlobal(rawsize);
				Marshal.StructureToPtr(anything, buffer, false);
				rawdatas = new byte[rawsize];
				Marshal.Copy(buffer, rawdatas, 0, rawsize);
				Marshal.FreeHGlobal(buffer);
			}
			catch (Exception e)
			{
				throw new VSException(e.Message + ":" + e.Source);
			}
			return rawdatas;
		}
	}
}
