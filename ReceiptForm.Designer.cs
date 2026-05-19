namespace Sanding_Win_Form_POS
{
    partial class ReceiptForm
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
            this.rtxReceipt = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxReceipt
            // 
            this.rtxReceipt.Font = new System.Drawing.Font("Courier New", 9F);
            this.rtxReceipt.Location = new System.Drawing.Point(10, 10);
            this.rtxReceipt.Name = "rtxReceipt";
            this.rtxReceipt.ReadOnly = true;
            this.rtxReceipt.Size = new System.Drawing.Size(360, 420);
            this.rtxReceipt.TabIndex = 0;
            this.rtxReceipt.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(10, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.Location = new System.Drawing.Point(200, 440);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(160, 35);
            this.btnNewTrans.TabIndex = 2;
            this.btnNewTrans.Text = "New Transaction";
            this.btnNewTrans.UseVisualStyleBackColor = true;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.btnNewTrans);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtxReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.Text = "Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxReceipt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewTrans;
    }
}