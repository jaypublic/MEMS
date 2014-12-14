using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MEMS.Client.Common;
using MEMS.Client.Sale.SaleService;
using MEMS.Client.Sale.CRMService;
using DevExpress.XtraEditors;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;
using DevExpress.XtraBars;

namespace MEMS.Client.Sale
{
    public partial class SaleOrderinfoForm : MEMS.Client.Common.BaseinfoForm
    {
        int m_soid;
        SaleServiceClient m_ssclient = new SaleServiceClient();
        CRMServiceClient m_crmclient = new CRMServiceClient();
        T_saleorder m_saleorder;
        List<SaleProduct> m_saleProducts = new List<SaleProduct>();

        public SaleOrderinfoForm(frmmodetype type)
        {
            InitializeComponent();
            base.formmode = type;
        }
        public SaleOrderinfoForm(frmmodetype type,int soid)
        {
            InitializeComponent();
            base.formmode = type;
            m_soid = soid;
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            InitCustomerCmb();
            //DisPlayEnum.ExtGetEnumDS(lkpPeriodUnit, typeof(periodUnit));
            var pUds = DisPlayEnum.getEnumDS(typeof(periodUnit));
            lkpPeriodUnit.ExtBindingDataSource(pUds, "key", "value");
            //DisPlayEnum.ExtGetEnumDS(lkpRevType, typeof(receiveType));
            var rtds = DisPlayEnum.getEnumDS(typeof(receiveType));
            lkpRevType.ExtBindingDataSource(rtds, "key", "value");
            this.barbtn1.Visibility = BarItemVisibility.Always;
            this.barbtn1.LargeImageIndex = 8;
            gcSaledetail.DataSource = m_saleProducts;
            if (formmode == frmmodetype.add)
            {
                m_saleorder = new T_saleorder();
            }
            else if (formmode == frmmodetype.edit)
            {
                m_saleorder = m_ssclient.getSaleOrderbyId(m_soid);
                SetData(m_saleorder);
                m_saleProducts = m_ssclient.getSaleProductbysoid(m_soid);
                gcSaledetail.DataSource = m_saleProducts;
                gvSaledetail.RefreshData();

                colpcode.OptionsColumn.AllowEdit = false;
                colpname.OptionsColumn.AllowEdit = false;
                colpspec.OptionsColumn.AllowEdit = false;
                colpmodelprice.OptionsColumn.AllowEdit = false;
                colpunitprice.OptionsColumn.AllowEdit = false;
                colptotalprice.OptionsColumn.AllowEdit = false;
            }
            else if (formmode == frmmodetype.delete)
            {
                m_saleorder = m_ssclient.getSaleOrderbyId(m_soid);
                SetData(m_saleorder);
                readonlytxtbox(this.Controls, true);
                gvSaledetail.OptionsBehavior.Editable = false;
                m_saleProducts = m_ssclient.getSaleProductbysoid(m_soid);
                gcSaledetail.RefreshDataSource();
            }
        }
        /// <summary>
        /// 设置数据至控件
        /// </summary>
        /// <param name="saleOrder"></param>
        private void SetData(T_saleorder saleOrder)
        {
            txtSono.Text = saleOrder.saleno;
            txtOrderAmt.Text = saleOrder.saletotalamount.HasValue ? saleOrder.saletotalamount.Value.ToString() : "";
            txtPeriod.Text = saleOrder.receiveperiod.HasValue ? saleOrder.receiveperiod.Value.ToString() : "";            
            txtremarks.Text = saleOrder.remarks;
            if (saleOrder.receiveamount.HasValue)
            {
                txtRevAmt.Text = saleOrder.receiveamount.Value.ToString();
            }
            
            //txtRevAmt.Text = saleOrder.receiveamount.HasValue ? saleOrder.receiveamount.Value.ToString() : "";
            //txtRevRatio.Text = (saleOrder.receiveratio.HasValue ? saleOrder.receiveratio.Value.ToString() : "0") + "%";
            txtRevRatio.Text = saleOrder.receiveratio;
            //txtRevStatus.Text = DisPlayEnum.getEnumName(typeof(receiveState), saleOrder.receivestate);
            txtRevStatus.Text = ((receiveState)saleOrder.receivestate).ToString();
            //txtOrderStatus.Text = DisPlayEnum.getEnumName(typeof(orderState), saleOrder.orderstate);
            txtOrderStatus.Text = ((orderState)saleOrder.orderstate).ToString();
            dateSaleOrder.DateTime = saleOrder.saledate;
            lkpPeriodUnit.EditValue = saleOrder.receiveperiodtype;
                        
            lkpRevType.EditValue = saleOrder.receivetype;
            lkpcustomer.EditValue = saleOrder.customerid;
            InitQt(saleOrder.customerid);
            lkpqtno.EditValue = saleOrder.quotationid;
        }
        /// <summary>
        /// 初始化客户列表
        /// </summary>
        private void InitCustomerCmb()
        {
            var customerlst = m_crmclient.getCustomerList();
            lkpcustomer.ExtBindingDataSource<T_Customer>(customerlst, "id", "customername");
            //lkpcustomer.Properties.DataSource = customerlst;
            //lkpcustomer.Properties.DisplayMember = "customername";
            //lkpcustomer.Properties.ValueMember = "id";
            //lkpcustomer.Properties.ShowFooter = false;
            //lkpcustomer.Properties.ShowHeader = false;
            //lkpcustomer.Properties.NullText = "";
            //lkpcustomer.Properties.DropDownRows = customerlst.Count;
            //var keycol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id");
            //lkpcustomer.Properties.Columns.Add(keycol);
            //var textcol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("customername", "name");
            //lkpcustomer.Properties.Columns.Add(textcol);
            //keycol.Visible = false;
        }

        private void lkpcustomer_Properties_EditValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(lkpcustomer.EditValue);
            InitQt((int)lkpcustomer.EditValue);
        }
        /// <summary>
        /// 初始化报价单
        /// </summary>
        private void InitQt(int customerid)
        {
            lkpqtno.Properties.Columns.Clear();
            var qtlst = m_crmclient.getQuotationListbyP("", customerid, new DateTime(2000, 1, 1), new DateTime(2100, 1, 1));
            lkpqtno.ExtBindingDataSource<T_quotation>(qtlst, "id", "qutationno");
            //lkpqtno.Properties.DataSource = qtlst;
            //lkpqtno.Properties.DisplayMember = "qutationno";
            //lkpqtno.Properties.ValueMember = "id";
            //lkpqtno.Properties.ShowFooter = false;
            //lkpqtno.Properties.ShowHeader = false;
            //lkpqtno.Properties.NullText = "";
            //lkpqtno.Properties.DropDownRows = qtlst.Count;
            //var keycol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id");
            //lkpqtno.Properties.Columns.Add(keycol);
            //var textcol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("qutationno", "name");
            //lkpqtno.Properties.Columns.Add(textcol);
            //keycol.Visible = false;
        }

        private void getData(T_saleorder saleOrder)
        {
            saleOrder.saleno = txtSono.Text;
            if (lkpcustomer.EditValue == null)
            {
                throw new Exception("请选择客户");
            }
            saleOrder.customerid = (int)lkpcustomer.EditValue;
            if (lkpqtno.EditValue == null)
            {
                throw new Exception("请选择报价单");
            }
            saleOrder.quotationid = (int)lkpqtno.EditValue;
            saleOrder.saledate = dateSaleOrder.DateTime;
            saleOrder.saletotalamount = txtOrderAmt.Text == "" ? 0 : Convert.ToDecimal(txtOrderAmt.Text);
            //saleOrder.receiveamount = Convert.ToDecimal(txtRevAmt.Text);
            //saleOrder.receiveratio = Convert.ToDecimal(txtRevRatio.Text);            
            if (lkpRevType.EditValue == null)
            {
                throw new Exception("请选择收款类型");
            }
            saleOrder.receivetype = (int)lkpRevType.EditValue;
            if (lkpPeriodUnit.EditValue == null)
            {
                throw new Exception("请选择账期类型");
            }
            saleOrder.receiveperiodtype = (int)lkpPeriodUnit.EditValue;
            saleOrder.receiveperiod = txtPeriod.Text == "" ? 0 : Convert.ToInt32(txtPeriod.Text);
            saleOrder.remarks = txtremarks.Text;
        }

        protected override void AddObject()
        {
            getData(m_saleorder);
            //m_ssclient.AddNewSaleOrder(m_saleorder);
            List<T_saledetail> sdlist = new List<T_saledetail>();
            foreach (var sp in m_saleProducts)
            {
                sdlist.Add(sp.sd);
            }
            m_ssclient.AddNewSoSd(m_saleorder, sdlist);
            base.AddObject();
        }
        protected override void EditObject()
        {
            getData(m_saleorder);
            m_ssclient.UpdateSaleOrder(m_saleorder);
            base.EditObject();
        }
        protected override void DeleteObject()
        {
            m_ssclient.DeleteSaleOrder(m_saleorder);
            base.DeleteObject();
        }
        protected override void custom1()
        {
            var qtid = (int)lkpqtno.EditValue;
            FormSelectProduct frm = new FormSelectProduct(qtid);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var qtproducts = frm.selectQtProduct;
                AddSaleProduct(qtproducts);
            }
        }

        private void AddSaleProduct(List<QtProduct> productlst)
        {            
            try
            {
                m_saleProducts.Clear();
                foreach (var p in productlst)
                {
                    SaleProduct sp = new SaleProduct();
                    sp.sd = new T_saledetail();
                    sp.sd.productid = p.qp.productid;
                    sp.sd.producttotalprice = p.qp.totalprice;
                    sp.productCode = p.productCode;
                    sp.productName = p.productName;
                    sp.productSpec = p.productSpec;
                    sp.pUnitPrice = p.qp.unitprice;
                    sp.pModelPrice = p.qp.modelprice;
                    //sp.sd.plandeliverydate=
                    m_saleProducts.Add(sp);
                }
                gcSaledetail.RefreshDataSource();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void txtRevAmt_TextChanged(object sender, EventArgs e)
        {
            var ratio = Math.Round((Convert.ToDecimal(txtRevAmt.Text) / Convert.ToDecimal(txtOrderAmt.Text)) * 100, 2, MidpointRounding.AwayFromZero);
            txtRevRatio.Text = ratio.ToString() + "%";
        }

        private void gvSaledetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gvSaledetail.CloseEditor();
            if (e.Column.FieldName == "sd.productnumber")
            {
                m_saleProducts[e.RowHandle].sd.producttotalprice = m_saleProducts[e.RowHandle].pModelPrice.Value + m_saleProducts[e.RowHandle].pUnitPrice.Value * m_saleProducts[e.RowHandle].sd.productnumber.Value;
            }
            txtOrderAmt.Text = CalTotalPrice();
        }

        private string CalTotalPrice()
        {
            decimal totalprice = 0;
            foreach (var p in m_saleProducts)
            {
                if (p.sd.producttotalprice.HasValue)
                    totalprice += p.sd.producttotalprice.Value;
            }
            return totalprice.ToString();
        }
    }
}
