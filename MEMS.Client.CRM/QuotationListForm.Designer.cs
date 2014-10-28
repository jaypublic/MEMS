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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcquotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvquotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.textEdit1);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Location = new System.Drawing.Point(0, 125);
            this.searchgroup.Size = new System.Drawing.Size(740, 100);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.textEdit1, 0);
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
            this.gridColumn4.Caption = "报价单报价日期";
            this.gridColumn4.FieldName = "quotationdate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(94, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "报价单号";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(170, 26);
            this.textEdit1.MenuManager = this.ribboncontrol;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(175, 22);
            this.textEdit1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}
