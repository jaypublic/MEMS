namespace MEMS.Client.MRP
{
    partial class CodeTypeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MatCodeTreeList = new DevExpress.XtraTreeList.TreeList();
            this.CodeColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DescColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatCodeTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(551, 220, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(707, 233);
            this.layoutControl1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(707, 233);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // MatCodeTreeList
            // 
            this.MatCodeTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.CodeColumn,
            this.DescColumn});
            this.MatCodeTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatCodeTreeList.KeyFieldName = "Id";
            this.MatCodeTreeList.Location = new System.Drawing.Point(0, 225);
            this.MatCodeTreeList.Name = "MatCodeTreeList";
            this.MatCodeTreeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.MatCodeTreeList.ParentFieldName = "ParentId";
            this.MatCodeTreeList.Size = new System.Drawing.Size(717, 166);
            this.MatCodeTreeList.TabIndex = 3;
            // 
            // CodeColumn
            // 
            this.CodeColumn.Caption = "编码类别";
            this.CodeColumn.FieldName = "Code";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.Visible = true;
            this.CodeColumn.VisibleIndex = 0;
            // 
            // DescColumn
            // 
            this.DescColumn.Caption = "描述";
            this.DescColumn.FieldName = "Desc";
            this.DescColumn.Name = "DescColumn";
            this.DescColumn.Visible = true;
            this.DescColumn.VisibleIndex = 1;
            // 
            // CodeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.MatCodeTreeList);
            this.IsComplexSearch = true;
            this.Name = "CodeTypeForm";
            this.Text = "编码类别管理";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.MatCodeTreeList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatCodeTreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraTreeList.TreeList MatCodeTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CodeColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DescColumn;


    }
}
