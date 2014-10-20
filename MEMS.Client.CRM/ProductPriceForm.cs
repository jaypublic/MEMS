using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MEMS.Client.Common;
using MEMS.Client.CRM.CRMService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MEMS.Client.CRM
{
    public partial class ProductPriceForm : MEMS.Client.Common.BaseinfoForm
    {
        private int m_pid;
        private CRMServiceClient m_client = new CRMServiceClient();
        private bool newversion = false;
        private T_ProductbasicPrice m_pv;
        public ProductPriceForm(int productid)
        {
            InitializeComponent();
            m_pid = productid;
            base.formmode = frmmodetype.edit;
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            this.ribbonPageGroup2.Visible = true;
            this.barbtn1.Visibility = BarItemVisibility.Always;
            this.barbtn1.Caption = "创建版本";
            this.barbtn1.LargeGlyph = MEMS.Client.CRM.Properties.Resources.edit_32x32;

            retievePrice();
        }
        /// <summary>
        /// 获取所有该产品的价格版本
        /// </summary>
        private void retievePrice()
        {
            var pricelst = m_client.getProductPriceList(m_pid);
            cmbpriceName.Tag = new List<T_ProductbasicPrice>(pricelst);
            foreach (var p in pricelst)
            {
                cmbpriceName.Properties.Items.Add(p.version);
            }
        }

        private void cmbpriceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cmbpriceName.SelectedIndex;
            var pricelist = (List<T_ProductbasicPrice>)cmbpriceName.Tag;
            var priceversion = pricelist[idx];
            setData(priceversion);
            if (newversion && cmbpriceName.SelectedIndex == 0)
            {
                base.readonlytxtbox(this.Controls, false);
            }
            else
            {
                base.readonlytxtbox(this.Controls, true);
            }
            cmbpriceName.Properties.ReadOnly = false;
        }
        /// <summary>
        /// 设置价格信息放入txtbox
        /// </summary>
        /// <param name="pv"></param>
        private void setData(T_ProductbasicPrice pv)
        {
            try
            {
                txtmanageprice.Text = pv.manageprice.HasValue ? pv.manageprice.Value.ToString() : "";
                txtmaterialprice.Text = pv.materialprice.HasValue ? pv.materialprice.Value.ToString() : "";
                txtmaterialpricedesc.Text = pv.materialpricedesc;
                txtmgrpricedesc.Text = pv.mgrpricedesc;
                txtotherprice.Text = pv.otherprice.HasValue ? pv.otherprice.Value.ToString() : "";
                txtotherpricedesc.Text = pv.otherpricedesc;
                txtreturnpricedesc.Text = pv.returnpricedesc;
                txtreturnmatprice.Text = pv.returnmatprice.HasValue ? pv.returnmatprice.Value.ToString() : "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 从txtbox获取价格信息
        /// </summary>
        /// <param name="pv"></param>
        /// <returns></returns>
        private T_ProductbasicPrice getData(T_ProductbasicPrice pv)
        {
            try
            {
                pv.manageprice = Convert.ToDecimal(txtmanageprice.Text);
                pv.materialprice = Convert.ToDecimal(txtmaterialprice.Text);
                pv.materialpricedesc = txtmaterialpricedesc.Text;
                pv.mgrpricedesc = txtmgrpricedesc.Text;
                pv.otherprice = Convert.ToDecimal(txtotherprice.Text);
                pv.otherpricedesc = txtotherpricedesc.Text;
                pv.returnmatprice = Convert.ToDecimal(txtreturnmatprice.Text);
                pv.returnpricedesc = txtreturnpricedesc.Text;                
                return pv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void EditObject()
        {
            if (newversion)
            {
                m_pv = getData((cmbpriceName.Tag as List<T_ProductbasicPrice>)[0]);
                m_pv.productid = m_pid;
                var priceid = m_client.AddNewProductPrice(m_pv);
            }
            base.EditObject();
        }
        protected override void custom1()
        {
            T_ProductbasicPrice pv = new T_ProductbasicPrice();
            pv.version = DateTime.Now.Date.ToString("yyyyMMdd");
            cmbpriceName.Properties.Items.Insert(0, pv.version);
            (cmbpriceName.Tag as List<T_ProductbasicPrice>).Insert(0,pv);
            cmbpriceName.SelectedIndex = 0;
            base.readonlytxtbox(this.Controls, false);
            newversion = true;
            base.barbtn1.Enabled = false;
        }
    }
}
