using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Sale.SaleService;

namespace MEMS.Client.Sale
{
    public partial class SaleListForm : MEMS.Client.Common.BaseListForm
    {
        SaleServiceClient m_SaleClient = new SaleServiceClient();
        public SaleListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var saleOrderList = m_SaleClient.getAllSaleOrderList();
            this.gcSaleOrder.DataSource = saleOrderList;
            //gvSaleOrder.Columns[5].
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
            base.FormLoad();
        }
    }
}
