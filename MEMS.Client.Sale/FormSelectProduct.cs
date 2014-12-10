using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Sale.CRMService;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMS.Client.Sale
{
    public partial class FormSelectProduct : MEMS.Client.Common.BaseinfoForm
    {
        int m_qtid = 0;
        CRMServiceClient m_crmclient = new CRMServiceClient();
        public List<QtProduct> selectQtProduct { get; set; }
        public FormSelectProduct(int qtid)
        {
            InitializeComponent();
            m_qtid = qtid;
        }
        protected override void FormLoad()
        {
            base.FormLoad();
            var qtProductList = m_crmclient.getQtProduct(m_qtid);
            gcQtProduct.DataSource = qtProductList;
        }
        protected override void AddObject()
        {
            selectQtProduct = new List<QtProduct>();
            var rowidx = gvQtProduct.GetSelectedRows();
            if (rowidx.Length == 0)
            {
                throw new Exception("未有选中的产品");                
            }
            foreach (var idx in rowidx)
            {
                selectQtProduct.Add((QtProduct)gvQtProduct.GetRow(idx));
            }
            base.AddObject();
        }
    }
}
