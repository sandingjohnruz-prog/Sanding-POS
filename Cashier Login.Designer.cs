namespace Sanding_Win_Form_POS
{
    partial class Cashier_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.btnLoginIn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS ONLY POS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Cashier ID:";
            // 
            // txtCashierID
            // 
            this.txtCashierID.Location = new System.Drawing.Point(135, 67);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.Size = new System.Drawing.Size(180, 20);
            this.txtCashierID.TabIndex = 2;
            this.txtCashierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashierID_KeyPress);
            // 
            // btnLoginIn
            // 
            this.btnLoginIn.Location = new System.Drawing.Point(80, 110);
            this.btnLoginIn.Name = "btnLoginIn";
            this.btnLoginIn.Size = new System.Drawing.Size(180, 35);
            this.btnLoginIn.TabIndex = 3;
            this.btnLoginIn.Text = "Login";
            this.btnLoginIn.UseVisualStyleBackColor = true;
            this.btnLoginIn.Click += new System.EventHandler(this.btnLoginIn_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(35, 160);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "label3";
            // 
            // Cashier_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLoginIn);
            this.Controls.Add(this.txtCashierID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cashier_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.Button btnLoginIn;
        private System.Windows.Forms.Label lblError;
    }
}