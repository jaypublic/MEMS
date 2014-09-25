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
            this.gcproduct = new DevExpress.XtraGrid.GridControl();
            this.gvproduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtprocode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtproname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtdrawingno = new DevExpress.XtraEditors.TextEdit();
            this.cmbcustomerlst = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprocode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdrawingno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustomerlst.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.cmbcustomerlst);
            this.searchgroup.Controls.Add(this.txtdrawingno);
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.txtproname);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txtprocode);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtprocode, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtproname, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtdrawingno, 0);
            this.searchgroup.Controls.SetChildIndex(this.cmbcustomerlst, 0);
            // 
            // ribbonControl1
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcproduct
            // 
            this.gcproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcproduct.Location = new System.Drawing.Point(0, 198);
            this.gcproduct.MainView = this.gvproduct;
            this.gcproduct.MenuManager = this.ribboncontrol;
            this.gcproduct.Name = "gcproduct";
            this.gcproduct.Size = new System.Drawing.Size(717, 193);
            this.gcproduct.TabIndex = 3;
            this.gcproduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvproduct});
            // 
            // gvproduct
            // 
            this.gvproduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "产品图号";
            this.gridColumn5.FieldName = "drawingno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "所属客户";
            this.gridColumn6.FieldName = "customername";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
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
            this.txtprocode.Size = new System.Drawing.Size(200, 20);
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
            this.txtproname.Size = new System.Drawing.Size(200, 20);
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(384, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "产品图号";
            // 
            // txtdrawingno
            // 
            this.txtdrawingno.Location = new System.Drawing.Point(438, 62);
            this.txtdrawingno.MenuManager = this.ribboncontrol;
            this.txtdrawingno.Name = "txtdrawingno";
            this.txtdrawingno.Size = new System.Drawing.Size(200, 20);
            this.txtdrawingno.TabIndex = 8;
            // 
            // cmbcustomerlst
            // 
            this.cmbcustomerlst.Location = new System.Drawing.Point(438, 29);
            this.cmbcustomerlst.MenuManager = this.ribboncontrol;
            this.cmbcustomerlst.Name = "cmbcustomerlst";
            this.cmbcustomerlst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcustomerlst.Properties.HideSelection = false;
            this.cmbcustomerlst.Size = new System.Drawing.Size(200, 20);
            this.cmbcustomerlst.TabIndex = 10;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtdrawingno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustomerlst.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcproduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvproduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.TextEdit txtdrawingno;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtproname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtprocode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbcustomerlst;
    }
}
