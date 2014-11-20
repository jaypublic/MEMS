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
        private bool _IsComplexSearch;

        [Description("True:点击查询按钮直接进行查询; False:点击查询按钮显示高级查询栏")]
        [DisplayName("复杂查询")]
        [Category("扩展")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool IsComplexSearch
        {
            get
            {
                return _IsComplexSearch;
            }
            set
            {
                _IsComplexSearch = value;
            }
        }

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
            if (_IsComplexSearch)
            {
                searchButton_Click(sender, null);
            }
            else
            {
                this.searchgroup.Visible = barsearchCheck.Checked;
            }

        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 打开详细窗体并在完成编辑后刷新
        /// </summary>
        /// <param name="newfrm"></param>
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
        /// 继承的窗体载入方法
        /// </summary>
        protected virtual void FormLoad()
        {
            if (this.DesignMode)
                return;
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

        private void barbtn4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom4();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 自定义按钮4的继承执行方法
        /// </summary>
        protected virtual void custom4()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void barbtn5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom5();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 自定义按钮5的继承执行方法
        /// </summary>
        protected virtual void custom5()
        {
            throw new NotImplementedException("方法未实现");
        }

        private void barbtn6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                custom6();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 自定义按钮6的继承执行方法
        /// </summary>
        protected virtual void custom6()
        {
            throw new NotImplementedException("方法未实现");
        }
    }
}