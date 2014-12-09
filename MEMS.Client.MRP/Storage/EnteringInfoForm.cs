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
    public partial class EnteringInfoForm : BaseinfoForm
    {
        public T_PurchaseOrder PO;
        private List<T_PurchaseOrderDetail> _PODetails;
        private List<T_StockMaterial> _StockMaterials;
        public List<T_StockMaterial> _AddList;
        public List<T_StockMaterial> _EditList;
        public List<T_StockMaterial> _DelList;

        ServiceProxy proxy = new ServiceProxy();

        private T_PurchaseOrderDetail SelectedDetail
        {
            get
            {
                if (gvPODetails.GetFocusedRow() != null)
                {
                    return gvPODetails.GetFocusedRow() as T_PurchaseOrderDetail;
                }

                return null;
            }
        }

        public EnteringInfoForm(T_PurchaseOrder po)
        {
            InitializeComponent();
            base.formmode = frmmodetype.edit;
            this.PO = po;
        }

        protected override void FormLoad()
        {
            this.gvUnitEdit.DataSource = proxy.GetUnitList();
            this.ActArrivalDateDateEdit.Text = DateTime.Now.ToString("yyyy-MM-dd");
            _PODetails = proxy.GetPODetailList(PO.pono);
            _StockMaterials = proxy.GetStockMaterialsByPO(PO.pono);

            this.gvPODetails.FocusedRowChanged += gvPODetails_FocusedRowChanged;

            SetData();
        }

        void gvPODetails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.gcStockMaterials.DataSource = null;

            if (SelectedDetail != null)
            {
                this.gcStockMaterials.DataSource = _StockMaterials.Where(o => o.PODetailId == SelectedDetail.Id).ToList();
            }
        }

        private void SetData()
        {
            this.POTypeTextBox.Text = Enum.GetName(typeof(POTypes), PO.potype);
            this.BuyerTextBox.Text = PO.buyerdesc;
            this.PONoTextBox.Text = PO.pono;
            this.AmountTextBox.Text = PO.amount.ToString();
            this.ApplicantTextBox.Text = PO.applicantdesc;
            this.RegisterTextBox.Text = PO.registerdesc;
            this.ApplyDeptTextBox.Text = PO.applydeptdesc;
            this.DmdArrivalTextBox.Text = PO.demandarrivaldate;
            this.ActArrivalDateDateEdit.Text = PO.actualarrivaldate;
            this.SaleNoTextBox.Text = PO.saleno;
            this.ArrivalStatusTextBox.Text = Enum.GetName(typeof(ArrivalStatus), PO.arrivalstatus);
            this.SendApprovalDateTextBox.Text = PO.sendapprovaldate;
            this.ApprovalTextBox.Text = PO.approvaldesc;
            this.ApprovalDateTextBox.Text = PO.approvaldate;
            this.PaymentStatusTextBox.Text = Enum.GetName(typeof(PaymentStatus), PO.paymentstatus);

            this.gcPODetails.DataSource = _PODetails;

            _AddList = new List<T_StockMaterial>();
            _EditList = new List<T_StockMaterial>();
            _DelList = new List<T_StockMaterial>();
        }

        protected override void EditObject()
        {
            SaveDetail();

            CheckPOStatus();

            proxy.UpdatePO(PO);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public void SaveDetail()
        {
            if (_AddList.Count > 0)
            {
                proxy.AddStockMaterials(_AddList);
            }

            if (_EditList.Count > 0)
            {
                foreach (T_StockMaterial material in _EditList)
                {
                    proxy.UpdateStockMaterial(material);
                }
            }

            if (_DelList.Count > 0)
            {
                foreach (T_StockMaterial material in _DelList)
                {
                    proxy.DeleteStockMaterial(material.StockCode, material.MatCode);
                }
            }

            _AddList.Clear();
            _EditList.Clear();
            _DelList.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(this.gvPODetails.GetFocusedRow()== null)
            {
                return;
            }

            T_PurchaseOrderDetail detail = this.gvPODetails.GetFocusedRow() as T_PurchaseOrderDetail;

            EnteringWindow window = new EnteringWindow();
            window.Material = detail.Material;
            window.Quantity = detail.Quantity;
            window.ExistQuantity = _StockMaterials.Where(o => o.PODetailId == (this.gvPODetails.GetFocusedRow() as T_PurchaseOrderDetail).Id).Sum(o => o.Quantity);

            window.FormClosed += (o, ee) =>
            {
                if (window.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    if (_StockMaterials.Where(m => m.StockCode == window.StockCode.Code && m.MatCode == SelectedDetail.Material.MatCode).Count() > 0)
                    {
                        T_StockMaterial material = _StockMaterials.Find(m => m.StockCode == window.StockCode.Code && m.MatCode == SelectedDetail.Material.MatCode && m.PODetailId == SelectedDetail.Id);
                        material.Quantity += window.EnteringQuantity;
                        material.AvailableQuantity += window.EnteringQuantity;

                        if (!_AddList.Contains(material))
                        {
                            _EditList.Add(material);
                        }
                    }
                    else
                    {
                        T_StockMaterial material = new T_StockMaterial()
                        {
                            PONo = SelectedDetail.PONo,
                            PODetailId = SelectedDetail.Id,
                            Unit = SelectedDetail.Unit,
                            MatCode = SelectedDetail.Material.MatCode,
                            MatDesc = SelectedDetail.Material.MatDesc,
                            MatTypeCode = SelectedDetail.Material.MatTypeCode,
                            MatModeCode = SelectedDetail.Material.MatModeCode,
                            StockCode = window.StockCode.Code,
                            StockDesc = window.StockCode.Desc,
                            Quantity = window.EnteringQuantity,
                            AvailableQuantity = window.EnteringQuantity
                        };

                        (this.gcStockMaterials.DataSource as List<T_StockMaterial>).Add(material);
                        _StockMaterials.Add(material);
                        _AddList.Add(material);
                    }

                    this.gvStockMaterials.RefreshData();
                }
            };

            window.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.gvStockMaterials.GetFocusedRow() == null)
                return;

            T_StockMaterial material = this.gvStockMaterials.GetFocusedRow() as T_StockMaterial;

            if (_AddList.Contains(material))
            {
                _AddList.Remove(material);
            }
            else
            {
                _DelList.Add(material);
            }

            (this.gcStockMaterials.DataSource as List<T_StockMaterial>).Remove(material);
            _StockMaterials.Remove(material);
            this.gvStockMaterials.RefreshData();
        }

        private void CheckPOStatus()
        {
            decimal poQuantity = _PODetails.Sum(o => o.Quantity);
            decimal storageQuantity = _StockMaterials.Sum(o => o.Quantity);

            if (poQuantity == storageQuantity && storageQuantity > 0)
            {
                PO.storagestatus = (int)StorageStatus.已入库;
            }
            else if (storageQuantity > 0)
            {
                PO.storagestatus = (int)StorageStatus.部分入库;
            }
            else
            {
                PO.storagestatus = (int)StorageStatus.未入库;
            }
        }
    }
}
