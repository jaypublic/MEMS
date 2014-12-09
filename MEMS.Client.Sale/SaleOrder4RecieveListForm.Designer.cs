namespace MEMS.Client.Sale
{
    partial class SaleOrder4RecieveListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrder4RecieveListForm));
            this.gcSaleOrder = new DevExpress.XtraGrid.GridControl();
            this.gvSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaleNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.dateEdit2);
            this.searchgroup.Controls.Add(this.dateEdit1);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txtSaleNo);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtSaleNo, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit1, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit2, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.LargeImages = this.ribbonImageCollectionLarge;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcSaleOrder
            // 
            this.gcSaleOrder.Location = new System.Drawing.Point(22, 251);
            this.gcSaleOrder.MainView = this.gvSaleOrder;
            this.gcSaleOrder.MenuManager = this.ribboncontrol;
            this.gcSaleOrder.Name = "gcSaleOrder";
            this.gcSaleOrder.Size = new System.Drawing.Size(673, 200);
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
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9});
            this.gvSaleOrder.GridControl = this.gcSaleOrder;
            this.gvSaleOrder.Name = "gvSaleOrder";
            this.gvSaleOrder.OptionsView.ShowGroupPanel = false;
            this.gvSaleOrder.OptionsView.ShowViewCaption = true;
            this.gvSaleOrder.ViewCaption = "销售订单列表";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "so.id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "so.customerid";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "销售单号";
            this.gridColumn3.FieldName = "so.saleno";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "销售日期";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "客户名称";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "订单金额";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "收款金额";
            this.gridColumn6.FieldName = "so.receiveamount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "收款比例";
            this.gridColumn8.FieldName = "so.receiveratio";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "收款状态";
            this.gridColumn9.FieldName = "so.receivestate";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(268, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "—";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(286, 64);
            this.dateEdit2.MenuManager = this.ribboncontrol;
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit2.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit2.Size = new System.Drawing.Size(114, 22);
            this.dateEdit2.TabIndex = 21;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(147, 64);
            this.dateEdit1.MenuManager = this.ribboncontrol;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Size = new System.Drawing.Size(114, 22);
            this.dateEdit1.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(84, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "销售日期";
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.Location = new System.Drawing.Point(147, 33);
            this.txtSaleNo.MenuManager = this.ribboncontrol;
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.Size = new System.Drawing.Size(253, 22);
            this.txtSaleNo.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(84, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "销售单号";
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
            this.ribbonImageCollectionLarge.InsertGalleryImage("currency_32x32.png", "images/miscellaneous/currency_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/currency_32x32.png"), 17);
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "currency_32x32.png");
            // 
            // SaleOrder4RecieveListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 476);
            this.Controls.Add(this.gcSaleOrder);
            this.Name = "SaleOrder4RecieveListForm";
            this.Text = "销售收款";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcSaleOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSaleNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
    }
}
