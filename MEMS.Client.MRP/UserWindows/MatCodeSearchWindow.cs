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
    public partial class MatCodeSearchWindow : Form
    {
        public List<T_StandardMaterial> SelectedStandardMaterails
        {
            get
            {
                List<T_StandardMaterial> stdMaterial = new List<T_StandardMaterial>();

                int[] rowHandles = this.gvMaterailCode.GetSelectedRows();
                foreach (int rowHandle in rowHandles)
                {
                    stdMaterial.Add(this.gvMaterailCode.GetRow(rowHandle) as T_StandardMaterial);
                }

                return stdMaterial;
            }
        }

        List<T_StandardMaterial> _MaterailModeList;

        public MatCodeSearchWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.gcMaterialCode.DataSource = null;

            string searchString = this.txt_Search.Text.Trim();
            if (string.IsNullOrEmpty(searchString))
            {
                this.gcMaterialCode.DataSource = this._MaterailModeList;
            }
            else
            {
                this.gcMaterialCode.DataSource = this._MaterailModeList.Where(o => o.MatCode.Contains(searchString) || o.Desc.Contains(searchString) || o.MatModeCode.Contains(searchString) || o.MatTypeCode.Contains(searchString)).ToList();
            }
        }

        private void MatCodeSearchWindow_Load(object sender, EventArgs e)
        {
            ServiceProxy _Proxy = new ServiceProxy();

            this._MaterailModeList = _Proxy.GetStdMatList();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.gvMaterailCode.SelectedRowsCount > 0)
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
    }
}
