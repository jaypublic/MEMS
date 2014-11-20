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
    public partial class ApprovalWindow : Form
    {
        public bool IsAccept
        {
            get
            {
                if (this.AcceptRadioButton.Checked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string ApprovalRemark
        {
            get
            {
                return this.ApprovalRemarkTextBox.Text;
            }
        }

        public ApprovalWindow()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
