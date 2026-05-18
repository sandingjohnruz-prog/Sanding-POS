namespace Sanding_Win_Form_POS
{
    partial class Inventory
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
            this.TxtInvSearch = new System.Windows.Forms.TextBox();
            this.btnInvSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lvInventory = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRestockQTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestock = new System.Windows.Forms.Button();
            this.TxtSelectionItm = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // TxtInvSearch
            // 
            this.TxtInvSearch.Location = new System.Drawing.Point(70, 52);
            this.TxtInvSearch.Name = "TxtInvSearch";
            this.TxtInvSearch.Size = new System.Drawing.Size(200, 20);
            this.TxtInvSearch.TabIndex = 2;
            // 
            // btnInvSearch
            // 
            this.btnInvSearch.Location = new System.Drawing.Point(276, 50);
            this.btnInvSearch.Name = "btnInvSearch";
            this.btnInvSearch.Size = new System.Drawing.Size(80, 25);
            this.btnInvSearch.TabIndex = 3;
            this.btnInvSearch.Text = "Search";
            this.btnInvSearch.UseVisualStyleBackColor = true;
            this.btnInvSearch.Click += new System.EventHandler(this.btnInvSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(362, 50);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 25);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lvInventory
            // 
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.ItemName,
            this.Price,
            this.Stock});
            this.lvInventory.FullRowSelect = true;
            this.lvInventory.HideSelection = false;
            this.lvInventory.Location = new System.Drawing.Point(13, 81);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(503, 250);
            this.lvInventory.TabIndex = 5;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            this.lvInventory.SelectedIndexChanged += new System.EventHandler(this.lvInventory_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 100;
            // 
            // ItemName
            // 
            this.ItemName.Text = "ItemName";
            this.ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemName.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 100;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restock Qty";
            // 
            // TxtRestockQTY
            // 
            this.TxtRestockQTY.Location = new System.Drawing.Point(110, 357);
            this.TxtRestockQTY.Name = "TxtRestockQTY";
            this.TxtRestockQTY.Size = new System.Drawing.Size(100, 20);
            this.TxtRestockQTY.TabIndex = 7;
            this.TxtRestockQTY.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected";
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(220, 357);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(100, 20);
            this.btnRestock.TabIndex = 9;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // TxtSelectionItm
            // 
            this.TxtSelectionItm.Location = new System.Drawing.Point(80, 397);
            this.TxtSelectionItm.Name = "TxtSelectionItm";
            this.TxtSelectionItm.Size = new System.Drawing.Size(300, 20);
            this.TxtSelectionItm.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(554, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 657);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TxtSelectionItm);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRestockQTY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvInventory);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnInvSearch);
            this.Controls.Add(this.TxtInvSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Inventory Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtInvSearch;
        private System.Windows.Forms.Button btnInvSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRestockQTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.TextBox TxtSelectionItm;
        private System.Windows.Forms.Button btnClose;
    }
}