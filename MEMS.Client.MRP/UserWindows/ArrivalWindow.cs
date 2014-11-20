using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.MRP.Enums;
using MEMS.Client.MRP.Toolkit;

namespace MEMS.Client.MRP.UserWindows
{
    public partial class ArrivalWindow : Form
    {
        public string SelectedDate
        {
            get
            {
                return this.SelectedDateEdit.DateTime.ToString("yyyy-MM-dd");

            }
        }

        public string Remark
        {
            get
            {
                return this.RemarkTextBox.Text;
            }
        }

        public short ArrivalStatus
        {
            get
            {
                return Convert.ToInt16(this.ArrivalStatusComboBox.SelectedValue);
            }
        }

        public ArrivalWindow()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            this.SelectedDateEdit.EditValue = new DateTime(now.Year, now.Month, now.Day);

            this.ArrivalStatusComboBox.DataSource = EnumTool.GetDataSource(typeof(ArrivalStatus));
            this.ArrivalStatusComboBox.SelectedIndex = 1;
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
