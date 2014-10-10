using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MEMS.Client.Common
{
    public partial class BaseinfoForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected frmmodetype formmode;
        public BaseinfoForm()
        {
            InitializeComponent();
        }

        protected virtual void DeleteObject()
        {
            this.DialogResult = DialogResult.OK;
        }

        protected virtual void EditObject()
        {
            this.DialogResult = DialogResult.OK;
        }

        protected virtual void AddObject()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BaseinfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormLoad();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        protected virtual void FormLoad()
        {
            switch (formmode)
            {
                case frmmodetype.add:
                    this.Text += "—新增";
                    this.okButton.Caption = "添加";
                    break;
                case frmmodetype.edit:
                    this.Text += "—修改";
                    this.okButton.Caption = "保存";
                    break;
                case frmmodetype.delete:
                    this.Text += "—删除";
                    this.okButton.Caption = "删除";
                    break;
            }
        }
        protected void enabletxtbox(Control.ControlCollection controlCollection)
        {
            foreach (Control txtbox in controlCollection)
            {
                if (txtbox is TextEdit)
                {
                    txtbox.Enabled = false;
                }
                else
                {
                    enabletxtbox(txtbox.Controls);
                }
            }
        }

        private void okButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (formmode)
                {
                    case frmmodetype.add:
                        AddObject();
                        break;
                    case frmmodetype.edit:
                        EditObject();
                        break;
                    case frmmodetype.delete:
                        DeleteObject();
                        break;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}