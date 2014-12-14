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
    public partial class POListForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public POListForm()
        {
            InitializeComponent();
        }

        protected override void SearchObject()
        {
            this.gcPO.DataSource = _Proxy.GetPOList(this.ApplyStartDateEdit.DateTime.ToString("yyyy-MM-dd"), this.ApplyEndDateEdit.DateTime.ToString("yyyy-MM-dd"), Convert.ToInt16(this.POTypeComboBox.SelectedValue), this.SaleNoTextBox.Text, this.ApplyDeptComboBox.SelectedValue.ToString());
            this.gvPO.RefreshData();
            gvPO_FocusedRowChanged(null, null);
        }

        protected override void AddObject()
        {
            var frm = new POInfoForm(Common.frmmodetype.add, null);
            refreshFormData(frm);
            gvPO_FocusedRowChanged(null, null);
        }

        protected override void EditObject()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;
                if (po.postatus == (int)POStatus.编制 || po.postatus == (int)POStatus.审批驳回)
                {
                    var frm = new POInfoForm(Common.frmmodetype.edit, po);
                    refreshFormData(frm);
                    gvPO_FocusedRowChanged(null, null);
                }
                else
                {
                    MessageBox.Show("非编制状态下不能修改采购单");
                }
            }
        }

        protected override void DeleteObject()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;
                _Proxy.DeletePO(po.pono);
                this.gvPO.DeleteRow(this.gvPO.FocusedRowHandle);
                this.gvPO.RefreshData();
                gvPO_FocusedRowChanged(null, null);
            }
        }

        protected override void custom1()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                if (po.postatus == (int)POStatus.编制)
                {
                    po.postatus = (int)POStatus.提交未审批;
                    po.sendapprovaldate = DateTime.Now.ToString("yyyy-MM-dd");

                    _Proxy.UpdatePO(po);
                    this.gvPO.RefreshData();
                    gvPO_FocusedRowChanged(null, null);
                }
            }
        }

        protected override void custom2()
        {
            if (this.gvPO.GetFocusedRow() != null)
            {
                T_PurchaseOrder po = this.gvPO.GetFocusedRow() as T_PurchaseOrder;

                if (po.postatus == (int)POStatus.已审批通过)
                {
                    ArrivalWindow window = new ArrivalWindow();
                    window.FormClosed += (o, e) =>
                    {
                        if (window.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            if (window.ArrivalStatus == (int)ArrivalStatus.未到货 && po.paymentstatus != (int)PaymentStatus.未付款)
                            {
                                MessageBox.Show("在付款状态下,不能将PO设置为未到货状态");
                                return;
                            }

                            po.arrivalstatus = window.ArrivalStatus;
                            po.actualarrivaldate = window.SelectedDate;
                            po.arrivalremark = window.Remark;

                            _Proxy.UpdatePO(po);
                            this.gvPO.RefreshData();
                            gvPO_FocusedRowChanged(null, null);
                        }
                    };

                    window.ShowDialog();
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
            EditObject();
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
            this.gvStorageStatusEdit.DataSource = EnumTool.GetDataSource(typeof(StorageStatus));
            this.gvArrivalstatusEdit.DataSource = EnumTool.GetDataSource(typeof(ArrivalStatus));
            this.gvPOStatusEdit.DataSource = EnumTool.GetDataSource(typeof(POStatus));
            this.gvPaymentStatusEdit.DataSource = EnumTool.GetDataSource(typeof(PaymentStatus));

            this.barbtn1.Glyph = global::MEMS.Client.MRP.Properties.Resources.task_32x32;
            this.barbtn1.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.task_32x32;
            this.barbtn1.Caption = "提交审批";
            this.barbtn1.Enabled = false;
            this.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.barbtn2.Glyph = global::MEMS.Client.MRP.Properties.Resources.product_16x16;
            this.barbtn2.LargeGlyph = global::MEMS.Client.MRP.Properties.Resources.product_32x32;
            this.barbtn2.Caption = "到货登记";
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
                    case (int)POStatus.编制:
                        this.barEdit.Enabled = true;
                        this.barDelete.Enabled = true;
                        this.barbtn1.Enabled = true;
                        this.barbtn2.Enabled = false;
                        break;

                    case (int)POStatus.提交未审批:
                        this.barEdit.Enabled = false;
                        this.barDelete.Enabled = false;
                        this.barbtn1.Enabled = false;
                        this.barbtn2.Enabled = false;
                        break;

                    case (int)POStatus.审批驳回:
                        this.barEdit.Enabled = true;
                        this.barDelete.Enabled = true;
                        this.barbtn1.Enabled = false;
                        this.barbtn2.Enabled = false;
                        break;

                    case (int)POStatus.已审批通过:
                        this.barEdit.Enabled = false;
                        this.barDelete.Enabled = false;
                        this.barbtn1.Enabled = false;

                        if (po.storagestatus == (int)StorageStatus.已入库)
                        {
                            this.barbtn2.Enabled = true;
                        }
                        else
                        {
                            this.barbtn2.Enabled = false;
                        }
                        
                        break;

                    default:
                        this.barEdit.Enabled = false;
                        this.barDelete.Enabled = false;
                        this.barbtn1.Enabled = false;
                        this.barbtn2.Enabled = false;
                        break;
                }
            }
        }
    }
}
