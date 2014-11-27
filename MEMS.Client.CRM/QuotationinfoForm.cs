using MEMS.Client.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.CRM.CRMService;
using DevExpress.XtraBars;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMS.Client.CRM
{
    public partial class QuotationinfoForm : MEMS.Client.Common.BaseinfoForm
    {
        private CRMService.CRMServiceClient m_crmclient = new CRMService.CRMServiceClient();
        private int m_qid;
        private T_quotation m_Qinfo;
        private List<QtProduct> m_QtProductlst = new List<QtProduct>();
        public QuotationinfoForm(frmmodetype type)
        {
            InitializeComponent();
            base.formmode = type;
        }
        public QuotationinfoForm(frmmodetype type, int qid)
        {
            InitializeComponent();
            base.formmode = type;
            m_qid = qid;
        }
        protected override void FormLoad()
        {
            gcQtprice.DataSource = m_QtProductlst;
            barbtn1.Visibility = BarItemVisibility.Always;
            barbtn1.LargeImageIndex = 9;
            barbtn1.Caption = "添加产品";
            txtTotalPrice.Properties.ReadOnly = true;
            txtCustomer.Properties.ReadOnly = true;
            
            if (formmode == frmmodetype.add)
            {
                m_Qinfo = new T_quotation();
            }
            else if (formmode==frmmodetype.edit)
            {
                m_Qinfo = m_crmclient.getQuotationbyId(m_qid);
                SetData(m_Qinfo);
                m_QtProductlst = m_crmclient.getQtProduct(m_qid);
                gcQtprice.DataSource = m_QtProductlst;
            }
            else if (formmode == frmmodetype.delete)
            {
                m_Qinfo = m_crmclient.getQuotationbyId(m_qid);
                SetData(m_Qinfo);
                base.readonlytxtbox(this.Controls, true);
                m_QtProductlst = m_crmclient.getQtProduct(m_qid);
                gcQtprice.DataSource = m_QtProductlst;
            }
            base.FormLoad();
        }

        /// <summary>
        /// 设置实体属性至窗体控件
        /// </summary>
        /// <param name="qinfo"></param>
        private void SetData(T_quotation qinfo)
        {            
            txtQuno.Text = qinfo.qutationno;
            txtTotalPrice.Text = qinfo.totalprice.HasValue ? qinfo.totalprice.Value.ToString() : "";
            txtProductRemark.Text = qinfo.productremark;
            txtQuremark.Text = qinfo.quremark;
            txtTheme.Text = qinfo.theme;
            dateQu.DateTime = qinfo.quotationdate.Value;
            if (qinfo.customerid.HasValue)
            {
                txtCustomer.Text = m_crmclient.getCustomerbyid(qinfo.customerid.Value).customername;
            }
        }
        private void GetData(T_quotation qinfo)
        {
            qinfo.qutationno = txtQuno.Text;
            qinfo.theme = txtTheme.Text;
            qinfo.totalprice = txtTotalPrice.Text == "" ? 0 : Convert.ToDecimal(txtTotalPrice.Text);
            qinfo.productremark = txtProductRemark.Text;
            qinfo.quremark = txtQuremark.Text;
            if (dateQu.Text == "")
            {
                qinfo.quotationdate = null;
            }
            else
            {
                qinfo.quotationdate = dateQu.DateTime;
            }
        }
        protected override void AddObject()
        {            
            GetData(m_Qinfo);
            gvQtprice.CloseEditor();
            m_crmclient.AddNewQtAndQtprice(m_Qinfo, m_QtProductlst);
            base.AddObject();
        }

        protected override void EditObject()
        {
            GetData(m_Qinfo);
            gvQtprice.CloseEditor();
            m_crmclient.UpdateQuotation(m_Qinfo);
            base.EditObject();
        }        
        protected override void DeleteObject()
        {
            m_crmclient.DeleteQuotation(m_Qinfo);
            base.DeleteObject();
        }
        protected override void custom1()
        {
            SelectProForm frm = new SelectProForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var products = frm.selectProductlst;
                m_Qinfo.customerid = frm.customerID;
                txtCustomer.Text = m_crmclient.getCustomerbyid(m_Qinfo.customerid.Value).customername;
                m_QtProductlst.Clear();
                AddProduct2Qt(products);
            }
        }

        private void AddProduct2Qt(List<T_Product> products)
        {
            foreach (var p in products)
            {
                QtProduct qtproduct = new QtProduct();
                qtproduct.qp = new T_quotationprice();
                qtproduct.qp.productid = p.id;
                qtproduct.productCode = p.procode;
                qtproduct.productName = p.proname;
                qtproduct.productSpec = p.prospecification;
                m_QtProductlst.Add(qtproduct);
            }
            gcQtprice.RefreshDataSource();
        }

        private void gvQtprice_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gvQtprice.CloseEditor();
            if (m_QtProductlst[e.RowHandle].qp.modelprice.HasValue && m_QtProductlst[e.RowHandle].qp.unitprice.HasValue)
            {
                m_QtProductlst[e.RowHandle].qp.quotationprice = m_QtProductlst[e.RowHandle].qp.modelprice.Value + m_QtProductlst[e.RowHandle].qp.unitprice.Value * m_QtProductlst[e.RowHandle].qp.productcount;
            }
            CalQtTotalPrice();
        }
        private void CalQtTotalPrice()
        {
            decimal totalprice = 0;
            var qtpricelst = (List<QtProduct>)gvQtprice.DataSource;
            foreach (var qtprice in qtpricelst)
            {
                if (qtprice.qp.quotationprice.HasValue)
                {
                    totalprice += qtprice.qp.quotationprice.Value;
                }
            }
            txtTotalPrice.Text = totalprice.ToString();
        }

    }
}
