using MEMS.Client.Sale.SaleService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.DB.ExtModels;
using MEMS.DB.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using MEMS.Client.Common;

namespace MEMS.Client.Sale
{
    public partial class SaleOrder4RecieveListForm : MEMS.Client.Common.BaseListForm
    {
        SaleServiceClient m_SaleClient = new SaleServiceClient();
        public SaleOrder4RecieveListForm()
        {
            InitializeComponent();
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            gcSaleOrder.Dock = DockStyle.Fill;
            barAdd.Visibility = BarItemVisibility.Never;
            barEdit.Visibility = BarItemVisibility.Never;
            barDelete.Visibility = BarItemVisibility.Never;
            barbtn1.Visibility = BarItemVisibility.Always;
            barbtn1.LargeImageIndex = 17;
            barbtn1.Caption = "收款";
        }
        protected override void SearchObject()
        {
            var saleno = this.txtSaleNo.Text;
            DateTime aftdate = dateEdit1.DateTime;
            DateTime bfedate = dateEdit2.EditValue != null ? dateEdit2.DateTime : new DateTime(2100, 1, 1);
            var saleOrderList = m_SaleClient.getSaleOrderList(saleno, aftdate, bfedate);
            this.gcSaleOrder.DataSource = saleOrderList;
        }
        protected override void custom1()
        {
            if (gvSaleOrder.DataRowCount > 0)
            {
                int soid = (int)gvSaleOrder.GetFocusedRowCellValue("so.id");
                var frm = new SaleRecieveinfoForm(frmmodetype.custom, soid);
                frm.ShowDialog();
            }
        }
    }
}
