using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using MEMS.Client.Common;
//using MEMS.Client.Main.CRMService;
using DevExpress.XtraEditors;
using MEMS.Client.CRM;
using MEMS.Client.Sale;
using MEMS.Client.MRP;

namespace MEMS.Client.Main
{
    public partial class MainForm : RibbonForm
    {
        private bool islogcancel = false;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!islogcancel)
            {
                if (XtraMessageBox.Show("是否退出系统", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            selectPageCategory.Visible = false;
            this.Visible = false;
            using (var logfrm = new LogonForm())
            {
                if (logfrm.ShowDialog() == DialogResult.OK)
                {
                    this.StartPosition = FormStartPosition.CenterScreen;
                    this.Visible = true;
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Size.Height / 2 - this.Size.Height / 2);

                }
                else
                {
                    islogcancel = true;
                }
            }
            if (islogcancel)
                this.Close();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                {
                    if (ActiveMdiChild is BaseListForm)
                    {
                        selectPageCategory.MergedPages.Clear();
                        var ribbonfrm = ActiveMdiChild as BaseListForm;
                        ribbonfrm.ribbonMenu.Text = ribbonfrm.Text;
                        this.selectPageCategory.MergedPages.Add(ribbonfrm.ribbonMenu);
                        this.selectPageCategory.Visible = true;
                        ribbonControl.SelectedPage = ribbonfrm.ribbonMenu;
                    }
                }
                else
                {
                    selectPageCategory.MergedPages.Clear();
                }
                Console.WriteLine(ribbonControl.MergedPages.Count);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region 客户关系管理
        private void BtnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(CustomerListForm));
        }

        private void BtnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(SupplierListForm));
        }

        private void BtnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(ProductListForm));
            //this.ActivateMdiChild(new ProductListForm());
        }

        private void Btnquotation_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(QuotationListForm));
        }
        #endregion

        #region 销售管理
        private void saleorderItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(SaleOrderListForm));
        }
        private void saleRecieveItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(SaleOrder4RecieveListForm));
        }
        #endregion

        #region 基础管理
        private void barBtnCodeType_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(CodeTypeForm));
        }

        private void barBtnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(UnitForm));
        }

        private void barBtnMaterailType_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(MaterailTypeForm));
        }

        private void barBtnMaterailMode_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(MaterailModeForm));
        }

        private void barBtnMatCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(StandardMaterialListForm));
        }
        #endregion

        #region 采购管理
        private void barBtnPO_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(POListForm));
        }

        private void barBtnPOApproval_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(POApprovalForm));
        }

        private void barBtnPOPay_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(POPayListForm));
        }
        #endregion

        #region 仓储管理
        private void barBtnStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(StockForm));
        }

        private void barBtnEnteringWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(EnteringWarehouseForm));
        }

        private void barBtnUseApply_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(UseApplyForm));
        }
        #endregion



    }
}