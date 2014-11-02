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
    public partial class QuotationinfoForm : MEMS.Client.Common.BaseinfoForm
    {
        private int m_qid;
        public QuotationinfoForm(frmmodetype type)
        {
            InitializeComponent();
            base.formmode = type;
        }
        public QuotationinfoForm(frmmodetype type, int qid)
        {
            InitializeComponent();
            base.formmode = type;
            m_qid = qid;
        }
    }
}
