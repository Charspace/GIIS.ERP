using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.IO;
using CHARS.HR.COMMON.PL;
using System.Text.RegularExpressions;
using CHARS.HR.COMMON.BLL;
using System.Drawing;




namespace CHARS.HR.COMMON.General
{
    public class Utility
    {
        public Utility()
        {

        }
        public List<T> test(DataTable dt)
        {
            var convertedList = (from rw in dt.AsEnumerable()
                                 select new MyObj()
                                 {
                                     ID = Convert.ToInt32(rw["ID"]),
                                     Name = Convert.ToString(rw["Name"])
                                 }).ToList();
            return convertedList;
        }

        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var row in table.AsEnumerable())
                {
                    var obj = row.ToObject<T>();
                    list.Add(obj);
                }
                return list;
            }
            catch { return null; }
        }
    }
}