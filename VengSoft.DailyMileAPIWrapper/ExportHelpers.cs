using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using VengSoft.Utilities.Serialize;

namespace VengSoft.DailyMileAPIWrapper
{
    public class ExportHelpers
    {
        public static int ExportToXML(string entriesFileName, string exportFileName, string user)
        {

            int retVal = 0;

            try
            {
                using (FileStream fs = new FileStream(exportFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (BinaryWriter binWriter = new BinaryWriter(fs))
                    {
                        DailyMileEntries dmEntries;
                        dmEntries = DailyMileAPI.GetStoredEntries(entriesFileName);

                        string xmlData = Serializers.SerializeToXML(dmEntries);
                        binWriter.Write(System.Text.Encoding.UTF8.GetBytes(xmlData));
                        retVal = dmEntries.Entries.Count;
                    }
                }
               
            }
            catch (System.Exception ex)
            {
                throw new VengSoft.Utilities.Exceptions.VSException(string.Format("ExportToXML EntryFileName({0}) ExportFileName({1}) User({2})", entriesFileName, exportFileName, user));
            }

            return retVal;
        }
    }
}
