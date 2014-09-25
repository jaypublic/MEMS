namespace MEMS.Client.CRM
{
    partial class SupplierListForm
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
            this.gcsupplier = new DevExpress.XtraGrid.GridControl();
            this.gvsupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsplyno = new DevExpress.XtraEditors.TextEdit();
            this.txtsplyname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsplyno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsplyname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.txtsplyname);
            this.searchgroup.Controls.Add(this.txtsplyno);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtsplyno, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtsplyname, 0);
            // 
            // ribbonControl1
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcsupplier
            // 
            this.gcsupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcsupplier.Location = new System.Drawing.Point(0, 198);
            this.gcsupplier.MainView = this.gvsupplier;
            this.gcsupplier.MenuManager = this.ribboncontrol;
            this.gcsupplier.Name = "gcsupplier";
            this.gcsupplier.Size = new System.Drawing.Size(717, 193);
            this.gcsupplier.TabIndex = 3;
            this.gcsupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvsupplier});
            // 
            // gvsupplier
            // 
            this.gvsupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvsupplier.GridControl = this.gcsupplier;
            this.gvsupplier.Name = "gvsupplier";
            this.gvsupplier.OptionsBehavior.Editable = false;
            this.gvsupplier.OptionsView.ShowGroupPanel = false;
            this.gvsupplier.OptionsView.ShowViewCaption = true;
            this.gvsupplier.ViewCaption = "供应商列表";
            this.gvsupplier.DoubleClick += new System.EventHandler(this.gvsupplier_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "供应商编号";
            this.gridColumn2.FieldName = "supplierno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "供应商名称";
            this.gridColumn3.FieldName = "suppliername";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "供应商简称";
            this.gridColumn4.FieldName = "simplename";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "国家";
            this.gridColumn5.FieldName = "country";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "省份";
            this.gridColumn6.FieldName = "province";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "城市";
            this.gridColumn7.FieldName = "city";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(104, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "供应商编号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(104, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "供应商名称";
            // 
            // txtsplyno
            // 
            this.txtsplyno.Location = new System.Drawing.Point(170, 26);
            this.txtsplyno.MenuManager = this.ribboncontrol;
            this.txtsplyno.Name = "txtsplyno";
            this.txtsplyno.Size = new System.Drawing.Size(186, 20);
            this.txtsplyno.TabIndex = 3;
            // 
            // txtsplyname
            // 
            this.txtsplyname.Location = new System.Drawing.Point(170, 63);
            this.txtsplyname.MenuManager = this.ribboncontrol;
            this.txtsplyname.Name = "txtsplyname";
            this.txtsplyname.Size = new System.Drawing.Size(186, 20);
            this.txtsplyname.TabIndex = 4;
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.gcsupplier);
            this.Name = "SupplierListForm";
            this.Text = "供应商信息";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcsupplier, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsplyno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsplyname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcsupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvsupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsplyname;
        private DevExpress.XtraEditors.TextEdit txtsplyno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
