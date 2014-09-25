using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MEMS.Client.Common
{
    public class FormFactory
    {
        /// <summary>
        /// 创建mdi子窗体
        /// </summary>
        /// <param name="parentmain">父窗体</param>
        /// <param name="frmtype">子窗体类型</param>
        public static void LoadForm(Form parentmain, Type frmtype)
        {
            Boolean isNewForm = true;
            foreach (var childfrm in parentmain.MdiChildren)
            {
                if (childfrm.GetType() == frmtype)
                {
                    isNewForm = false;
                    childfrm.Activate();
                    break;
                }
            }
            if (isNewForm)
            {
                CreateForm(parentmain, frmtype);
            }
        }
        /// <summary>
        /// 创建模式窗体
        /// </summary>
        /// <param name="frmtype">窗体类型</param>
        public static Form LoadForm(Type frmtype)
        {
            Assembly ass = Assembly.LoadFrom(frmtype.Module.Name);
            Form frm = (Form)ass.CreateInstance(frmtype.ToString());
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            return frm;
        }
        private static void CreateForm(Form mform, Type frmtype)
        {
            Assembly ass = Assembly.LoadFrom(frmtype.Module.Name);
            Form frm = (Form)ass.CreateInstance(frmtype.ToString());
            frm.MdiParent = mform;
            frm.Show();
        }
    }
}
