using DevExpress.XtraBars;
using MEMS.Client.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MEMS.Client.CRM
{
    public partial class ProductPriceForm : MEMS.Client.Common.BaseinfoForm
    {
        private int m_pid;
        public ProductPriceForm(int productid)
        {
            InitializeComponent();
            m_pid = productid;
            base.formmode = frmmodetype.edit;
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            this.ribbonPageGroup2.Visible = true;
            this.barbtn1.Visibility = BarItemVisibility.Always;
            this.barbtn1.Caption = "创建版本";
        }
    }
}
