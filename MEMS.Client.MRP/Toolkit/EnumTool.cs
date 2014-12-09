using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MEMS.Client.MRP.Toolkit
{
    public class EnumTool
    {
        public static DataTable GetDataSource(Type enumType)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Desc");
            
            Array enumValues = Enum.GetValues(enumType);
            foreach (int value in enumValues)
            {
                DataRow row = dt.NewRow();
                row["Code"] = value;
                row["Desc"] = Enum.GetName(enumType, value);
                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
