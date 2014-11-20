namespace MEMS.Client.Sale
{
    partial class SaleOrderListForm
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
            this.gcSaleOrder = new DevExpress.XtraGrid.GridControl();
            this.gvSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmborderstate = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupOrderState = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmborderstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupOrderState)).BeginInit();
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
            // gcSaleOrder
            // 
            this.gcSaleOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSaleOrder.Location = new System.Drawing.Point(0, 225);
            this.gcSaleOrder.MainView = this.gvSaleOrder;
            this.gcSaleOrder.MenuManager = this.ribboncontrol;
            this.gcSaleOrder.Name = "gcSaleOrder";
            this.gcSaleOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmborderstate,
            this.lkupOrderState});
            this.gcSaleOrder.Size = new System.Drawing.Size(717, 258);
            this.gcSaleOrder.TabIndex = 3;
            this.gcSaleOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleOrder});
            // 
            // gvSaleOrder
            // 
            this.gvSaleOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvSaleOrder.GridControl = this.gcSaleOrder;
            this.gvSaleOrder.Name = "gvSaleOrder";
            this.gvSaleOrder.OptionsView.ShowGroupPanel = false;
            this.gvSaleOrder.OptionsView.ShowViewCaption = true;
            this.gvSaleOrder.ViewCaption = "销售单列表";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "so.id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "销售单号";
            this.gridColumn2.FieldName = "so.saleno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "销售日期";
            this.gridColumn3.FieldName = "so.saledate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "报价单id";
            this.gridColumn4.FieldName = "so.quotationid";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "报价单号";
            this.gridColumn8.FieldName = "qtno";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "订单总金额";
            this.gridColumn5.FieldName = "so.saletotalamount";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "订单状态";
            this.gridColumn6.ColumnEdit = this.cmborderstate;
            this.gridColumn6.FieldName = "so.orderstate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // cmborderstate
            // 
            this.cmborderstate.AutoHeight = false;
            this.cmborderstate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmborderstate.Name = "cmborderstate";
            this.cmborderstate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmborderstate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmborderstate_ButtonClick);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "收款金额";
            this.gridColumn7.FieldName = "so.receiveamount";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // lkupOrderState
            // 
            this.lkupOrderState.AutoHeight = false;
            this.lkupOrderState.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupOrderState.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("value", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("key", "Name2", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lkupOrderState.Name = "lkupOrderState";
            // 
            // SaleOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 483);
            this.Controls.Add(this.gcSaleOrder);
            this.Name = "SaleOrderListForm";
            this.Text = "销售订单";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcSaleOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmborderstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupOrderState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSaleOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSaleOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmborderstate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupOrderState;
    }
}
