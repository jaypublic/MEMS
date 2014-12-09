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
            InitCustomerCmb();
            DisPlayEnum.getEnumDS(lkpPeriodUnit, typeof(periodUnit));
            DisPlayEnum.getEnumDS(lkpRevType, typeof(receiveType));
            this.barbtn1.Visibility = BarItemVisibility.Always;
            this.barbtn1.LargeImageIndex = 8;

            gcSaledetail.DataSource = m_saleProducts;
            //if (formmode == frmmodetype.add)
            //{
            //    m_saleorder = new T_saleorder();
            //}
            //else if (formmode == frmmodetype.edit)
            //{
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
            //}
            //else if (formmode == frmmodetype.delete)
            //{
            //    m_saleorder = m_ssclient.getSaleOrderbyId(m_soid);
            //    SetData(m_saleorder);
            //    readonlytxtbox(this.Controls, true);
            //    gvSaledetail.OptionsBehavior.Editable = false;
            //    m_saleProducts = m_ssclient.getSaleProductbysoid(m_soid);
            //    gcSaledetail.RefreshDataSource();
            //}
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
            txtRevRatio.Text = (saleOrder.receiveratio.HasValue ? saleOrder.receiveratio.Value.ToString() : "0") + "%";
            txtRevStatus.Text = DisPlayEnum.getEnumName(typeof(receiveState), saleOrder.receivestate);
            txtOrderStatus.Text = DisPlayEnum.getEnumName(typeof(orderState), saleOrder.orderstate);
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
            lkpcustomer.Properties.DataSource = customerlst;
            lkpcustomer.Properties.DisplayMember = "customername";
            lkpcustomer.Properties.ValueMember = "id";
            lkpcustomer.Properties.ShowFooter = false;
            lkpcustomer.Properties.ShowHeader = false;
            lkpcustomer.Properties.NullText = "";
            lkpcustomer.Properties.DropDownRows = customerlst.Count;
            var keycol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id");
            lkpcustomer.Properties.Columns.Add(keycol);
            var textcol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("customername", "name");
            lkpcustomer.Properties.Columns.Add(textcol);
            keycol.Visible = false;
        }
        /// <summary>
        /// 初始化报价单
        /// </summary>
        private void InitQt(int customerid)
        {
            lkpqtno.Properties.Columns.Clear();
            var qtlst = m_crmclient.getQuotationListbyP("", customerid, new DateTime(2000, 1, 1), new DateTime(2100, 1, 1));
            lkpqtno.Properties.DataSource = qtlst;
            lkpqtno.Properties.DisplayMember = "qutationno";
            lkpqtno.Properties.ValueMember = "id";
            lkpqtno.Properties.ShowFooter = false;
            lkpqtno.Properties.ShowHeader = false;
            lkpqtno.Properties.NullText = "";
            lkpqtno.Properties.DropDownRows = qtlst.Count;
            var keycol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id");
            lkpqtno.Properties.Columns.Add(keycol);
            var textcol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("qutationno", "name");
            lkpqtno.Properties.Columns.Add(textcol);
            keycol.Visible = false;
        }
    }
}
