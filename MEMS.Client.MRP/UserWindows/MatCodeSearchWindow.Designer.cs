namespace MEMS.Client.MRP.UserWindows
{
    partial class MatCodeSearchWindow
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.gcMaterialCode = new DevExpress.XtraGrid.GridControl();
            this.gvMaterailCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterialCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterailCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::MEMS.Client.MRP.Properties.Resources.Search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(465, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "查询";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(203, 23);
            this.txt_Search.MaxLength = 2;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(241, 21);
            this.txt_Search.TabIndex = 2;
            // 
            // gcMaterialCode
            // 
            this.gcMaterialCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMaterialCode.Location = new System.Drawing.Point(12, 62);
            this.gcMaterialCode.MainView = this.gvMaterailCode;
            this.gcMaterialCode.Name = "gcMaterialCode";
            this.gcMaterialCode.Size = new System.Drawing.Size(705, 292);
            this.gcMaterialCode.TabIndex = 4;
            this.gcMaterialCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterailCode,
            this.gridView2});
            // 
            // gvMaterailCode
            // 
            this.gvMaterailCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2});
            this.gvMaterailCode.CustomizationFormBounds = new System.Drawing.Rectangle(587, 385, 216, 187);
            this.gvMaterailCode.GridControl = this.gcMaterialCode;
            this.gvMaterailCode.Name = "gvMaterailCode";
            this.gvMaterailCode.OptionsSelection.MultiSelect = true;
            this.gvMaterailCode.OptionsView.ShowGroupPanel = false;
            this.gvMaterailCode.OptionsView.ShowViewCaption = true;
            this.gvMaterailCode.ViewCaption = "物资编码列表";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "编码";
            this.gridColumn10.FieldName = "MatCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "描述";
            this.gridColumn11.FieldName = "Desc";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "物资类型";
            this.gridColumn1.FieldName = "MatTypeCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "规格型号";
            this.gridColumn2.FieldName = "MatModeCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcMaterialCode;
            this.gridView2.Name = "gridView2";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(503, 369);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "选择";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(614, 369);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MatCodeSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 404);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.gcMaterialCode);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MatCodeSearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "标准物资编码查询窗体";
            this.Load += new System.EventHandler(this.MatCodeSearchWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterialCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterailCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraGrid.GridControl gcMaterialCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterailCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelBtn;
    }
}