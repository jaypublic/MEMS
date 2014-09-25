using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MEMS.Client.Common;
using MEMS.Client.CRM.CRMService;

namespace MEMS.Client.CRM
{
    public partial class CustomerListForm : MEMS.Client.Common.BaseListForm
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var companyno = txt_customerno.Text;
            var companyname = txt_customername.Text;
            var companysname = txt_sname.Text;
            CRMServiceClient client = new CRMServiceClient();
            List<T_Customer> clist = new List<T_Customer>(client.getCustomerListbyP(companyno,companyname,companysname));
            this.gccustomer.DataSource = clist;
        }
        protected override void AddObject()
        {
            var cinfofrm = new CustomerinfoForm(frmmodetype.add);
            refreshFormData(cinfofrm);
        }
        protected override void EditObject()
        {
            if (gvcustomer.DataRowCount > 0)
            {
                int idx = (int)gvcustomer.GetFocusedRowCellValue("id");
                var cinfofrm = new CustomerinfoForm(idx, frmmodetype.edit);
                refreshFormData(cinfofrm);
            }
        }
        
        protected override void DeleteObject()
        {
            if (gvcustomer.DataRowCount > 0)
            {
                int idx = (int)gvcustomer.GetFocusedRowCellValue("id");
                var cinfofrm = new CustomerinfoForm(idx, frmmodetype.delete);
                refreshFormData(cinfofrm);
            }
        }

        private void gvcustomer_DoubleClick(object sender, EventArgs e)
        {
            EditObject();
        }
    }
}
