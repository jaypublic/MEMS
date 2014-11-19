using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Enums;
using MEMS.Client.MRP.Proxy;
using MEMS.Client.MRP.Toolkit;
using MEMS.Client.MRP.UserWindows;

namespace MEMS.Client.MRP
{
    public partial class POPayListForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public POPayListForm()
        {
            InitializeComponent();
        }

        protected override void SearchObject()
        {
            this.gcPO.DataSource = _Proxy.GetPOPayList(this.ApplyStartDateEdit.DateTime.ToString("yyyy-MM-dd"), this.ApplyEndDateEdit.DateTime.ToString("yyyy-MM-dd"), Convert.ToInt16(this.POTypeComboBox.SelectedValue), this.SaleNoTextBox.Text, this.ApplyDeptComboBox.SelectedValue.ToString());
            this.gvPO.RefreshData();
            gvPO_FocusedRowChanged(null, null);
        }
        
        protected override void custom1()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                var frm = new POPayInfoForm(po);
                refreshFormData(frm);
                gvPO_FocusedRowChanged(null, null);
            }
        }

        protected override void custom2()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                var frm = new POPayInfoForm(po);
                refreshFormData(frm);
            }
        }

        private void gvproduct_DoubleClick(object sender, EventArgs e)
        {
            custom2();
        }

        protected override void FormLoad()
        {
            base.FormLoad();
            DateTime now = DateTime.Now;
            DateTime lastMonth = now.AddMonths(-1);
            this.ApplyStartDateEdit.EditValue = new DateTime(lastMonth.Year, lastMonth.Month, lastMonth.Day);
            this.ApplyEndDateEdit.EditValue = new DateTime(now.Year, now.Month, now.Day);


            #region POTypeComboBox
            //DataTable poTypeDataTable = EnumTool.GetDataSource(typeof(POTypes));
            //DataRow allPoTypeRow = poTypeDataTable.NewRow();
            //allPoTypeRow["Code"] = "all";
            //allPoTypeRow["Desc"] = "所有";
            //poTypeDataTable.Rows.InsertAt(allPoTypeRow, 0);

            this.POTypeComboBox.DataSource = EnumTool.GetDataSource(typeof(POTypes));
            this.POTypeComboBox.SelectedIndex = 1;
            #endregion

            #region ApplyDeptComboBox
            DataTable deptDataTable = _Proxy.GetAllDepts();
            DataRow allDeptRow = deptDataTable.NewRow();
            allDeptRow["Code"] = "all";
            allDeptRow["Desc"] = "所有";
            deptDataTable.Rows.InsertAt(allDeptRow, 0);

            this.ApplyDeptComboBox.DataSource = deptDataTable;
            this.ApplyDeptComboBox.SelectedIndex = 0;
            #endregion

            this.gvPOTypeEdit.DataSource = EnumTool.GetDataSource(typeof(POTypes));
            this.gvArrivalstatusEdit.DataSource = EnumTool.GetDataSource(typeof(ArrivalStatus));
            this.gvPOStatusEdit.DataSource = EnumTool.GetDataSource(typeof(POStatus));
            this.gvPaymentStatusEdit.DataSource = EnumTool.GetDataSource(typeof(PaymentStatus));

            this.barAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            this.barbtn1.Glyph = global::MEMS.Client.MRP.Properties.Resources.currency_16x16;
            this.barbtn1.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.currency_32x32;
            this.barbtn1.Caption = "付款";
            this.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.barbtn2.Glyph = global::MEMS.Client.MRP.Properties.Resources.show_16x16;
            this.barbtn2.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.show_32x32;
            this.barbtn2.Caption = "查看";
            this.barbtn2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void gvPO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (this.gvPO.GetFocusedRow() != null)
            //{
            //    T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;
            //    switch (po.paymentstatus)
            //    {
            //        case (int)PaymentStatus.未付款:
            //            this.barbtn1.Enabled = true;
            //            break;

            //        default:
            //            this.barbtn1.Enabled = false;
            //            break;
            //    }
            //}
        }
    }
}
