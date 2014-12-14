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
    public partial class EnteringWindow : Form
    {
        ServiceProxy _Proxy = new ServiceProxy();

        /// <summary>
        /// 库位编码 
        /// </summary>
        public T_StockCode StockCode
        {
            get
            {
                if (this.StockCodeComboBox.SelectedItem == null)
                {
                    return null;
                }
                else
                {
                    return this.StockCodeComboBox.SelectedItem as T_StockCode;
                }
            }
            set
            {
                this.StockCodeComboBox.SelectedItem = value;
            }
        }

        /// <summary>
        /// 入库数量 
        /// </summary>
        public decimal EnteringQuantity
        {
            get { return this.CountNUD.Value; }
            set
            {
                this.CountNUD.Value = value;
            }
        }

        /// <summary>
        /// 库位已有采购单该物资
        /// </summary>
        public decimal ExistQuantity;
        
        /// <summary>
        /// 应入库总量 
        /// </summary>
        public decimal Quantity;

        /// <summary>
        /// 物资信息
        /// </summary>
        public T_StandardMaterial Material;


        public EnteringWindow()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (StockCode == null)
            {
                MessageBox.Show("请选择库位编码");
            }

            if (this.CountNUD.Value > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void EnteringWindow_Load(object sender, EventArgs e)
        {
            this.StockCodeComboBox.DataSource = _Proxy.GetStockCodeList();

            this.Text = string.Format("{0}({1}入库窗体", Material.MatDesc, Material.MatCode);
            this.QuantityInfoLabel.Text = string.Format("({0}/{1})", ExistQuantity, Quantity);
            this.CountNUD.Maximum = Quantity - ExistQuantity;
        }

        private void StockCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.StockCodeComboBox.SelectedItem == null)
            {
                this.StockDescLabel.Text = string.Empty;
            }
            else
            {
                this.StockDescLabel.Text = (this.StockCodeComboBox.SelectedItem as T_StockCode).Desc;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
