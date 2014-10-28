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
        private List<T_Crafts> m_craftlst;
        private List<T_CraftsPrice> m_craftpricelst;
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
            base.readonlytxtbox(this.Controls, true);
            cmbpriceName.Properties.ReadOnly = false;
            retievePrice();
            retieveCraft();
        }
        /// <summary>
        /// 获取所有该产品的工序价格版本
        /// </summary>
        private void retieveCraft()
        {
            m_craftlst = new List<T_Crafts>(m_client.getProductCraft(m_pid));
            m_craftpricelst = new List<T_CraftsPrice>(m_client.getCraftPriceList(m_pid));
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
            var craftpricelst = m_craftpricelst.FindAll(p => p.pricebasicid == priceversion.id);
            gccraftprice.DataSource = craftpricelst;
            gvcraftprice.Columns["processprice"].OptionsColumn.AllowEdit = false;
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
        private T_ProductbasicPrice getDataFromTxt(T_ProductbasicPrice pv)
        {
            try
            {
                pv.manageprice = txtmanageprice.Text == string.Empty ? 0 : Convert.ToDecimal(txtmanageprice.Text);
                pv.materialprice = txtmaterialprice.Text == string.Empty ? 0 : Convert.ToDecimal(txtmaterialprice.Text);
                pv.materialpricedesc = txtmaterialpricedesc.Text;
                pv.mgrpricedesc = txtmgrpricedesc.Text;
                pv.otherprice = txtotherprice.Text == "" ? 0 : Convert.ToDecimal(txtotherprice.Text);
                pv.otherpricedesc = txtotherpricedesc.Text;
                pv.returnmatprice = txtreturnmatprice.Text == "" ? 0 : Convert.ToDecimal(txtreturnmatprice.Text);
                pv.returnpricedesc = txtreturnpricedesc.Text;
                return pv;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 保存价格
        /// </summary>
        protected override void EditObject()
        {
            if (newversion)
            {
                m_pv = getDataFromTxt((cmbpriceName.Tag as List<T_ProductbasicPrice>)[0]);
                m_pv.productid = m_pid;                
                var newcraftpricelst = (List<T_CraftsPrice>)gccraftprice.DataSource;
                gvcraftprice.CloseEditor();                
                foreach (var newcraftprice in newcraftpricelst)
                {
                    if (!newcraftprice.processprice.HasValue)
                    {
                        throw new Exception("工序" + newcraftprice.processname + "未输入值");
                    }
                }
                var success = m_client.AddNewProductPrice(m_pv, newcraftpricelst.ToArray());
            }
            base.EditObject();
        }
        /// <summary>
        /// 新增价格版本
        /// </summary>
        protected override void custom1()
        {
            T_ProductbasicPrice pv = new T_ProductbasicPrice();
            var verstring = m_client.getPriceVersion(m_pid);
            pv.version = DateTime.Now.Date.ToString("yyyyMMdd") + verstring;
            cmbpriceName.Properties.Items.Insert(0, pv.version);
            (cmbpriceName.Tag as List<T_ProductbasicPrice>).Insert(0, pv);
            cmbpriceName.SelectedIndex = 0;
            base.readonlytxtbox(this.Controls, false);
            newversion = true;
            base.barbtn1.Enabled = false;
            List<T_CraftsPrice> newcraftpricelst = new List<T_CraftsPrice>();
            foreach (var craft in m_craftlst)
            {
                var craftprice = new T_CraftsPrice();
                craftprice.pid = craft.pid;
                craftprice.processid = craft.id;
                craftprice.processidx = craft.processindex;
                craftprice.processname = craft.processname;
                newcraftpricelst.Add(craftprice);
            }
            gccraftprice.DataSource = newcraftpricelst;
            gvcraftprice.Columns["processprice"].OptionsColumn.AllowEdit = true;
            txttotalprice.Properties.ReadOnly = true;
        }

        /// <summary>
        /// 计算总价
        /// </summary>
        private void CalTotalPrice()
        {
            var manageprice = txtmanageprice.Text == string.Empty ? 0 : Convert.ToDecimal(txtmanageprice.Text);
            var materialprice = txtmaterialprice.Text == string.Empty ? 0 : Convert.ToDecimal(txtmaterialprice.Text);
            var otherprice = txtotherprice.Text == "" ? 0 : Convert.ToDecimal(txtotherprice.Text);
            var returnmatprice = txtreturnmatprice.Text == "" ? 0 : Convert.ToDecimal(txtreturnmatprice.Text);
            Decimal craftprice = 0;
            var cplst = (List<T_CraftsPrice>)gvcraftprice.DataSource;
            if (cplst != null)
            {
                foreach (var cp in cplst)
                {
                    if (cp.processprice.HasValue)
                    {
                        craftprice += cp.processprice.Value;
                    }
                }
            }
            txttotalprice.Text = (manageprice + materialprice + otherprice + craftprice - returnmatprice).ToString();
        }
        private void txtreturnmatprice_EditValueChanged(object sender, EventArgs e)
        {
            CalTotalPrice();
        }

        private void txtmaterialprice_EditValueChanged(object sender, EventArgs e)
        {
            CalTotalPrice();
        }

        private void txtotherprice_EditValueChanged(object sender, EventArgs e)
        {
            CalTotalPrice();
        }

        private void txtmanageprice_EditValueChanged(object sender, EventArgs e)
        {
            CalTotalPrice();
        }

        private void gvcraftprice_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CalTotalPrice();
        }
    }
}
