using DevExpress.XtraBars;
using MEMS.Client.Common;
using MEMS.Client.Sale.CRMService;
using MEMS.Client.Sale.SaleService;
using MEMS.DB.ExtModels;
using MEMS.DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MEMS.Client.Sale
{
    public partial class SaleRecieveinfoForm : MEMS.Client.Common.BaseinfoForm
    {
        int m_soid;
        SaleServiceClient m_ssclient = new SaleServiceClient();
        CRMServiceClient m_crmclient = new CRMServiceClient();
        T_saleorder m_saleorder;
        List<SaleProduct> m_saleProducts = new List<SaleProduct>();
        List<T_saledetail> m_changelst = new List<T_saledetail>();
        List<T_SaleReceive> m_saleRev = new List<T_SaleReceive>();

        public SaleRecieveinfoForm()
        {
            InitializeComponent();
        }
        public SaleRecieveinfoForm(frmmodetype type, int soid)
        {
            InitializeComponent();
            base.formmode = type;
            m_soid = soid;
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            var customerlst = m_crmclient.getCustomerList();
            lkpcustomer.ExtBindingDataSource<T_Customer>(customerlst, "id", "customername");

            var pUds = DisPlayEnum.getEnumDS(typeof(periodUnit));
            lkpPeriodUnit.ExtBindingDataSource(pUds, "key", "value");

            var rtds = DisPlayEnum.getEnumDS(typeof(receiveType));
            lkpRevType.ExtBindingDataSource(rtds, "key", "value");
            
            readonlytxtbox(this.Controls, true);
                        
            m_saleorder = m_ssclient.getSaleOrderbyId(m_soid);
            SetData(m_saleorder);
            if (m_saleorder.receivetype == (int)receiveType.按产品明细收款)
            {
                m_saleProducts = m_ssclient.getSaleProductbysoid(m_soid);
                gcRecieve.DataSource = m_saleProducts;
                gcRecieve.MainView = gvSaledetail;
                //gvSaledetail.RefreshData();
                colpcount.OptionsColumn.AllowEdit = false;
                colpcode.OptionsColumn.AllowEdit = false;
                colpname.OptionsColumn.AllowEdit = false;
                colpspec.OptionsColumn.AllowEdit = false;
                colpmodelprice.OptionsColumn.AllowEdit = false;
                colpunitprice.OptionsColumn.AllowEdit = false;
                colptotalprice.OptionsColumn.AllowEdit = false;
                colpcount.OptionsColumn.AllowEdit = false;

            }
            else
            {
                this.barbtn1.Visibility = BarItemVisibility.Always;
                this.barbtn1.LargeImageIndex = 8;
                this.barbtn1.Caption = "收款登记";
                this.ribbonPageGroup2.Visible = true;
                m_saleRev = m_ssclient.getSaleRevbySoid(m_soid);
                gcRecieve.DataSource = m_saleRev;
                gcRecieve.MainView = gvSaleRev;
                colsrid.Visible = false;
                colsoid.Visible = false;
                coluid.OptionsColumn.AllowEdit = false;
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
            txtRevStatus.Text = DisPlayEnum.getEnumName(typeof(receiveState), saleOrder.receivestate);
            txtOrderStatus.Text = DisPlayEnum.getEnumName(typeof(orderState), saleOrder.orderstate);
            dateSaleOrder.DateTime = saleOrder.saledate;
            lkpPeriodUnit.EditValue = saleOrder.receiveperiodtype;

            lkpRevType.EditValue = saleOrder.receivetype;
            lkpcustomer.EditValue = saleOrder.customerid;
            InitQt(saleOrder.customerid);
            lkpqtno.EditValue = saleOrder.quotationid;
        }

        private void getData(T_saleorder saleOrder)
        {
            //saleOrder.saleno = txtSono.Text;
            //if (lkpcustomer.EditValue == null)
            //{
            //    throw new Exception("请选择客户");
            //}
            //saleOrder.customerid = (int)lkpcustomer.EditValue;
            //if (lkpqtno.EditValue == null)
            //{
            //    throw new Exception("请选择报价单");
            //}
            //saleOrder.quotationid = (int)lkpqtno.EditValue;
            //saleOrder.saledate = dateSaleOrder.DateTime;
            //saleOrder.saletotalamount = txtOrderAmt.Text == "" ? 0 : Convert.ToDecimal(txtOrderAmt.Text);
            saleOrder.receiveamount = Convert.ToDecimal(txtRevAmt.Text);
            saleOrder.receiveratio = txtRevRatio.Text;
            //if (lkpRevType.EditValue == null)
            //{
            //    throw new Exception("请选择收款类型");
            //}
            //saleOrder.receivetype = (int)lkpRevType.EditValue;
            //if (lkpPeriodUnit.EditValue == null)
            //{
            //    throw new Exception("请选择账期类型");
            //}
            //saleOrder.receiveperiodtype = (int)lkpPeriodUnit.EditValue;
            //saleOrder.receiveperiod = txtPeriod.Text == "" ? 0 : Convert.ToInt32(txtPeriod.Text);
            //saleOrder.remarks = txtremarks.Text;
        }
        /// <summary>
        /// 初始化报价单
        /// </summary>
        private void InitQt(int customerid)
        {
            lkpqtno.Properties.Columns.Clear();
            var qtlst = m_crmclient.getQuotationListbyP("", customerid, new DateTime(2000, 1, 1), new DateTime(2100, 1, 1));
            lkpqtno.ExtBindingDataSource<T_quotation>(qtlst, "id", "qutationno");
        }

        protected override void custom1()
        {
            T_SaleReceive saleRev = new T_SaleReceive();
            saleRev.soid = m_soid;
            m_saleRev.Add(saleRev);
            gvSaleRev.RefreshData();
        }
        protected override void EditObject()
        {
            gvSaledetail.CloseEditor();
            gvSaleRev.CloseEditor();
            if (m_saleorder.receivetype == (int)receiveType.按产品明细收款)
            {
                m_ssclient.UpdateSaleDetail(m_changelst);
                getData(m_saleorder);
                m_ssclient.UpdateSaleOrder(m_saleorder);
            }
            else if (m_saleorder.receivetype == (int)receiveType.按订单收款)
            {
                List<T_SaleReceive> revlst = (List<T_SaleReceive>)gvSaleRev.DataSource;
                var newRev = revlst.FindAll(r => r.id == 0);
                m_ssclient.AddNewSaleRev(newRev);
                getData(m_saleorder);
                m_ssclient.UpdateSaleOrder(m_saleorder);
            }
            base.EditObject();
        }

        private void gvSaledetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //gvSaledetail.CloseEditor();
            if (!m_changelst.Exists(t => t == m_saleProducts[e.RowHandle].sd))
            {
                m_changelst.Add(m_saleProducts[e.RowHandle].sd);
            }
            txtRevAmt.Text = CalProductRev().ToString();
            txtRevRatio.Text = (Convert.ToDecimal(txtRevAmt.Text) / Convert.ToDecimal(txtOrderAmt.Text)).ToString("P");
        }

        public decimal CalProductRev()
        {
            decimal totalAmount = 0;
            foreach (var p in m_saleProducts)
            {
                totalAmount += p.sd.receiveamount.HasValue ? p.sd.receiveamount.Value : 0;
            }
            return totalAmount;
        }

        public decimal CalOrderRev()
        {
            decimal totalAmount = 0;
            foreach (var p in m_saleRev)
            {
                totalAmount += p.revamount.HasValue ? p.revamount.Value : 0;
            }

            return totalAmount;
        }

        private void gvSaleRev_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colrevamt" && m_saleRev[e.RowHandle].id == 0)
            {
                txtRevAmt.Text = CalOrderRev().ToString();
                txtRevRatio.Text = (Convert.ToDecimal(txtRevAmt.Text) / Convert.ToDecimal(txtOrderAmt.Text)).ToString("P");
            }
        }

        private void gvSaleRev_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int srid = (int)gvSaleRev.GetFocusedRowCellValue("id");
            if (srid != 0)
            {
                gvSaleRev.OptionsBehavior.Editable = false;
            }
            else
            {
                gvSaleRev.OptionsBehavior.Editable = true;
            }
        }
    }
}
