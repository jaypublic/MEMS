using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Sale.SaleService;
using DevExpress.XtraEditors;

namespace MEMS.Client.Sale
{
    public partial class SaleOrderListForm : MEMS.Client.Common.BaseListForm
    {
        SaleServiceClient m_SaleClient = new SaleServiceClient();
        public SaleOrderListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var saleOrderList = m_SaleClient.getAllSaleOrderList();
            this.gcSaleOrder.DataSource = saleOrderList;
        }
        protected override void AddObject()
        {

        }
        protected override void EditObject()
        {
            
        }
        protected override void DeleteObject()
        {
            
        }
        protected override void FormLoad()
        {
            //DisPlayEnum.getEnumDS(lkupOrderState, typeof(orderState));
            cmborderstate.Items.AddRange(DisPlayEnum.getEnumDS(typeof(orderState)));
            //cmborderstate.OwnerEdit.Text = cmborderstate.OwnerEdit.SelectedText;
            //(ComboBoxEdit)cmborderstate).EditValue = (cmborderstate as ComboBoxEdit).SelectedText;
            //ComboBoxEdit cmb=cmborderstate;
            //cmborderstate.Items.
            base.FormLoad();
        }

        private void cmborderstate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //ComboBoxEdit cmb = (ComboBoxEdit)sender;
            //cmb.EditValue = cmb.SelectedText;
            Console.WriteLine(cmborderstate.Items.Count);
        }
    }

    
}
