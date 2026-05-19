namespace Sanding_Win_Form_POS
{
    partial class HistoryForm
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
            this.txtHistSearch = new System.Windows.Forms.TextBox();
            this.btnHistSearch = new System.Windows.Forms.Button();
            this.btnShowAllHist = new System.Windows.Forms.Button();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.btnCloseHist = new System.Windows.Forms.Button();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrandTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PURCHASE HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // txtHistSearch
            // 
            this.txtHistSearch.Location = new System.Drawing.Point(70, 52);
            this.txtHistSearch.Name = "txtHistSearch";
            this.txtHistSearch.Size = new System.Drawing.Size(200, 20);
            this.txtHistSearch.TabIndex = 2;
            // 
            // btnHistSearch
            // 
            this.btnHistSearch.Location = new System.Drawing.Point(276, 50);
            this.btnHistSearch.Name = "btnHistSearch";
            this.btnHistSearch.Size = new System.Drawing.Size(80, 25);
            this.btnHistSearch.TabIndex = 3;
            this.btnHistSearch.Text = "Search";
            this.btnHistSearch.UseVisualStyleBackColor = true;
            this.btnHistSearch.Click += new System.EventHandler(this.btnHistSearch_Click);
            // 
            // btnShowAllHist
            // 
            this.btnShowAllHist.Location = new System.Drawing.Point(362, 50);
            this.btnShowAllHist.Name = "btnShowAllHist";
            this.btnShowAllHist.Size = new System.Drawing.Size(80, 25);
            this.btnShowAllHist.TabIndex = 4;
            this.btnShowAllHist.Text = "Show All";
            this.btnShowAllHist.UseVisualStyleBackColor = true;
            this.btnShowAllHist.Click += new System.EventHandler(this.btnShowAllHist_Click);
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Code,
            this.ItemName,
            this.QTY,
            this.Price,
            this.SubTotal,
            this.VAT,
            this.Discount,
            this.GrandTotal,
            this.columnHeader1});
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.HideSelection = false;
            this.lvHistory.Location = new System.Drawing.Point(10, 90);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(860, 340);
            this.lvHistory.TabIndex = 5;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            // 
            // btnCloseHist
            // 
            this.btnCloseHist.Location = new System.Drawing.Point(772, 49);
            this.btnCloseHist.Name = "btnCloseHist";
            this.btnCloseHist.Size = new System.Drawing.Size(100, 35);
            this.btnCloseHist.TabIndex = 6;
            this.btnCloseHist.Text = "Close";
            this.btnCloseHist.UseVisualStyleBackColor = true;
            this.btnCloseHist.Click += new System.EventHandler(this.btnCloseHist_Click);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 130;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 90;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 130;
            // 
            // QTY
            // 
            this.QTY.Text = "QTY";
            this.QTY.Width = 70;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "SubTotal";
            this.SubTotal.Width = 100;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.Width = 80;
            // 
            // Discount
            // 
            this.Discount.Text = "Discount";
            this.Discount.Width = 80;
            // 
            // GrandTotal
            // 
            this.GrandTotal.Text = "Grand Total";
            this.GrandTotal.Width = 100;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnCloseHist);
            this.Controls.Add(this.lvHistory);
            this.Controls.Add(this.btnShowAllHist);
            this.Controls.Add(this.btnHistSearch);
            this.Controls.Add(this.txtHistSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistoryForm";
            this.Text = "Purchase History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHistSearch;
        private System.Windows.Forms.Button btnHistSearch;
        private System.Windows.Forms.Button btnShowAllHist;
        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader Discount;
        private System.Windows.Forms.ColumnHeader GrandTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnCloseHist;
    }
}