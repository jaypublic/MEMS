namespace MEMS.Client.MRP.UserWindows
{
    partial class EnteringWindow
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StockCodeComboBox = new System.Windows.Forms.ComboBox();
            this.StockDescLabel = new System.Windows.Forms.Label();
            this.CountNUD = new System.Windows.Forms.NumericUpDown();
            this.QuantityInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(184, 129);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(79, 34);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "入库";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "库位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新增数量";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(269, 129);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "取消";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StockCodeComboBox
            // 
            this.StockCodeComboBox.DisplayMember = "Code";
            this.StockCodeComboBox.FormattingEnabled = true;
            this.StockCodeComboBox.Location = new System.Drawing.Point(57, 25);
            this.StockCodeComboBox.Name = "StockCodeComboBox";
            this.StockCodeComboBox.Size = new System.Drawing.Size(106, 20);
            this.StockCodeComboBox.TabIndex = 5;
            this.StockCodeComboBox.ValueMember = "Code";
            this.StockCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.StockCodeComboBox_SelectedIndexChanged);
            // 
            // StockDescLabel
            // 
            this.StockDescLabel.Location = new System.Drawing.Point(24, 77);
            this.StockDescLabel.Name = "StockDescLabel";
            this.StockDescLabel.Size = new System.Drawing.Size(324, 34);
            this.StockDescLabel.TabIndex = 6;
            // 
            // CountNUD
            // 
            this.CountNUD.Location = new System.Drawing.Point(234, 26);
            this.CountNUD.Name = "CountNUD";
            this.CountNUD.Size = new System.Drawing.Size(39, 21);
            this.CountNUD.TabIndex = 7;
            // 
            // QuantityInfoLabel
            // 
            this.QuantityInfoLabel.AutoSize = true;
            this.QuantityInfoLabel.Location = new System.Drawing.Point(283, 30);
            this.QuantityInfoLabel.Name = "QuantityInfoLabel";
            this.QuantityInfoLabel.Size = new System.Drawing.Size(41, 12);
            this.QuantityInfoLabel.TabIndex = 8;
            this.QuantityInfoLabel.Text = "label3";
            // 
            // EnteringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 175);
            this.Controls.Add(this.QuantityInfoLabel);
            this.Controls.Add(this.CountNUD);
            this.Controls.Add(this.StockDescLabel);
            this.Controls.Add(this.StockCodeComboBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnteringWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库窗体";
            this.Load += new System.EventHandler(this.EnteringWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox StockCodeComboBox;
        private System.Windows.Forms.Label StockDescLabel;
        private System.Windows.Forms.NumericUpDown CountNUD;
        private System.Windows.Forms.Label QuantityInfoLabel;
    }
}