namespace MEMS.Client.CRM
{
    partial class QuotationListForm
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
            this.gcquotation = new DevExpress.XtraGrid.GridControl();
            this.gvquotation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.cmbCustomer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcquotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvquotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.dateEdit2);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.cmbCustomer);
            this.searchgroup.Controls.Add(this.dateEdit1);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txtQuNo);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Location = new System.Drawing.Point(0, 125);
            this.searchgroup.Size = new System.Drawing.Size(740, 100);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtQuNo, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit1, 0);
            this.searchgroup.Controls.SetChildIndex(this.cmbCustomer, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit2, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Size = new System.Drawing.Size(740, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcquotation
            // 
            this.gcquotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcquotation.Location = new System.Drawing.Point(0, 225);
            this.gcquotation.MainView = this.gvquotation;
            this.gcquotation.MenuManager = this.ribboncontrol;
            this.gcquotation.Name = "gcquotation";
            this.gcquotation.Size = new System.Drawing.Size(740, 222);
            this.gcquotation.TabIndex = 3;
            this.gcquotation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvquotation});
            // 
            // gvquotation
            // 
            this.gvquotation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvquotation.GridControl = this.gcquotation;
            this.gvquotation.Name = "gvquotation";
            this.gvquotation.OptionsView.ShowGroupPanel = false;
            this.gvquotation.OptionsView.ShowViewCaption = true;
            this.gvquotation.ViewCaption = "报价单列表";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "报价单号";
            this.gridColumn2.FieldName = "qutationno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "customerid";
            this.gridColumn3.FieldName = "customerid";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "报价日期";
            this.gridColumn4.FieldName = "quotationdate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "主题";
            this.gridColumn5.FieldName = "theme";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "总价";
            this.gridColumn6.FieldName = "totalprice";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(90, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "报价单号";
            // 
            // txtQuNo
            // 
            this.txtQuNo.Location = new System.Drawing.Point(153, 31);
            this.txtQuNo.MenuManager = this.ribboncontrol;
            this.txtQuNo.Name = "txtQuNo";
            this.txtQuNo.Size = new System.Drawing.Size(175, 22);
            this.txtQuNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(352, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "报价日期";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(415, 31);
            this.dateEdit1.MenuManager = this.ribboncontrol;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Size = new System.Drawing.Size(114, 22);
            this.dateEdit1.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(153, 67);
            this.cmbCustomer.MenuManager = this.ribboncontrol;
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Size = new System.Drawing.Size(175, 22);
            this.cmbCustomer.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(90, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "客户名称";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(554, 31);
            this.dateEdit2.MenuManager = this.ribboncontrol;
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit2.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit2.Size = new System.Drawing.Size(114, 22);
            this.dateEdit2.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(536, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "—";
            // 
            // QuotationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(740, 447);
            this.Controls.Add(this.gcquotation);
            this.Name = "QuotationListForm";
            this.Text = "产品报价单管理";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcquotation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcquotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvquotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcquotation;
        private DevExpress.XtraGrid.Views.Grid.GridView gvquotation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtQuNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
    }
}
