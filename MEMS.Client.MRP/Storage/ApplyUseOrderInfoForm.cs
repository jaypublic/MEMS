using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using MEMS.Client.Common;
using DevExpress.XtraEditors;
using MEMS.Client.MRP.UserWindows;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Enums;
using MEMS.Client.MRP.Proxy;
using MEMS.Client.MRP.Toolkit;

namespace MEMS.Client.MRP
{
    public partial class ApplyUseOrderInfoForm : BaseinfoForm
    {
        public T_ApplyUseOrder ApplyUseOrder;
        private List<T_ApplyUseOrderDetail> _ApplyUseOrderDetails;
        public List<string> _AddList;
        public List<string> _DelList;

        ServiceProxy proxy = new ServiceProxy();


        public ApplyUseOrderInfoForm(frmmodetype type, T_ApplyUseOrder applyUseOrder)
        {
            InitializeComponent();
            base.formmode = type;
            this.ApplyUseOrder = applyUseOrder;
        }

        public ApplyUseOrderInfoForm(T_ApplyUseOrder applyUseOrder)
        {
            InitializeComponent();
            base.formmode = frmmodetype.edit;
            this.ApplyUseOrder = applyUseOrder;

            this.okButton.Enabled = false;
        }

        protected override void FormLoad()
        {
            this.ApplyUseTypeComboBox.DataSource = EnumTool.GetDataSource(typeof(Enums.ApplyUseTypes));
            this.ApplyUseTypeComboBox.SelectedIndex = 1;
            this.UserComboBox.DataSource = proxy.GetEmployees();
            this.ApplicantComboBox.DataSource = proxy.GetEmployees();
            this.ApplyDeptComboBox.DataSource = proxy.GetAllDepts();

            this.gvUnitEdit.DataSource = proxy.GetUnitList();

            if (formmode == frmmodetype.add)
            {
                ApplyUseOrder = new T_ApplyUseOrder()
                {
                    ApplyUseNo = proxy.GetLatestApplyUseOrderIndex(),
                    Register = Global.UserNo,
                    RegisterDesc = Global.UserName
                };

                _ApplyUseOrderDetails = new List<T_ApplyUseOrderDetail>();
            }
            else
            {
                _ApplyUseOrderDetails = proxy.GetApplyUserOrderDetails(ApplyUseOrder.ApplyUseNo);
            }

            SetData();
        }

        private void SetData()
        {
            this.ApplyUseTypeComboBox.Text = Enum.GetName(typeof(ApplyUseTypes), ApplyUseOrder.ApplyUseType);
            this.UserComboBox.Text = ApplyUseOrder.Userdesc;
            this.ApplyUseNoTextBox.Text = ApplyUseOrder.ApplyUseNo;
            this.ApplicantComboBox.Text = ApplyUseOrder.ApplicantDesc;
            this.ApplyDeptComboBox.Text = ApplyUseOrder.DeptDesc;
            this.SaleNoComboBox.Text = ApplyUseOrder.SaleNo;
            this.ProductOrderNoComboBox.Text = ApplyUseOrder.ProductOrderNo;

            this.gcApplyUseOrderDetails.DataSource = _ApplyUseOrderDetails;
            _AddList = new List<string>();
            _DelList = new List<string>();
        }

        protected override void AddObject()
        {
            SetEntity();

            proxy.AddApplyUseOrder(ApplyUseOrder);
            SaveDetail();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void EditObject()
        {
            SetEntity();

            proxy.UpdateAddApplyUseOrder(ApplyUseOrder);
            SaveDetail();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SetEntity()
        {
            ApplyUseOrder.ApplyUseType = Convert.ToInt16(this.ApplyUseTypeComboBox.SelectedValue);

            if (this.ApplicantComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择申请人");
                return;
            }
            else
            {
                ApplyUseOrder.Applicant = this.ApplicantComboBox.SelectedValue.ToString();
                ApplyUseOrder.ApplicantDesc = this.ApplicantComboBox.Text;
            }

            if (this.UserComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择领用人");
                return;
            }
            else
            {
                ApplyUseOrder.User = this.UserComboBox.SelectedValue.ToString();
                ApplyUseOrder.Userdesc = this.UserComboBox.Text;
            }

            if (this.ApplyDeptComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择申请部门");
                return;
            }
            else
            {
                ApplyUseOrder.Dept = this.ApplyDeptComboBox.SelectedValue.ToString();
                ApplyUseOrder.DeptDesc = this.ApplyDeptComboBox.Text;
            }

            if (this.SaleNoComboBox.SelectedItem != null)
            {
                ApplyUseOrder.SaleNo = this.SaleNoComboBox.SelectedItem.ToString();
            }

            if (this.ProductOrderNoComboBox.SelectedItem != null)
            {
                ApplyUseOrder.ProductOrderNo = this.SaleNoComboBox.SelectedItem.ToString();
            }
        }

        public void SaveDetail()
        {
            foreach (string id in _AddList)
            {
                proxy.AddApplyUserOrderDetail(_ApplyUseOrderDetails.Find(o => o.Id == id));
            }

            foreach (string id in _DelList)
            {
                proxy.DeleteApplyUserOrderDetail(id);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StockMaterialsSearchWindow window = new StockMaterialsSearchWindow();
            window.FormClosed += (o, ee) =>
                {
                    foreach (T_StockMaterial stockMaterail in window.SelectedStockMaterails)
                    {
                        if (_ApplyUseOrderDetails.Where(d => d.MatCode == stockMaterail.MatCode).Count() == 0)
                        {
                            T_ApplyUseOrderDetail detail = new T_ApplyUseOrderDetail()
                            {
                                Id = Guid.NewGuid().ToString(),
                                ApplyUseNo = ApplyUseOrder.ApplyUseNo,  
                                Unit = stockMaterail.Unit,
                                MatCode = stockMaterail.MatCode,
                                MatDesc = stockMaterail.MatDesc,
                                MatTypeCode = stockMaterail.MatTypeCode,
                                MatModeCode = stockMaterail.MatModeCode,
                                AvailableQuantity = stockMaterail.AvailableQuantity
                            };

                            _ApplyUseOrderDetails.Add(detail);
                            _AddList.Add(detail.Id);
                        }
                    }

                    this.gvApplyUseOrderDetails.RefreshData();
                };

            window.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.gvApplyUseOrderDetails.GetFocusedRow() == null)
                return;

            string id = (this.gvApplyUseOrderDetails.GetFocusedRow() as T_ApplyUseOrderDetail).Id;
            if (_AddList.Contains(id))
            {
                _AddList.Remove(id);
            }
            else
            {
                _DelList.Add(id);
            }

            _ApplyUseOrderDetails.Remove(_ApplyUseOrderDetails.Find(o => o.Id == id));
            this.gvApplyUseOrderDetails.RefreshData();
        }
    }
}
