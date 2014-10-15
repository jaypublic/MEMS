namespace MEMS.Client.Common
{
    partial class BaseinfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseinfoForm));
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.okButton = new DevExpress.XtraBars.BarButtonItem();
            this.cancelButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtn1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtn3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.okButton,
            this.cancelButton,
            this.barbtn1,
            this.barbtn2,
            this.barbtn3});
            this.ribbonControl1.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(825, 125);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // okButton
            // 
            this.okButton.Caption = "确定";
            this.okButton.Id = 1;
            this.okButton.LargeImageIndex = 4;
            this.okButton.Name = "okButton";
            this.okButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.okButton_ItemClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Caption = "取消";
            this.cancelButton.Id = 2;
            this.cancelButton.LargeImageIndex = 6;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelButton_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.okButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.cancelButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "基本操作";
            // 
            // barbtn1
            // 
            this.barbtn1.Caption = "自定义";
            this.barbtn1.Id = 3;
            this.barbtn1.LargeImageIndex = 0;
            this.barbtn1.Name = "barbtn1";
            this.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn1_ItemClick);
            // 
            // barbtn2
            // 
            this.barbtn2.Caption = "自定义";
            this.barbtn2.Id = 4;
            this.barbtn2.LargeImageIndex = 0;
            this.barbtn2.Name = "barbtn2";
            this.barbtn2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn2_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtn1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtn2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtn3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "扩展操作";
            this.ribbonPageGroup2.Visible = false;
            // 
            // barbtn3
            // 
            this.barbtn3.Caption = "自定义";
            this.barbtn3.Id = 6;
            this.barbtn3.LargeImageIndex = 0;
            this.barbtn3.Name = "barbtn3";
            this.barbtn3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn3_ItemClick);
            // 
            // BaseinfoForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 495);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaseinfoForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "BaseinfoForm";
            this.Load += new System.EventHandler(this.BaseinfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem okButton;
        private DevExpress.XtraBars.BarButtonItem cancelButton;
        public DevExpress.XtraBars.BarButtonItem barbtn1;
        public DevExpress.XtraBars.BarButtonItem barbtn2;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtn3;
    }
}