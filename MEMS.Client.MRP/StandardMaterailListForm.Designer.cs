namespace MEMS.Client.MRP
{
    partial class StandardMaterialListForm
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
            this.gvMaterailCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvMatTypeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvMatModeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcMaterialCode = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterailCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatTypeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatModeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterialCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Location = new System.Drawing.Point(0, 125);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gvMaterailCode
            // 
            this.gvMaterailCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2});
            this.gvMaterailCode.CustomizationFormBounds = new System.Drawing.Rectangle(587, 385, 216, 187);
            this.gvMaterailCode.GridControl = this.gcMaterialCode;
            this.gvMaterailCode.Name = "gvMaterailCode";
            this.gvMaterailCode.OptionsBehavior.Editable = false;
            this.gvMaterailCode.OptionsView.ShowGroupPanel = false;
            this.gvMaterailCode.OptionsView.ShowViewCaption = true;
            this.gvMaterailCode.ViewCaption = "标准物资列表";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "编码";
            this.gridColumn10.FieldName = "MatCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "描述";
            this.gridColumn11.FieldName = "Desc";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "物资类型";
            this.gridColumn1.ColumnEdit = this.gvMatTypeEdit;
            this.gridColumn1.FieldName = "MatTypeCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gvMatTypeEdit
            // 
            this.gvMatTypeEdit.AutoHeight = false;
            this.gvMatTypeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvMatTypeEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvMatTypeEdit.DisplayMember = "Desc";
            this.gvMatTypeEdit.Name = "gvMatTypeEdit";
            this.gvMatTypeEdit.ValueMember = "Code";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "规格型号";
            this.gridColumn2.ColumnEdit = this.gvMatModeEdit;
            this.gridColumn2.FieldName = "MatModeCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gvMatModeEdit
            // 
            this.gvMatModeEdit.AutoHeight = false;
            this.gvMatModeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvMatModeEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvMatModeEdit.DisplayMember = "Desc";
            this.gvMatModeEdit.Name = "gvMatModeEdit";
            this.gvMatModeEdit.ValueMember = "Code";
            // 
            // gcMaterialCode
            // 
            this.gcMaterialCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMaterialCode.Location = new System.Drawing.Point(0, 225);
            this.gcMaterialCode.MainView = this.gvMaterailCode;
            this.gcMaterialCode.Name = "gcMaterialCode";
            this.gcMaterialCode.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvMatTypeEdit,
            this.gvMatModeEdit});
            this.gcMaterialCode.Size = new System.Drawing.Size(717, 166);
            this.gcMaterialCode.TabIndex = 3;
            this.gcMaterialCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterailCode,
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcMaterialCode;
            this.gridView2.Name = "gridView2";
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
            // StandardMaterialListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.gcMaterialCode);
            this.Name = "StandardMaterialListForm";
            this.Text = "标准物资管理";
            this.Load += new System.EventHandler(this.StandardMaterialListForm_Load);
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcMaterialCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterailCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatTypeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatModeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterialCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcMaterialCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterailCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvMatTypeEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvMatModeEdit;


    }
}
