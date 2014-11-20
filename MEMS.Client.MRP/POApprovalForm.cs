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
    public partial class POApprovalForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public POApprovalForm()
        {
            InitializeComponent();
        }

        protected override void SearchObject()
        {
            this.gcPO.DataSource = _Proxy.GetPOApprovalList(this.ApplyStartDateEdit.DateTime.ToString("yyyy-MM-dd"), this.ApplyEndDateEdit.DateTime.ToString("yyyy-MM-dd"), Convert.ToInt16(this.POTypeComboBox.SelectedValue), this.SaleNoTextBox.Text, this.ApplyDeptComboBox.SelectedValue.ToString());
            this.gvPO.RefreshData();
            gvPO_FocusedRowChanged(null, null);
        }
        

        protected override void custom1()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                if (po.postatus == (int)POStatus.提交未审批)
                {
                    ApprovalWindow window = new ApprovalWindow();
                    window.FormClosed += (o, e) =>
                    {
                        if (window.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            if (window.IsAccept)
                            {
                                po.postatus = (int)POStatus.已审批通过;
                            }
                            else
                            {
                                po.postatus = (int)POStatus.审批驳回;
                            }

                            po.approval = Global.UserNo;
                            po.approvaldesc = Global.UserName;
                            po.approvaldate = DateTime.Now.ToString("yyyy-MM-dd");
                            po.approvalremark = window.ApprovalRemark;

                            _Proxy.UpdatePO(po);
                            this.gvPO.RefreshData();
                            gvPO_FocusedRowChanged(null, null);
                        }
                    };

                    window.ShowDialog();
                }
            }
        }

        protected override void custom2()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                if ((po.postatus == (int)POStatus.已审批通过 || po.postatus == (int)POStatus.审批驳回) && po.arrivalstatus == (int)ArrivalStatus.未到货)
                {
                    po.postatus = (int)POStatus.提交未审批;
                    po.approval = string.Empty;
                    po.approvaldesc = string.Empty;
                    po.approvaldate = null;
                    po.approvalremark = string.Empty;

                    _Proxy.UpdatePO(po);
                    this.gvPO.RefreshData();
                    gvPO_FocusedRowChanged(null, null);
                }
            }
        }

        protected override void custom3()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                var frm = new POInfoForm(po);
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

            this.barbtn1.Glyph = global::MEMS.Client.MRP.Properties.Resources.showtestreport_16x16;
            this.barbtn1.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.showtestreport_32x32;
            this.barbtn1.Caption = "审批";
            this.barbtn1.Enabled = false;
            this.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.barbtn2.Glyph = global::MEMS.Client.MRP.Properties.Resources.showtestreport_16x16;
            this.barbtn2.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.showtestreport_32x32;
            this.barbtn2.Caption = "撤销审批";
            this.barbtn2.Enabled = false;
            this.barbtn2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.barbtn3.Glyph = global::MEMS.Client.MRP.Properties.Resources.show_16x16;
            this.barbtn3.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.show_32x32;
            this.barbtn3.Caption = "查看";
            this.barbtn3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void gvPO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;
                switch (po.postatus)
                {
                    case (int)POStatus.提交未审批:
                        this.barbtn1.Enabled = true;
                        this.barbtn2.Enabled = false;
                        break;

                    case (int)POStatus.已审批通过:
                        this.barbtn1.Enabled = false;
                        if (po.arrivalstatus == (int)ArrivalStatus.未到货)
                        {
                            this.barbtn2.Enabled = true;
                        }
                        else
                        {
                            this.barbtn2.Enabled = false;
                        }
                        break;

                    case (int)POStatus.审批驳回:
                        this.barbtn1.Enabled = false;
                        this.barbtn2.Enabled = true;
                        break;

                    default:
                        this.barbtn1.Enabled = false;
                        this.barbtn2.Enabled = false;
                        break;
                }
            }
        }
    }
}
