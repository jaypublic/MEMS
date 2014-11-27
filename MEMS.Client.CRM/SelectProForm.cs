using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.CRM.CRMService;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMS.Client.CRM
{
    public partial class SelectProForm : MEMS.Client.Common.BaseinfoForm
    {
        /// <summary>
        /// get selected Product
        /// </summary>
        public List<T_Product> selectProductlst { get; private set; }
        public int customerID { get; private set; }
        CRMServiceClient m_crmclient = new CRMServiceClient();
        private SelectStep frmSelectStep;
        public enum SelectStep
        {
            /// <summary>
            /// 客户选择
            /// </summary>
            Customer,
            /// <summary>
            /// 产品选择
            /// </summary>
            Product
        }

        public SelectProForm()
        {
            InitializeComponent();
            
        }
        protected override void FormLoad()
        {
            frmSelectStep = SelectStep.Customer;
            this.ribbonControl1.LargeImages = this.selectProImage;
            this.okButton.Visibility = BarItemVisibility.Never;
            //this.okButton.LargeImageIndex = 7;
            this.barbtn1.Visibility = BarItemVisibility.Always;
            barbtn1.LargeImageIndex = 12;
            barbtn1.Caption = "上一步";
            barbtn1.Enabled = false;
            this.barbtn2.Visibility = BarItemVisibility.Always;
            barbtn2.LargeImageIndex = 13;
            barbtn2.Caption = "下一步";

            SetCustomerGrid();
        }

        private void SetCustomerGrid()
        {
            var clst = m_crmclient.getCustomerList();
            gcCustomer.DataSource = clst;
            gcCustomer.Dock = DockStyle.Fill;
            gcCustomer.BringToFront();
        }
        private void SetProductGrid(int cid)
        {
            var plst = m_crmclient.getProductListbyCid(cid);
            gcProduct.DataSource = plst;
            gcProduct.Dock = DockStyle.Fill;
            gcProduct.BringToFront();
        }
        protected override void custom1()
        {
            //设置按键图文字及窗口状态
            this.barbtn1.Visibility = BarItemVisibility.Always;
            barbtn1.LargeImageIndex = 12;
            barbtn1.Caption = "上一步";
            barbtn1.Enabled = false;
            this.barbtn2.Visibility = BarItemVisibility.Always;
            barbtn2.LargeImageIndex = 13;
            barbtn2.Caption = "下一步";
            frmSelectStep = SelectStep.Customer;

            SetCustomerGrid();
        }
        protected override void custom2()
        {
            if (frmSelectStep == SelectStep.Customer)
            {
                if (gvCustomer.DataRowCount > 0)
                {
                    //设置按钮图片文字及窗口状态
                    frmSelectStep = SelectStep.Product;
                    barbtn1.Enabled = true;
                    barbtn2.Caption = "完成";
                    barbtn2.LargeImageIndex = 4;
                    customerID = (int)gvCustomer.GetFocusedRowCellValue("id");
                    SetProductGrid(customerID);
                }
            }
            else
            {
                selectProductlst = new List<T_Product>();
                var idx = gvProduct.GetSelectedRows();
                if(idx.Length==0)
                {
                    XtraMessageBox.Show("未有选中的产品");
                    return;
                }
                for (int i = 0; i < idx.Length; i++)
                {
                    selectProductlst.Add((T_Product)gvProduct.GetRow(idx[i]));
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void gvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (gvCustomer.DataRowCount > 0)
            {
                //设置按钮图片文字及窗口状态
                frmSelectStep = SelectStep.Product;
                barbtn1.Enabled = true;
                barbtn2.Caption = "完成";
                barbtn2.LargeImageIndex = 4;
                customerID = (int)gvCustomer.GetFocusedRowCellValue("id");
                SetProductGrid(customerID);
            }
        }
    }
}
