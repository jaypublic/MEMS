namespace MEMS.Client.CRM
{
    partial class CustomerListForm
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
            this.gccustomer = new DevExpress.XtraGrid.GridControl();
            this.gvcustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_customerno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_customername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sname = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_customerno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_customername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.txt_sname);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.txt_customername);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txt_customerno);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txt_customerno, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.txt_customername, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.txt_sname, 0);
            // 
            // ribbonControl1
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gccustomer
            // 
            this.gccustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gccustomer.Location = new System.Drawing.Point(0, 198);
            this.gccustomer.MainView = this.gvcustomer;
            this.gccustomer.MenuManager = this.ribboncontrol;
            this.gccustomer.Name = "gccustomer";
            this.gccustomer.Size = new System.Drawing.Size(717, 193);
            this.gccustomer.TabIndex = 3;
            this.gccustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvcustomer});
            // 
            // gvcustomer
            // 
            this.gvcustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvcustomer.GridControl = this.gccustomer;
            this.gvcustomer.Name = "gvcustomer";
            this.gvcustomer.OptionsBehavior.Editable = false;
            this.gvcustomer.OptionsView.ShowGroupPanel = false;
            this.gvcustomer.OptionsView.ShowViewCaption = true;
            this.gvcustomer.ViewCaption = "客户信息";
            this.gvcustomer.DoubleClick += new System.EventHandler(this.gvcustomer_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "客户编号";
            this.gridColumn2.FieldName = "customerno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "客户公司名称";
            this.gridColumn3.FieldName = "customername";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "客户公司简称";
            this.gridColumn4.FieldName = "simplename";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(86, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "客户编号";
            // 
            // txt_customerno
            // 
            this.txt_customerno.Location = new System.Drawing.Point(163, 26);
            this.txt_customerno.MenuManager = this.ribboncontrol;
            this.txt_customerno.Name = "txt_customerno";
            this.txt_customerno.Size = new System.Drawing.Size(138, 20);
            this.txt_customerno.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(332, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "客户公司名称";
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(410, 26);
            this.txt_customername.MenuManager = this.ribboncontrol;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(138, 20);
            this.txt_customername.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "客户公司简称";
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(163, 62);
            this.txt_sname.MenuManager = this.ribboncontrol;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(138, 20);
            this.txt_sname.TabIndex = 6;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "公司地址";
            this.gridColumn5.FieldName = "companyaddress";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "电话";
            this.gridColumn6.FieldName = "phone";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "传真";
            this.gridColumn7.FieldName = "fax";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.gccustomer);
            this.Name = "CustomerListForm";
            this.Text = "客户信息管理";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gccustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_customerno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_customername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gccustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvcustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.TextEdit txt_sname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_customername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_customerno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;


    }
}
