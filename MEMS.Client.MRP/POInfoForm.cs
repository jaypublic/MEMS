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
    public partial class POInfoForm : BaseinfoForm
    {
        public T_PurchaseOrder PO;
        private List<T_PurchaseOrderDetail> _PODetails;
        public List<string> _AddList;
        public List<string> _DelList;

        ServiceProxy proxy = new ServiceProxy();


        public POInfoForm(frmmodetype type, T_PurchaseOrder po)
        {
            InitializeComponent();
            base.formmode = type;
            this.PO = po;
        }

        public POInfoForm(T_PurchaseOrder po)
        {
            InitializeComponent();
            base.formmode = frmmodetype.edit;
            this.PO = po;

            this.okButton.Enabled = false;
        }

        protected override void FormLoad()
        {
            this.POTypeComboBox.DataSource = EnumTool.GetDataSource(typeof(Enums.POTypes));
            this.BuyerComboBox.DataSource = proxy.GetEmployees();
            this.ApplicantComboBox.DataSource = proxy.GetEmployees();
            this.ApplyDeptComboBox.DataSource = proxy.GetAllDepts();

            this.gvUnitEdit.DataSource = proxy.GetUnitList();

            this.gvPODetails.CellValueChanged += (o, e) =>
                {
                    if (e.Column.Name == "Quantity" || e.Column.Name == "Price")
                    {
                        CalAmount();
                    }
                };

            if (formmode == frmmodetype.add)
            {
                DateTime now = DateTime.Now;
                DateTime nextWeek = now.AddDays(7);
                this.DmdArrivalDateEdit.Text = (new DateTime(nextWeek.Year, nextWeek.Month, nextWeek.Day)).ToString("yyyy-MM-dd");
                this.ApplyDateEdit.Text = (new DateTime(now.Year, now.Month, now.Day)).ToString("yyyy-MM-dd");

                PO = new T_PurchaseOrder()
                {
                    pono = proxy.GetLatestPOIndex(),
                    register = Global.UserNo,
                    registerdesc = Global.UserName,
                    arrivalstatus = (int)ArrivalStatus.未到货,
                    paymentstatus = (int)PaymentStatus.未付款,
                    postatus = (int)POStatus.编制,
                    potype = (int)POTypes.销售订单,
                    amount = 0
                };

                _PODetails = new List<T_PurchaseOrderDetail>();
            }
            else
            {
                this.DmdArrivalDateEdit.Text = PO.demandarrivaldate;
                this.ApplyDateEdit.Text = PO.applydate;

                _PODetails = proxy.GetPODetailList(PO.pono);
            }

            SetData();
        }

        private void SetData()
        {
            this.POTypeComboBox.Text = Enum.GetName(typeof(POTypes), PO.potype);
            this.BuyerComboBox.Text = PO.buyerdesc;
            this.PONoTextBox.Text = PO.pono;
            this.AmountTextBox.Text = PO.amount.ToString();
            this.ApplicantComboBox.Text = PO.applicantdesc;
            this.RegisterTextBox.Text = PO.registerdesc;
            this.ApplyDeptComboBox.Text = PO.applydeptdesc;
            this.ActArrivalDateTextBox.Text = PO.actualarrivaldate;
            this.SaleNoComboBox.Text = PO.saleno;
            this.ArrivalStatusTextBox.Text = Enum.GetName(typeof(ArrivalStatus), PO.arrivalstatus);
            this.SendApprovalDateTextBox.Text = PO.sendapprovaldate;
            this.ApprovalTextBox.Text = PO.approvaldesc;
            this.ApprovalDateTextBox.Text = PO.approvaldate;
            this.PaymentStatusTextBox.Text = Enum.GetName(typeof(PaymentStatus), PO.paymentstatus);

            this.gcPODetails.DataSource = _PODetails;
            _AddList = new List<string>();
            _DelList = new List<string>();
        }

        protected override void AddObject()
        {
            SetEntity();

            proxy.AddPO(PO);
            SaveDetail();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void EditObject()
        {
            SetEntity();

            proxy.UpdatePO(PO);
            SaveDetail();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SetEntity()
        {
            PO.potype = Convert.ToInt16(this.POTypeComboBox.SelectedValue);

            if (this.BuyerComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择采购员");
                return;
            }
            else
            {
                PO.buyer = this.BuyerComboBox.SelectedValue.ToString();
                PO.buyerdesc = this.BuyerComboBox.Text;
            }
            
            PO.amount = Convert.ToDecimal(this.AmountTextBox.Text);
            PO.demandarrivaldate = this.DmdArrivalDateEdit.Text;
            PO.actualarrivaldate = this.ActArrivalDateTextBox.Text;

            if (this.ApplicantComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择申请人");
                return;
            }
            else
            {
                PO.applicant = this.ApplicantComboBox.SelectedValue.ToString();
                PO.applicantdesc = this.ApplicantComboBox.Text;
            }
            
            PO.applydate = this.ApplyDateEdit.Text;

            if (this.ApplyDeptComboBox.SelectedValue == null)
            {
                MessageBox.Show("请选择申请部门");
                return;
            }
            else
            {
                PO.applydept = this.ApplyDeptComboBox.SelectedValue.ToString();
                PO.applydeptdesc = this.ApplyDeptComboBox.Text;
            }

            PO.postatus = (int)POStatus.编制;
            PO.sendapprovaldate = null;

            if (this.SaleNoComboBox.SelectedItem != null)
            {
                PO.saleno = this.SaleNoComboBox.SelectedItem.ToString();
            }
        }

        public void SaveDetail()
        {
            foreach (string id in _AddList)
            {
                proxy.AddPODetail(_PODetails.Find(o => o.Id == id));
            }

            foreach (string id in _DelList)
            {
                proxy.DeletePODetail(id);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MatCodeSearchWindow window = new MatCodeSearchWindow();
            window.FormClosed += (o, ee) =>
                {
                    foreach (T_StandardMaterial stdMaterail in window.SelectedStandardMaterails)
                    {
                        if (_PODetails.Where(d => d.Material.MatCode == stdMaterail.MatCode).Count() == 0)
                        {
                            T_PurchaseOrderDetail detail = new T_PurchaseOrderDetail()
                            {
                                Id = Guid.NewGuid().ToString(),
                                PONo = PO.pono,
                                Material = stdMaterail
                            };

                            _PODetails.Add(detail);
                            _AddList.Add(detail.Id);
                        }
                    }

                    this.gvPODetails.RefreshData();
                    CalAmount();
                };

            window.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.gvPODetails.GetFocusedRow() == null)
                return;

            string id = (this.gvPODetails.GetFocusedRow() as T_PurchaseOrderDetail).Id;
            if (_AddList.Contains(id))
            {
                _AddList.Remove(id);
            }
            else
            {
                _DelList.Add(id);
            }

            _PODetails.Remove(_PODetails.Find(o => o.Id == id));
            this.gvPODetails.RefreshData();
            CalAmount();
        }

        private void CalAmount()
        {
            this.AmountTextBox.Text = _PODetails.Sum(d => d.Price * d.Quantity).ToString();
        }
    }
}
