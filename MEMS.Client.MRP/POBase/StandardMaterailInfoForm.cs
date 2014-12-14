using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Common;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Proxy;

namespace MEMS.Client.MRP
{
    public partial class StandardMaterailInfoForm : BaseinfoForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public T_StandardMaterial StandardMaterail;

        /// <summary>
        /// 单位编码 
        /// </summary>
        public string MatCode
        {
            get
            {
                string matCode = string.Empty;
                if (this.BigComboBox.SelectedItem != null)
                {
                    matCode += (this.BigComboBox.SelectedItem as T_CodeType).Code;
                }

                if (this.MidComboBox.SelectedItem != null)
                {
                    matCode += (this.MidComboBox.SelectedItem as T_CodeType).Code;
                }

                if (this.SmallComboBox.SelectedItem != null)
                {
                    matCode += (this.SmallComboBox.SelectedItem as T_CodeType).Code;
                }

                matCode += IndexTextBox.Text;

                return matCode;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 9)
                {
                    this.BigComboBox.Text = value.Substring(0, 2);
                    this.MidComboBox.Text = value.Substring(2, 2);
                    this.SmallComboBox.Text = value.Substring(4, 2);
                    this.IndexTextBox.Text = value.Substring(6, 3);
                }
            }
        }

        private bool _IsEdit = false;
        public bool IsEdit
        {
            get { return _IsEdit; }
            set
            {
                if (value)
                {
                    this.BigComboBox.Enabled = false;
                    this.MidComboBox.Enabled = false;
                    this.SmallComboBox.Enabled = false;
                }
            }
        }

        public StandardMaterailInfoForm(frmmodetype type)
        {
            InitializeComponent();
            base.formmode = type;
        }

        protected override void FormLoad()
        {
            base.FormLoad();

            this.BigComboBox.DataSource = _Proxy.GetChildCodeTypeList(-1);
            this.MatTypeComboBox.DataSource = _Proxy.GetMatTypeList();
            this.MatModeComboBox.DataSource = _Proxy.GetMatModeList();

            if (base.formmode != frmmodetype.add && StandardMaterail != null)
            {
                this.MatCode = StandardMaterail.MatCode;
                this.MatTypeComboBox.Text = StandardMaterail.MatTypeCode;
                this.MatModeComboBox.Text = StandardMaterail.MatModeCode;
                this.DescTextBox.Text = StandardMaterail.MatDesc;

                this.BigComboBox.Enabled = false;
                this.MidComboBox.Enabled = false;
                this.SmallComboBox.Enabled = false;
                this.IndexTextBox.Enabled = false;
            }
        }

        protected override void AddObject()
        {
            if (string.IsNullOrWhiteSpace(MatCode) || MatCode.Length != 9)
            {
                MessageBox.Show("编码信息填写有误");
                return;
            }

            if (_Proxy.CheckMatCode(MatCode))
            {
                MessageBox.Show("错误，标准物资编码重复");
                return;
            }

            T_StandardMaterial item = new T_StandardMaterial()
            {
                MatCode = this.MatCode,
                MatTypeCode = this.MatTypeComboBox.SelectedValue.ToString(),
                MatModeCode = this.MatModeComboBox.SelectedValue.ToString(),
                MatDesc = this.DescTextBox.Text
            };

            _Proxy.AddStdMat(item);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void EditObject()
        {
            StandardMaterail.MatTypeCode = this.MatTypeComboBox.Text;
            StandardMaterail.MatModeCode = this.MatModeComboBox.Text;
            StandardMaterail.MatDesc = this.DescTextBox.Text;

            _Proxy.UpdateStdMat(StandardMaterail);
            //base.EditObject();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void DeleteObject()
        {
            //base.DeleteObject();
        }

        private void BigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parentId = ((sender as ComboBox).SelectedItem as T_CodeType).Id;
            this.MidComboBox.DataSource = null;
            this.MidComboBox.DataSource = _Proxy.GetChildCodeTypeList(parentId);
        }

        private void MidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parentId = ((sender as ComboBox).SelectedItem as T_CodeType).Id;
            this.SmallComboBox.DataSource = null;
            this.SmallComboBox.DataSource = _Proxy.GetChildCodeTypeList(parentId);
        }
    }
}
