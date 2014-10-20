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
        /// <summary>
        /// 确定按钮在窗体删除模式下的执行方法
        /// </summary>
        protected virtual void DeleteObject()
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 确定按钮在窗体修改模式下的执行方法
        /// </summary>
        protected virtual void EditObject()
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 确定按钮在窗体新建模式下的执行方法
        /// </summary>
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
        protected void readonlytxtbox(Control.ControlCollection controlCollection,Boolean enable)
        {
            foreach (Control txtbox in controlCollection)
            {
                if (txtbox is TextEdit )
                {

                    (txtbox as TextEdit).Properties.ReadOnly = enable;

                }
                else
                {
                    readonlytxtbox(txtbox.Controls, enable);
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
            try
            {
                cancelBtn();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消按钮的继承执行方法
        /// </summary>
        protected virtual void cancelBtn()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void barbtn1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom1();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 自定义按钮1的继承执行方法
        /// </summary>
        protected virtual void custom1()
        {
            throw new NotImplementedException();
        }

        private void barbtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom2();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 自定义按钮2的继承执行方法
        /// </summary>
        protected virtual void custom2()
        {
            throw new NotImplementedException();
        }
        private void barbtn3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom3();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 自定义按钮3的继承执行方法
        /// </summary>
        protected virtual void custom3()
        {
            throw new NotImplementedException();
        }
    }
}