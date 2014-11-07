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
    public partial class SelectProForm : MEMS.Client.Common.BaseinfoForm
    {
        int m_customerid;
        CRMService.CRMServiceClient m_crmclient = new CRMService.CRMServiceClient();
        public SelectProForm(int customerid)
        {
            InitializeComponent();
            m_customerid = customerid;
        }
        protected override void FormLoad()
        {
            var rs = m_crmclient.getProductList();
            gcProduct.DataSource = rs;
        }
    }
}
