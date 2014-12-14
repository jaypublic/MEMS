using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MEMS.Client.Common
{
    /// <summary>
    /// LookUpExt控件的扩展类
    /// </summary>
    public static class LookUpExt
    {
        /// <summary>
        /// 扩展方法，绑定数据源
        /// </summary>
        /// <typeparam name="T">数据源类型</typeparam>
        /// <param name="lkp"></param>
        /// <param name="ds">数据源</param>
        /// <param name="valueMember">值field</param>
        /// <param name="displayMember">显示field</param>
        public static void ExtBindingDataSource<T>(this LookUpEdit lkp, List<T> ds, string valueMember, string displayMember)
        {
            lkp.Properties.DataSource = ds;
            lkp.Properties.ValueMember = valueMember;
            lkp.Properties.DisplayMember = displayMember;
            lkp.Properties.ShowFooter = false;
            lkp.Properties.ShowHeader = false;
            lkp.Properties.NullText = "";
            lkp.Properties.DropDownRows = ds.Count;
            var colKey = new LookUpColumnInfo(valueMember, 0, "id");
            colKey.Visible = false;
            var colText = new LookUpColumnInfo(displayMember, 50, "name");
            lkp.Properties.Columns.AddRange(new LookUpColumnInfo[] { colKey, colText });
            lkp.Properties.PopupFormMinSize = new Size(50, 10);
            lkp.Properties.PopupWidth = lkp.Width - 2;
        }
    }
}
