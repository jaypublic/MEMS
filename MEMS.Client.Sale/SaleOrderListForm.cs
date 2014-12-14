using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Sale.SaleService;
using DevExpress.XtraEditors;
using MEMS.DB.ExtModels;
using MEMS.DB.Models;

namespace MEMS.Client.Sale
{
    public partial class SaleOrderListForm : MEMS.Client.Common.BaseListForm
    {
        SaleServiceClient m_SaleClient = new SaleServiceClient();
        public SaleOrderListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var saleno = this.txtSaleNo.Text;
            DateTime aftdate = dateEdit1.DateTime;
            DateTime bfedate = dateEdit2.EditValue != null ? dateEdit2.DateTime : new DateTime(2100, 1, 1);
            var saleOrderList = m_SaleClient.getSaleOrderList(saleno, aftdate, bfedate);
            this.gcSaleOrder.DataSource = saleOrderList;
        }
        protected override void AddObject()
        {
            var frm = new SaleOrderinfoForm(Common.frmmodetype.add);
            refreshFormData(frm);
        }
        protected override void EditObject()
        {
            if (gvSaleOrder.DataRowCount > 0)
            {
                var soid = (int)gvSaleOrder.GetFocusedRowCellValue("so.id");
                var frm = new SaleOrderinfoForm(Common.frmmodetype.edit, soid);
                refreshFormData(frm);
            }
        }
        protected override void DeleteObject()
        {
            if (gvSaleOrder.DataRowCount > 0)
            {
                var soid = (int)gvSaleOrder.GetFocusedRowCellValue("so.id");
                var frm = new SaleOrderinfoForm(Common.frmmodetype.delete, soid);
                refreshFormData(frm);
            }
        }
        protected override void FormLoad()
        {
            DisPlayEnum.BindEnumDS(lkupOrderState, typeof(orderState));
            base.FormLoad();
        }

        private void gvSaleOrder_DoubleClick(object sender, EventArgs e)
        {
            EditObject();
        }

    }

    
}
