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
    public partial class BaseListForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseListForm()
        {
            InitializeComponent();
            this.searchgroup.Visible = barsearchCheck.Checked;
        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AddObject();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
        }

        protected virtual void AddObject()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                EditObject();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                
            }
            
        }

        protected virtual void EditObject()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void barDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DeleteObject();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
        }

        protected virtual void DeleteObject()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchObject();
                this.searchgroup.Visible = barsearchCheck.Checked = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }

        protected virtual void SearchObject()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void barsearchCheck_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.searchgroup.Visible = barsearchCheck.Checked;
        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        protected void refreshFormData(BaseinfoForm newfrm)
        {
            if (newfrm.ShowDialog() == DialogResult.OK)
            {
                SearchObject();
            }
        }

        private void BaseListForm_Load(object sender, EventArgs e)
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
            
        }

        private void barSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SearchObject();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}