using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.CRM.CRMService;

namespace MEMS.Client.CRM
{
    public partial class QuotationListForm : MEMS.Client.Common.BaseListForm
    {
        private CRMServiceClient m_csclient = new CRMServiceClient();

        public QuotationListForm()
        {
            InitializeComponent();
        }

        protected override void SearchObject()
        {
            var qlst = m_csclient.getQuotationList();
            gcquotation.DataSource = qlst;
            
        }

        protected override void AddObject()
        {
            
        }

        protected override void EditObject()
        {
            
        }

        protected override void DeleteObject()
        {
            
        }


    }
}
