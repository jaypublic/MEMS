namespace MEMS.Client.CRM
{
    partial class ProductListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.gcproduct = new DevExpress.XtraGrid.GridControl();
            this.gvproduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtprocode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtproname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbcustomerlst = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprocode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustomerlst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.cmbcustomerlst);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.txtproname);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txtprocode);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Location = new System.Drawing.Point(0, 125);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtprocode, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtproname, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.cmbcustomerlst, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.LargeImages = this.ribbonImageCollectionLarge;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcproduct
            // 
            this.gcproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcproduct.Location = new System.Drawing.Point(0, 125);
            this.gcproduct.MainView = this.gvproduct;
            this.gcproduct.MenuManager = this.ribboncontrol;
            this.gcproduct.Name = "gcproduct";
            this.gcproduct.Size = new System.Drawing.Size(717, 266);
            this.gcproduct.TabIndex = 3;
            this.gcproduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvproduct});
            // 
            // gvproduct
            // 
            this.gvproduct.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvproduct.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvproduct.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gvproduct.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvproduct.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvproduct.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvproduct.AppearancePrint.Row.BackColor = System.Drawing.Color.Red;
            this.gvproduct.AppearancePrint.Row.BackColor2 = System.Drawing.Color.Red;
            this.gvproduct.AppearancePrint.Row.Options.UseBackColor = true;
            this.gvproduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.gvproduct.GridControl = this.gcproduct;
            this.gvproduct.Name = "gvproduct";
            this.gvproduct.OptionsBehavior.Editable = false;
            this.gvproduct.OptionsView.ShowGroupPanel = false;
            this.gvproduct.OptionsView.ShowViewCaption = true;
            this.gvproduct.ViewCaption = "产品列表";
            this.gvproduct.DoubleClick += new System.EventHandler(this.gvproduct_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "customerid";
            this.gridColumn2.FieldName = "customerid";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "产品代码";
            this.gridColumn3.FieldName = "procode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "产品名称";
            this.gridColumn4.FieldName = "proname";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "所属客户";
            this.gridColumn6.FieldName = "customername";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "产品代码";
            // 
            // txtprocode
            // 
            this.txtprocode.Location = new System.Drawing.Point(145, 29);
            this.txtprocode.MenuManager = this.ribboncontrol;
            this.txtprocode.Name = "txtprocode";
            this.txtprocode.Size = new System.Drawing.Size(200, 22);
            this.txtprocode.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(91, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "产品名称";
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(145, 62);
            this.txtproname.MenuManager = this.ribboncontrol;
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(200, 22);
            this.txtproname.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(384, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "所属客户";
            // 
            // cmbcustomerlst
            // 
            this.cmbcustomerlst.Location = new System.Drawing.Point(438, 29);
            this.cmbcustomerlst.MenuManager = this.ribboncontrol;
            this.cmbcustomerlst.Name = "cmbcustomerlst";
            this.cmbcustomerlst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcustomerlst.Properties.HideSelection = false;
            this.cmbcustomerlst.Size = new System.Drawing.Size(200, 22);
            this.cmbcustomerlst.TabIndex = 10;
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "BO_MyDetails_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "Action_Security_ChangePassword_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "BO_Employee_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "Action_Delete_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "Action_Edit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "Action_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "Action_LinkUnlink_Link_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "Action_LinkUnlink_Unlink_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "BO_Sale_v92_32x32.png");
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.gcproduct);
            this.Name = "ProductListForm";
            this.Text = "产品信息";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcproduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprocode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustomerlst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcproduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvproduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtproname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtprocode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbcustomerlst;
        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
    }
}
