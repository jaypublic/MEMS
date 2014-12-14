namespace MEMS.Client.MRP.UserWindows
{
    partial class StockMaterialsSearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcStockMaterials = new DevExpress.XtraGrid.GridControl();
            this.gvStockMaterails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaterails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStockMaterials
            // 
            this.gcStockMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStockMaterials.Location = new System.Drawing.Point(12, 48);
            this.gcStockMaterials.MainView = this.gvStockMaterails;
            this.gcStockMaterials.Name = "gcStockMaterials";
            this.gcStockMaterials.Size = new System.Drawing.Size(835, 346);
            this.gcStockMaterials.TabIndex = 4;
            this.gcStockMaterials.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockMaterails,
            this.gridView2});
            // 
            // gvStockMaterails
            // 
            this.gvStockMaterails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3});
            this.gvStockMaterails.CustomizationFormBounds = new System.Drawing.Rectangle(587, 385, 216, 187);
            this.gvStockMaterails.GridControl = this.gcStockMaterials;
            this.gvStockMaterails.Name = "gvStockMaterails";
            this.gvStockMaterails.OptionsBehavior.Editable = false;
            this.gvStockMaterails.OptionsSelection.MultiSelect = true;
            this.gvStockMaterails.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvStockMaterails.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gvStockMaterails.OptionsView.ShowGroupPanel = false;
            this.gvStockMaterails.OptionsView.ShowViewCaption = true;
            this.gvStockMaterails.ViewCaption = "物资编码列表";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "编码";
            this.gridColumn10.FieldName = "MatCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "描述";
            this.gridColumn11.FieldName = "MatDesc";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "物资类型";
            this.gridColumn1.FieldName = "MatTypeCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "规格型号";
            this.gridColumn2.FieldName = "MatModeCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "可用数量";
            this.gridColumn3.FieldName = "AvailableQuantity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcStockMaterials;
            this.gridView2.Name = "gridView2";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(596, 400);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 44);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "选择";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(704, 400);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 44);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "单位";
            this.gridColumn4.FieldName = "Unit";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(254, 12);
            this.txt_Search.MaxLength = 2;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(241, 21);
            this.txt_Search.TabIndex = 8;
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::MEMS.Client.MRP.Properties.Resources.Search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(516, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "查询";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockMaterialsSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 456);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.gcStockMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockMaterialsSearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "标准物资编码查询窗体";
            this.Load += new System.EventHandler(this.StockMaterialsSearchWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStockMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockMaterails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStockMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockMaterails;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelBtn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button SearchButton;
    }
}