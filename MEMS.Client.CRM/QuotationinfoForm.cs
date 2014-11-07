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

namespace MEMS.Client.CRM
{
    public partial class QuotationinfoForm : MEMS.Client.Common.BaseinfoForm
    {
        private CRMService.CRMServiceClient m_crmclient = new CRMService.CRMServiceClient();
        private int m_qid;
        private T_quotation m_Qinfo;
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
            barbtn1.Visibility = BarItemVisibility.Always;
            barbtn1.LargeImageIndex = 9;
            barbtn1.Caption = "添加产品";
            barbtn2.Visibility = BarItemVisibility.Always;
            barbtn2.LargeImageIndex = 10;
            barbtn2.Caption = "移除产品";
            txtTotalPrice.Properties.ReadOnly = true;
            var customerlst = m_crmclient.getCustomerList();
            cmbcustomer.Tag = new List<T_Customer>(customerlst);
            foreach (var c in customerlst)
            {
                cmbcustomer.Properties.Items.Add(c.customername);
            }
            if (formmode==frmmodetype.edit)
            {
                m_Qinfo = m_crmclient.getQuotationbyId(m_qid);
                SetData(m_Qinfo);
            }
            else if (formmode == frmmodetype.delete)
            {
                m_Qinfo = m_crmclient.getQuotationbyId(m_qid);
                SetData(m_Qinfo);
                base.readonlytxtbox(this.xtraTabPage1.Controls, true);
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
            var clst = (List<T_Customer>)cmbcustomer.Tag;
            var customer = clst.Find(c => c.id == qinfo.customerid);
            cmbcustomer.SelectedText = customer.customername;
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
            if (cmbcustomer.SelectedIndex == -1)
            {
                throw new Exception("请选择报价单客户");
            }
            else
            {
                var clst = (List<T_Customer>)cmbcustomer.Tag;
                var customer = clst[cmbcustomer.SelectedIndex];
                qinfo.customerid = customer.id;
            }
        }
        protected override void AddObject()
        {
            m_Qinfo = new T_quotation();
            GetData(m_Qinfo);
            m_crmclient.AddNewQuotation(m_Qinfo);
            base.AddObject();
        }
        protected override void EditObject()
        {
            GetData(m_Qinfo);
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

            SelectProForm frm = new SelectProForm(1);
        }
        protected override void custom2()
        {
            
        }
    }
}
