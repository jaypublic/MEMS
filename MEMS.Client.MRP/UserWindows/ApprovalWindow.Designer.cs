namespace MEMS.Client.MRP.UserWindows
{
    partial class ApprovalWindow
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
            this.AcceptRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RejectRadioButton = new System.Windows.Forms.RadioButton();
            this.ApprovalRemarkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(128, 118);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(79, 37);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AcceptRadioButton
            // 
            this.AcceptRadioButton.AutoSize = true;
            this.AcceptRadioButton.Checked = true;
            this.AcceptRadioButton.Location = new System.Drawing.Point(68, 12);
            this.AcceptRadioButton.Name = "AcceptRadioButton";
            this.AcceptRadioButton.Size = new System.Drawing.Size(47, 16);
            this.AcceptRadioButton.TabIndex = 5;
            this.AcceptRadioButton.TabStop = true;
            this.AcceptRadioButton.Text = "通过";
            this.AcceptRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(238, 118);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 37);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RejectRadioButton
            // 
            this.RejectRadioButton.AutoSize = true;
            this.RejectRadioButton.Location = new System.Drawing.Point(128, 12);
            this.RejectRadioButton.Name = "RejectRadioButton";
            this.RejectRadioButton.Size = new System.Drawing.Size(47, 16);
            this.RejectRadioButton.TabIndex = 7;
            this.RejectRadioButton.Text = "驳回";
            this.RejectRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApprovalRemarkTextBox
            // 
            this.ApprovalRemarkTextBox.Location = new System.Drawing.Point(68, 43);
            this.ApprovalRemarkTextBox.MaxLength = 250;
            this.ApprovalRemarkTextBox.Multiline = true;
            this.ApprovalRemarkTextBox.Name = "ApprovalRemarkTextBox";
            this.ApprovalRemarkTextBox.Size = new System.Drawing.Size(245, 69);
            this.ApprovalRemarkTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = " 操作：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "备注：";
            // 
            // ApprovalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApprovalRemarkTextBox);
            this.Controls.Add(this.RejectRadioButton);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptRadioButton);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApprovalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "审批窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.RadioButton AcceptRadioButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RadioButton RejectRadioButton;
        private System.Windows.Forms.TextBox ApprovalRemarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}