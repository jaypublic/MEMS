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
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
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
            // QuotationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Name = "QuotationListForm";
            this.Text = "产品报价单列表";
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
