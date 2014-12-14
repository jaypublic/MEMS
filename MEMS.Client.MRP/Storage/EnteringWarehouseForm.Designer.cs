namespace MEMS.Client.MRP
{
    partial class EnteringWarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteringWarehouseForm));
            this.gcPO = new DevExpress.XtraGrid.GridControl();
            this.gvPO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPOTypeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvArrivalstatusEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPOStatusEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPaymentStatusEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.ApplyStartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ApplyEndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.POTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyDeptComboBox = new System.Windows.Forms.ComboBox();
            this.SaleNoTextBox = new System.Windows.Forms.TextBox();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvStorageStatusEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOTypeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArrivalstatusEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOStatusEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentStatusEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStorageStatusEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.SaleNoTextBox);
            this.searchgroup.Controls.Add(this.ApplyDeptComboBox);
            this.searchgroup.Controls.Add(this.POTypeComboBox);
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.label1);
            this.searchgroup.Controls.Add(this.ApplyEndDateEdit);
            this.searchgroup.Controls.Add(this.ApplyStartDateEdit);
            this.searchgroup.Controls.Add(this.labelControl3);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Size = new System.Drawing.Size(717, 101);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl3, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyStartDateEdit, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyEndDateEdit, 0);
            this.searchgroup.Controls.SetChildIndex(this.label1, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            this.searchgroup.Controls.SetChildIndex(this.POTypeComboBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.ApplyDeptComboBox, 0);
            this.searchgroup.Controls.SetChildIndex(this.SaleNoTextBox, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.LargeImages = this.ribbonImageCollectionLarge;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcPO
            // 
            this.gcPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPO.Location = new System.Drawing.Point(0, 226);
            this.gcPO.MainView = this.gvPO;
            this.gcPO.MenuManager = this.ribboncontrol;
            this.gcPO.Name = "gcPO";
            this.gcPO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvArrivalstatusEdit,
            this.gvPOTypeEdit,
            this.gvPOStatusEdit,
            this.gvPaymentStatusEdit,
            this.gvStorageStatusEdit});
            this.gcPO.Size = new System.Drawing.Size(717, 165);
            this.gcPO.TabIndex = 3;
            this.gcPO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPO});
            // 
            // gvPO
            // 
            this.gvPO.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvPO.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvPO.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gvPO.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvPO.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvPO.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvPO.AppearancePrint.Row.BackColor = System.Drawing.Color.Red;
            this.gvPO.AppearancePrint.Row.BackColor2 = System.Drawing.Color.Red;
            this.gvPO.AppearancePrint.Row.Options.UseBackColor = true;
            this.gvPO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn19,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn16,
            this.gridColumn1,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn17,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn18});
            this.gvPO.GridControl = this.gcPO;
            this.gvPO.Name = "gvPO";
            this.gvPO.OptionsBehavior.Editable = false;
            this.gvPO.OptionsView.ShowGroupPanel = false;
            this.gvPO.OptionsView.ShowViewCaption = true;
            this.gvPO.ViewCaption = "库存列表";
            this.gvPO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPO_FocusedRowChanged);
            this.gvPO.DoubleClick += new System.EventHandler(this.gvproduct_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "采购单号";
            this.gridColumn2.FieldName = "pono";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "采购申请日期";
            this.gridColumn3.FieldName = "applydate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "采购类型";
            this.gridColumn4.ColumnEdit = this.gvPOTypeEdit;
            this.gridColumn4.FieldName = "potype";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gvPOTypeEdit
            // 
            this.gvPOTypeEdit.AutoHeight = false;
            this.gvPOTypeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvPOTypeEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvPOTypeEdit.DisplayMember = "Desc";
            this.gvPOTypeEdit.Name = "gvPOTypeEdit";
            this.gvPOTypeEdit.ValueMember = "Code";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "采购金额";
            this.gridColumn6.FieldName = "amount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "到货状态";
            this.gridColumn5.ColumnEdit = this.gvArrivalstatusEdit;
            this.gridColumn5.FieldName = "arrivalstatus";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gvArrivalstatusEdit
            // 
            this.gvArrivalstatusEdit.AutoHeight = false;
            this.gvArrivalstatusEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvArrivalstatusEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvArrivalstatusEdit.DisplayMember = "Desc";
            this.gvArrivalstatusEdit.Name = "gvArrivalstatusEdit";
            this.gvArrivalstatusEdit.ValueMember = "Code";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "采购员";
            this.gridColumn7.FieldName = "buyerdesc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "要求到货日期";
            this.gridColumn8.FieldName = "demandarrivaldate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "实际到货日期";
            this.gridColumn9.FieldName = "actualarrivaldate";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "采购单状态";
            this.gridColumn10.ColumnEdit = this.gvPOStatusEdit;
            this.gridColumn10.FieldName = "postatus";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gvPOStatusEdit
            // 
            this.gvPOStatusEdit.AutoHeight = false;
            this.gvPOStatusEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvPOStatusEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvPOStatusEdit.DisplayMember = "Desc";
            this.gvPOStatusEdit.Name = "gvPOStatusEdit";
            this.gvPOStatusEdit.ValueMember = "Code";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "付款状态";
            this.gridColumn16.ColumnEdit = this.gvPaymentStatusEdit;
            this.gridColumn16.FieldName = "paymentstatus";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 10;
            // 
            // gvPaymentStatusEdit
            // 
            this.gvPaymentStatusEdit.AutoHeight = false;
            this.gvPaymentStatusEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvPaymentStatusEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvPaymentStatusEdit.DisplayMember = "Desc";
            this.gvPaymentStatusEdit.Name = "gvPaymentStatusEdit";
            this.gvPaymentStatusEdit.ValueMember = "Code";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "销售单号";
            this.gridColumn1.FieldName = "saleno";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 15;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "申请部门";
            this.gridColumn13.FieldName = "applydeptdesc";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "申请人";
            this.gridColumn14.FieldName = "applicantdesc";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 14;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "填报人";
            this.gridColumn15.FieldName = "registerdesc";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 16;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "提交审批日期";
            this.gridColumn17.FieldName = "sendapprovaldate";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 17;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "审批人";
            this.gridColumn11.FieldName = "approvaldesc";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "审批日期";
            this.gridColumn12.FieldName = "approvaldate";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "审批备注";
            this.gridColumn18.FieldName = "approvalremark";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "采购申请日期";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(418, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "采购类型";
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
            this.label1.Location = new System.Drawing.Point(96, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "销售订单号";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(418, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "申请部门";
            // 
            // POTypeComboBox
            // 
            this.POTypeComboBox.DisplayMember = "Desc";
            this.POTypeComboBox.FormattingEnabled = true;
            this.POTypeComboBox.Location = new System.Drawing.Point(472, 29);
            this.POTypeComboBox.Name = "POTypeComboBox";
            this.POTypeComboBox.Size = new System.Drawing.Size(121, 22);
            this.POTypeComboBox.TabIndex = 15;
            this.POTypeComboBox.ValueMember = "Code";
            // 
            // ApplyDeptComboBox
            // 
            this.ApplyDeptComboBox.DisplayMember = "Desc";
            this.ApplyDeptComboBox.FormattingEnabled = true;
            this.ApplyDeptComboBox.Location = new System.Drawing.Point(472, 62);
            this.ApplyDeptComboBox.Name = "ApplyDeptComboBox";
            this.ApplyDeptComboBox.Size = new System.Drawing.Size(121, 22);
            this.ApplyDeptComboBox.TabIndex = 16;
            this.ApplyDeptComboBox.ValueMember = "Code";
            // 
            // SaleNoTextBox
            // 
            this.SaleNoTextBox.Location = new System.Drawing.Point(169, 62);
            this.SaleNoTextBox.Name = "SaleNoTextBox";
            this.SaleNoTextBox.Size = new System.Drawing.Size(224, 22);
            this.SaleNoTextBox.TabIndex = 17;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "入库状态";
            this.gridColumn19.ColumnEdit = this.gvStorageStatusEdit;
            this.gridColumn19.FieldName = "storagestatus";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 4;
            // 
            // gvStorageStatusEdit
            // 
            this.gvStorageStatusEdit.AutoHeight = false;
            this.gvStorageStatusEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvStorageStatusEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "描述")});
            this.gvStorageStatusEdit.DisplayMember = "Desc";
            this.gvStorageStatusEdit.Name = "gvStorageStatusEdit";
            this.gvStorageStatusEdit.ValueMember = "Code";
            // 
            // EnteringWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.gcPO);
            this.Name = "EnteringWarehouseForm";
            this.Text = "入库信息";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcPO, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOTypeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArrivalstatusEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOStatusEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentStatusEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyStartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyEndDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStorageStatusEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit ApplyEndDateEdit;
        private DevExpress.XtraEditors.DateEdit ApplyStartDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ComboBox ApplyDeptComboBox;
        private System.Windows.Forms.ComboBox POTypeComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvArrivalstatusEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvPOTypeEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvPOStatusEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvPaymentStatusEdit;
        private System.Windows.Forms.TextBox SaleNoTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvStorageStatusEdit;
    }
}
