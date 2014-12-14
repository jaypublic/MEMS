namespace MEMS.Client.MRP
{
    partial class UseApplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseApplyForm));
            this.gcApplyUseOrders = new DevExpress.XtraGrid.GridControl();
            this.gvApplyUseOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvApplyUseTypeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.ApplyStartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ApplyEndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ApplyUseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyUseDeptComboBox = new System.Windows.Forms.ComboBox();
            this.SaleNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductOrderTextBox = new System.Windows.Forms.TextBox();
            this.ApplyUseNoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcApplyUseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyUseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyUseTypeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.ApplyUseNoTextBox);
            this.searchgroup.Controls.Add(this.ProductOrderTextBox);
            this.searchgroup.Controls.Add(this.label3);
            this.searchgroup.Controls.Add(this.label2);
            this.searchgroup.Controls.Add(this.SaleNoTextBox);
            this.searchgroup.Controls.Add(this.ApplyUseDeptComboBox);
            this.searchgroup.Controls.Add(this.ApplyUseTypeComboBox);
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.label1);
            this.searchgroup.Controls.Add(this.ApplyEndDateEdit);
            this.searchgroup.Controls.Add(this.ApplyStartDateEdit);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Size = new System.Drawing.Size(838, 101);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyStartDateEdit, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyEndDateEdit, 0);
            this.searchgroup.Controls.SetChildIndex(this.label1, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyUseTypeComboBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyUseDeptComboBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.SaleNoTextBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.label2, 0);
            this.searchgroup.Controls.SetChildIndex(this.label3, 0);
            this.searchgroup.Controls.SetChildIndex(this.ProductOrderTextBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyUseNoTextBox, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.LargeImages = this.ribbonImageCollectionLarge;
            this.ribboncontrol.Size = new System.Drawing.Size(838, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcApplyUseOrders
            // 
            this.gcApplyUseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcApplyUseOrders.Location = new System.Drawing.Point(0, 125);
            this.gcApplyUseOrders.MainView = this.gvApplyUseOrders;
            this.gcApplyUseOrders.MenuManager = this.ribboncontrol;
            this.gcApplyUseOrders.Name = "gcApplyUseOrders";
            this.gcApplyUseOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvApplyUseTypeEdit});
            this.gcApplyUseOrders.Size = new System.Drawing.Size(838, 266);
            this.gcApplyUseOrders.TabIndex = 3;
            this.gcApplyUseOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvApplyUseOrders});
            // 
            // gvApplyUseOrders
            // 
            this.gvApplyUseOrders.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvApplyUseOrders.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvApplyUseOrders.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gvApplyUseOrders.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvApplyUseOrders.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvApplyUseOrders.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvApplyUseOrders.AppearancePrint.Row.BackColor = System.Drawing.Color.Red;
            this.gvApplyUseOrders.AppearancePrint.Row.BackColor2 = System.Drawing.Color.Red;
            this.gvApplyUseOrders.AppearancePrint.Row.Options.UseBackColor = true;
            this.gvApplyUseOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn14,
            this.gridColumn15});
            this.gvApplyUseOrders.GridControl = this.gcApplyUseOrders;
            this.gvApplyUseOrders.Name = "gvApplyUseOrders";
            this.gvApplyUseOrders.OptionsBehavior.Editable = false;
            this.gvApplyUseOrders.OptionsView.ShowGroupPanel = false;
            this.gvApplyUseOrders.OptionsView.ShowViewCaption = true;
            this.gvApplyUseOrders.ViewCaption = "领用申请列表";
            this.gvApplyUseOrders.DoubleClick += new System.EventHandler(this.gvproduct_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "申领单号";
            this.gridColumn2.FieldName = "ApplyUseNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "申领部门";
            this.gridColumn3.FieldName = "DeptDesc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "申领日期";
            this.gridColumn6.FieldName = "ApplyUseDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "用途类型";
            this.gridColumn5.ColumnEdit = this.gvApplyUseTypeEdit;
            this.gridColumn5.FieldName = "ApplyUseType";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gvApplyUseTypeEdit
            // 
            this.gvApplyUseTypeEdit.AutoHeight = false;
            this.gvApplyUseTypeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvApplyUseTypeEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvApplyUseTypeEdit.DisplayMember = "Desc";
            this.gvApplyUseTypeEdit.Name = "gvApplyUseTypeEdit";
            this.gvApplyUseTypeEdit.ValueMember = "Code";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "领用人";
            this.gridColumn7.FieldName = "Userdesc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "销售订单号";
            this.gridColumn8.FieldName = "SaleNo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "生产指令单号";
            this.gridColumn9.FieldName = "ProductOrderNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "申请人";
            this.gridColumn14.FieldName = "ApplicantDesc";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "填报人";
            this.gridColumn15.FieldName = "RegisterDesc";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(99, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "申领日期";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(651, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "用途类型";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(275, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "到";
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
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "BO_Sale_v92_32x32.png");
            // 
            // ApplyStartDateEdit
            // 
            this.ApplyStartDateEdit.EditValue = null;
            this.ApplyStartDateEdit.Location = new System.Drawing.Point(169, 29);
            this.ApplyStartDateEdit.MenuManager = this.ribboncontrol;
            this.ApplyStartDateEdit.Name = "ApplyStartDateEdit";
            this.ApplyStartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApplyStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApplyStartDateEdit.Size = new System.Drawing.Size(100, 22);
            this.ApplyStartDateEdit.TabIndex = 4;
            // 
            // ApplyEndDateEdit
            // 
            this.ApplyEndDateEdit.EditValue = null;
            this.ApplyEndDateEdit.Location = new System.Drawing.Point(293, 29);
            this.ApplyEndDateEdit.MenuManager = this.ribboncontrol;
            this.ApplyEndDateEdit.Name = "ApplyEndDateEdit";
            this.ApplyEndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApplyEndDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApplyEndDateEdit.Size = new System.Drawing.Size(100, 22);
            this.ApplyEndDateEdit.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "销售订单号";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(415, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "申领部门";
            // 
            // ApplyUseTypeComboBox
            // 
            this.ApplyUseTypeComboBox.DisplayMember = "Desc";
            this.ApplyUseTypeComboBox.FormattingEnabled = true;
            this.ApplyUseTypeComboBox.Location = new System.Drawing.Point(705, 29);
            this.ApplyUseTypeComboBox.Name = "ApplyUseTypeComboBox";
            this.ApplyUseTypeComboBox.Size = new System.Drawing.Size(121, 22);
            this.ApplyUseTypeComboBox.TabIndex = 15;
            this.ApplyUseTypeComboBox.ValueMember = "Code";
            // 
            // ApplyUseDeptComboBox
            // 
            this.ApplyUseDeptComboBox.DisplayMember = "Desc";
            this.ApplyUseDeptComboBox.FormattingEnabled = true;
            this.ApplyUseDeptComboBox.Location = new System.Drawing.Point(501, 29);
            this.ApplyUseDeptComboBox.Name = "ApplyUseDeptComboBox";
            this.ApplyUseDeptComboBox.Size = new System.Drawing.Size(121, 22);
            this.ApplyUseDeptComboBox.TabIndex = 16;
            this.ApplyUseDeptComboBox.ValueMember = "Code";
            // 
            // SaleNoTextBox
            // 
            this.SaleNoTextBox.Location = new System.Drawing.Point(169, 67);
            this.SaleNoTextBox.Name = "SaleNoTextBox";
            this.SaleNoTextBox.Size = new System.Drawing.Size(224, 22);
            this.SaleNoTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "生产指令单号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "申领单号";
            // 
            // ProductOrderTextBox
            // 
            this.ProductOrderTextBox.Location = new System.Drawing.Point(501, 67);
            this.ProductOrderTextBox.Name = "ProductOrderTextBox";
            this.ProductOrderTextBox.Size = new System.Drawing.Size(121, 22);
            this.ProductOrderTextBox.TabIndex = 20;
            // 
            // ApplyUseNoTextBox
            // 
            this.ApplyUseNoTextBox.Location = new System.Drawing.Point(705, 67);
            this.ApplyUseNoTextBox.Name = "ApplyUseNoTextBox";
            this.ApplyUseNoTextBox.Size = new System.Drawing.Size(121, 22);
            this.ApplyUseNoTextBox.TabIndex = 21;
            // 
            // UseApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(838, 391);
            this.Controls.Add(this.gcApplyUseOrders);
            this.Name = "UseApplyForm";
            this.Text = "领用申请";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.gcApplyUseOrders, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcApplyUseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyUseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyUseTypeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcApplyUseOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvApplyUseOrders;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit ApplyEndDateEdit;
        private DevExpress.XtraEditors.DateEdit ApplyStartDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.ComboBox ApplyUseDeptComboBox;
        private System.Windows.Forms.ComboBox ApplyUseTypeComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvApplyUseTypeEdit;
        private System.Windows.Forms.TextBox SaleNoTextBox;
        private System.Windows.Forms.TextBox ApplyUseNoTextBox;
        private System.Windows.Forms.TextBox ProductOrderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
