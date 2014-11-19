using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEMS.Client.MRP.UserWindows
{
    public partial class CodeEditWindow : Form
    {
        /// <summary>
        /// 单位编码 
        /// </summary>
        public string Code
        {
            get { return this.txt_Code.Text; }
            set
            {
                this.txt_Code.Text = value;
            }
        }

        /// <summary>
        /// 描述 
        /// </summary>
        public string Desc
        {
            get { return this.txt_Desc.Text; }
            set
            {
                this.txt_Desc.Text = value;
            }
        }


        public CodeEditWindow()
        {
            InitializeComponent();
        }

        public CodeEditWindow(int codeLength, CharacterCasing casing, bool isEdit)
        {
            InitializeComponent();

            this.txt_Code.MaxLength = codeLength;
            this.txt_Code.CharacterCasing = casing;
            this.txt_Code.ReadOnly = isEdit;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txt_Code.Text))
            {
                MessageBox.Show("编码信息填写有误");
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
