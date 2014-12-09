using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Proxy;

namespace MEMS.Client.MRP.UserWindows
{
    public partial class StockMaterialsSearchWindow : Form
    {
        ServiceProxy _Proxy = new ServiceProxy();
        public List<T_StockMaterial> SelectedStockMaterails
        {
            get
            {
                List<T_StockMaterial> selectedMaterials = new List<T_StockMaterial>();

                int[] rowHandles = this.gvStockMaterails.GetSelectedRows();
                foreach (int rowHandle in rowHandles)
                {
                    selectedMaterials.Add(this.gvStockMaterails.GetRow(rowHandle) as T_StockMaterial);
                }

                return selectedMaterials;
            }
        }

        List<T_StockMaterial> _AllStockMaterailList;

        public StockMaterialsSearchWindow()
        {
            InitializeComponent();
        }

        private void StockMaterialsSearchWindow_Load(object sender, EventArgs e)
        {
            _AllStockMaterailList = _Proxy.GetMergeStockMaterials();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.gvStockMaterails.SelectedRowsCount > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请选择物资编码");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.gcStockMaterials.DataSource = null;

            string searchString = this.txt_Search.Text.Trim();
            if (string.IsNullOrEmpty(searchString))
            {
                this.gcStockMaterials.DataSource = this._AllStockMaterailList;
            }
            else
            {
                this.gcStockMaterials.DataSource = this._AllStockMaterailList.Where(o => o.MatCode.Contains(searchString) || o.MatDesc.Contains(searchString) || o.MatModeCode.Contains(searchString) || o.MatTypeCode.Contains(searchString)).ToList();
            }
        }
    }
}
