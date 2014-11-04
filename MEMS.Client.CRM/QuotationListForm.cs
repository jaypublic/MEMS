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
        protected override void FormLoad()
        {
            base.FormLoad();
            this.cmbCustomer.Properties.Items.Add("*");
            var customerlst = m_csclient.getCustomerList();
            cmbCustomer.Tag = customerlst;
            foreach (var c in customerlst)
            {
                cmbCustomer.Properties.Items.Add(c.customername);
            }
            cmbCustomer.SelectedIndex = 0;
        }
        protected override void SearchObject()
        {
            var quno = this.txtQuNo.Text;
            T_Customer[] customerlst=(T_Customer[])cmbCustomer.Tag;
            int customerid = cmbCustomer.SelectedIndex == 0 ? 0 : customerlst[cmbCustomer.SelectedIndex - 1].id;
            DateTime aftdate = dateEdit1.EditValue != null ? dateEdit1.DateTime : new DateTime(2000, 1, 1);
            DateTime bfedate = dateEdit2.EditValue != null ? dateEdit2.DateTime : new DateTime(2100, 1, 1);
            var qlst = m_csclient.getQuotationListbyP(quno, customerid, aftdate, bfedate);
            gcquotation.DataSource = qlst;
            
        }

        protected override void AddObject()
        {
            var frm = new QuotationinfoForm(Common.frmmodetype.add);
            base.refreshFormData(frm);
        }

        protected override void EditObject()
        {
            if (gvquotation.DataRowCount > 0)
            {
                var qid = (int)gvquotation.GetFocusedRowCellValue("id");
                var frm = new QuotationinfoForm(Common.frmmodetype.edit, qid);
                base.refreshFormData(frm);
            }
        }

        protected override void DeleteObject()
        {
            if (gvquotation.DataRowCount > 0)
            {
                var qid = (int)gvquotation.GetFocusedRowCellValue("id");
                var frm = new QuotationinfoForm(Common.frmmodetype.delete, qid);
                base.refreshFormData(frm);
            }
        }


    }
}
