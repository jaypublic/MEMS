namespace MEMS.Client.CRM
{
    partial class SelectProForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProForm));
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCustomer = new DevExpress.XtraGrid.GridControl();
            this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.selectProImage = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Visible = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.LargeImages = this.selectProImage;
            this.ribbonControl1.Size = new System.Drawing.Size(802, 125);
            // 
            // gcProduct
            // 
            this.gcProduct.Location = new System.Drawing.Point(0, 131);
            this.gcProduct.MainView = this.gvProduct;
            this.gcProduct.MenuManager = this.ribbonControl1;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(405, 302);
            this.gcProduct.TabIndex = 1;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gvProduct.GridControl = this.gcProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.Editable = false;
            this.gvProduct.OptionsSelection.MultiSelect = true;
            this.gvProduct.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvProduct.OptionsView.ShowGroupPanel = false;
            this.gvProduct.OptionsView.ShowViewCaption = true;
            this.gvProduct.ViewCaption = "产品列表";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "id";
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "客户ID";
            this.gridColumn6.FieldName = "customerid";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "产品编号";
            this.gridColumn7.FieldName = "procode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 66;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "产品名称";
            this.gridColumn8.FieldName = "proname";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 66;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "产品规格";
            this.gridColumn9.FieldName = "prospecification";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 66;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "产品净重";
            this.gridColumn10.FieldName = "pronetweight";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 66;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "产品毛重";
            this.gridColumn11.FieldName = "progrossweight";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 74;
            // 
            // gcCustomer
            // 
            this.gcCustomer.Location = new System.Drawing.Point(411, 131);
            this.gcCustomer.MainView = this.gvCustomer;
            this.gcCustomer.MenuManager = this.ribbonControl1;
            this.gcCustomer.Name = "gcCustomer";
            this.gcCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcCustomer.Size = new System.Drawing.Size(391, 302);
            this.gcCustomer.TabIndex = 2;
            this.gcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
            // 
            // gvCustomer
            // 
            this.gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2});
            this.gvCustomer.GridControl = this.gcCustomer;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.OptionsBehavior.Editable = false;
            this.gvCustomer.OptionsView.ShowGroupPanel = false;
            this.gvCustomer.OptionsView.ShowViewCaption = true;
            this.gvCustomer.ViewCaption = "客户列表";
            this.gvCustomer.DoubleClick += new System.EventHandler(this.gvCustomer_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "客户编号";
            this.gridColumn4.FieldName = "customerno";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "客户名称";
            this.gridColumn3.FieldName = "customername";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "客户简称";
            this.gridColumn2.FieldName = "simplename";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // selectProImage
            // 
            this.selectProImage.ImageSize = new System.Drawing.Size(32, 32);
            this.selectProImage.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("selectProImage.ImageStream")));
            this.selectProImage.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.selectProImage.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.selectProImage.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.selectProImage.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.selectProImage.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.selectProImage.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.selectProImage.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.selectProImage.Images.SetKeyName(7, "ButtonForward.png");
            this.selectProImage.Images.SetKeyName(8, "Ribbon_Content_32x32.png");
            this.selectProImage.Images.SetKeyName(9, "Ribbon_Info_32x32.png");
            this.selectProImage.Images.SetKeyName(10, "BO_Sale_Item_v92_32x32.png");
            this.selectProImage.InsertGalleryImage("delete_32x32.png", "images/edit/delete_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png"), 11);
            this.selectProImage.Images.SetKeyName(11, "delete_32x32.png");
            this.selectProImage.InsertGalleryImage("backward_32x32.png", "images/navigation/backward_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/backward_32x32.png"), 12);
            this.selectProImage.Images.SetKeyName(12, "backward_32x32.png");
            this.selectProImage.InsertGalleryImage("forward_32x32.png", "images/navigation/forward_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/forward_32x32.png"), 13);
            this.selectProImage.Images.SetKeyName(13, "forward_32x32.png");
            // 
            // SelectProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(802, 441);
            this.Controls.Add(this.gcCustomer);
            this.Controls.Add(this.gcProduct);
            this.Name = "SelectProForm";
            this.Text = "选择产品";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.gcProduct, 0);
            this.Controls.SetChildIndex(this.gcCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraGrid.GridControl gcCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        internal DevExpress.Utils.ImageCollection selectProImage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
