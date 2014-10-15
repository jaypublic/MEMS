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
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();            
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
        /// <summary>
        /// 继承的添加方法
        /// </summary>
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
        /// <summary>
        /// 继承的修改方法
        /// </summary>
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
        /// <summary>
        /// 继承的删除方法
        /// </summary>
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
        /// <summary>
        /// 继承的查询方法
        /// </summary>
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
            newfrm.StartPosition = FormStartPosition.CenterParent;
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
        /// <summary>
        /// 窗体载入事件
        /// </summary>
        protected virtual void FormLoad()
        {
            this.searchgroup.Visible = barsearchCheck.Checked;
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
            throw new NotImplementedException("方法未实现");
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
            throw new NotImplementedException("方法未实现");
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
            throw new NotImplementedException("方法未实现");
        }
    }
}