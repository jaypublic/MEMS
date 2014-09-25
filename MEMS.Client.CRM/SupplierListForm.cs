using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Common;
using MEMS.Client.CRM.CRMService;

namespace MEMS.Client.CRM
{
    public partial class SupplierListForm : BaseListForm
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var splyno = txtsplyno.Text;
            var splyname = txtsplyname.Text;
            CRMServiceClient client = new CRMServiceClient();
            var slist = client.getSupplierList(splyno, splyname);
            this.gcsupplier.DataSource = slist;
        }
        protected override void AddObject()
        {
            var sinfofrm = new SupplierinfoForm(frmmodetype.add);
            refreshFormData(sinfofrm);
        }
        protected override void EditObject()
        {
            if ( this.gvsupplier.DataRowCount > 0)
            {
                int idx = (int)gvsupplier.GetFocusedRowCellValue("id");
                var sinfofrm = new SupplierinfoForm(frmmodetype.edit, idx);
                refreshFormData(sinfofrm);
            }
        }

        protected override void DeleteObject()
        {
            if (gvsupplier.DataRowCount > 0)
            {
                int idx = (int)gvsupplier.GetFocusedRowCellValue("id");
                var sinfofrm = new SupplierinfoForm(frmmodetype.delete, idx);
                refreshFormData(sinfofrm);
            }
        }

        private void gvsupplier_DoubleClick(object sender, EventArgs e)
        {
            EditObject();
        }
    }
}
