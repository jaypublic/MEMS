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
//using MEMS.Client.CRM.CRMService;

namespace MEMS.Client.MRP
{
    public partial class UseApplyForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public UseApplyForm()
        {
            InitializeComponent();
        }

        protected override void SearchObject()
        {
            this.gcApplyUseOrders.DataSource = _Proxy.GetApplyUseOrders(this.ApplyStartDateEdit.DateTime.ToString("yyyy-MM-dd"), this.ApplyEndDateEdit.DateTime.ToString("yyyy-MM-dd"), this.ApplyUseDeptComboBox.SelectedValue.ToString(), Convert.ToInt16(this.ApplyUseTypeComboBox.SelectedValue), this.SaleNoTextBox.Text, this.ProductOrderTextBox.Text, this.ApplyUseNoTextBox.Text);
            this.gvApplyUseOrders.RefreshData();
        }

        protected override void AddObject()
        {
            var frm = new ApplyUseOrderInfoForm(Common.frmmodetype.add, null);
            refreshFormData(frm);
        }

        protected override void EditObject()
        {
            if (this.gvApplyUseOrders.GetFocusedRow() != null)
            {
                T_ApplyUseOrder applyUseOrder = this.gvApplyUseOrders.GetFocusedRow() as T_ApplyUseOrder;

                var frm = new ApplyUseOrderInfoForm(Common.frmmodetype.edit, applyUseOrder);
                refreshFormData(frm);
            }
        }

        protected override void DeleteObject()
        {
            if (this.gvApplyUseOrders.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvApplyUseOrders.GetFocusedRow() as T_PurchaseOrder;
                _Proxy.DeletePO(po.pono);
                this.gvApplyUseOrders.DeleteRow(this.gvApplyUseOrders.FocusedRowHandle);
                this.gvApplyUseOrders.RefreshData();
            }
        }

        private void gvproduct_DoubleClick(object sender, EventArgs e)
        {
            EditObject();
        }

        protected override void FormLoad()
        {
            base.FormLoad();
            DateTime now = DateTime.Now;
            DateTime lastMonth = now.AddMonths(-1);
            this.ApplyStartDateEdit.EditValue = new DateTime(lastMonth.Year, lastMonth.Month, lastMonth.Day);
            this.ApplyEndDateEdit.EditValue = new DateTime(now.Year, now.Month, now.Day);


            #region ApplyUseTypeComboBox
            this.ApplyUseTypeComboBox.DataSource = EnumTool.GetDataSource(typeof(ApplyUseTypes));
            this.ApplyUseTypeComboBox.SelectedIndex = 1;
            #endregion

            #region ApplyUseDeptComboBox
            DataTable deptDataTable = _Proxy.GetAllDepts();
            DataRow allDeptRow = deptDataTable.NewRow();
            allDeptRow["Code"] = "all";
            allDeptRow["Desc"] = "所有";
            deptDataTable.Rows.InsertAt(allDeptRow, 0);

            this.ApplyUseDeptComboBox.DataSource = deptDataTable;
            this.ApplyUseDeptComboBox.SelectedIndex = 0;
            #endregion

            this.gvApplyUseTypeEdit.DataSource = EnumTool.GetDataSource(typeof(ApplyUseTypes));
        }
    }
}
