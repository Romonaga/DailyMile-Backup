using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

using VengSoft.Collections;
using VengSoft.DailyMileAPIWrapper;


namespace VengSoft.DMBackUp
{
    public class Helpers
    {
        public static DailyMileEntries MergeEntries(string fileName, DailyMileEntries entries)
        {

            BindingListView<DailyMileEntry> fileentries;
            BindingListView<DailyMileEntry> downloadedEntries;

            DailyMileEntries murgedEntries;

            murgedEntries = new DailyMileEntries();


            try
            {


                //convert downloaded entries to BLV
                downloadedEntries = new BindingListView<DailyMileEntry>(entries.Entries);

                //Read stored collection

                fileentries = new BindingListView<DailyMileEntry>(DailyMileAPI.GetStoredEntries(fileName).Entries);

                foreach (DailyMileEntry entry in downloadedEntries)
                {
                    if (fileentries != null)
                    {
                        if (fileentries.Exists("ID", entry.ID) == true)
                        {
                            fileentries.RemoveItems("ID", entry.ID);
                        }
                    }

                    fileentries.Add(entry);
                }


                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    using (BinaryWriter binWriter = new BinaryWriter(fs))
                    {
                        murgedEntries = new DailyMileEntries();
                        fileentries.SortDirection = ListSortDirection.Descending;
                        fileentries.SortFields = "ID";
                        murgedEntries.Entries = fileentries.GetList();

                        binWriter.Write(SerializersJSON.Serialize<DailyMileEntries>(murgedEntries));
                    }
                }


            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("MergeEntries FileName({0}) Exception {1}", fileName, ex.Message));
            }

            return murgedEntries;
        }


        public static DailyMileEntries MergeEntry(string fileName, DailyMileEntry entry)
        {

            BindingListView<DailyMileEntry> fileentries;
            DailyMileEntries murgedEntries;

            try
            {

                fileentries = new BindingListView<DailyMileEntry>(DailyMileAPI.GetStoredEntries(fileName).Entries);
                if (fileentries.Exists("ID", entry.ID) == true)
                {
                    fileentries.RemoveItems("ID", entry.ID);
                }
                fileentries.Add(entry);

                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    using (BinaryWriter binWriter = new BinaryWriter(fs))
                    {
                        murgedEntries = new DailyMileEntries();
                        fileentries.SortDirection = ListSortDirection.Descending;
                        fileentries.SortFields = "ID";
                        murgedEntries.Entries = fileentries.GetList();

                        binWriter.Write(SerializersJSON.Serialize<DailyMileEntries>(murgedEntries));
                    }
                }


            }
            catch (VSException ve)
            {
                throw ve;
            }
            catch (System.Exception ex)
            {
                throw new VSException(string.Format("MergeEntries FileName({0}) Exception {1}", fileName, ex.Message));
            }

            return murgedEntries;
        }

    }
}
