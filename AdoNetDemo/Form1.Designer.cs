namespace AdoNetDemo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxunitPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbxstockAmount = new System.Windows.Forms.TextBox();
            this.dbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.txtStockUpdate = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblunitPriceUpdate = new System.Windows.Forms.Label();
            this.txtUniUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.dbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(867, 188);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(143, 15);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "UnitPrice";
            // 
            // tbxunitPrice
            // 
            this.tbxunitPrice.Location = new System.Drawing.Point(143, 64);
            this.tbxunitPrice.Name = "tbxunitPrice";
            this.tbxunitPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxunitPrice.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(75, 127);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(86, 16);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "StockAmount";
            // 
            // tbxstockAmount
            // 
            this.tbxstockAmount.Location = new System.Drawing.Point(143, 121);
            this.tbxstockAmount.Name = "tbxstockAmount";
            this.tbxstockAmount.Size = new System.Drawing.Size(100, 22);
            this.tbxstockAmount.TabIndex = 6;
            // 
            // dbxAdd
            // 
            this.dbxAdd.Controls.Add(this.btnAdd);
            this.dbxAdd.Controls.Add(this.lblName);
            this.dbxAdd.Controls.Add(this.tbxstockAmount);
            this.dbxAdd.Controls.Add(this.tbxName);
            this.dbxAdd.Controls.Add(this.lblStock);
            this.dbxAdd.Controls.Add(this.label2);
            this.dbxAdd.Controls.Add(this.tbxunitPrice);
            this.dbxAdd.Location = new System.Drawing.Point(21, 244);
            this.dbxAdd.Name = "dbxAdd";
            this.dbxAdd.Size = new System.Drawing.Size(419, 194);
            this.dbxAdd.TabIndex = 7;
            this.dbxAdd.TabStop = false;
            this.dbxAdd.Text = "Add A Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.button1);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.txtStockUpdate);
            this.gbxUpdate.Controls.Add(this.txtUpdateName);
            this.gbxUpdate.Controls.Add(this.lblStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblunitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.txtUniUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(460, 259);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(419, 194);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update A Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(75, 21);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(41, 16);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "name";
            // 
            // txtStockUpdate
            // 
            this.txtStockUpdate.Location = new System.Drawing.Point(143, 121);
            this.txtStockUpdate.Name = "txtStockUpdate";
            this.txtStockUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtStockUpdate.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(143, 15);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateName.TabIndex = 2;
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(75, 127);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(86, 16);
            this.lblStockUpdate.TabIndex = 5;
            this.lblStockUpdate.Text = "StockAmount";
            // 
            // lblunitPriceUpdate
            // 
            this.lblunitPriceUpdate.AutoSize = true;
            this.lblunitPriceUpdate.Location = new System.Drawing.Point(75, 64);
            this.lblunitPriceUpdate.Name = "lblunitPriceUpdate";
            this.lblunitPriceUpdate.Size = new System.Drawing.Size(61, 16);
            this.lblunitPriceUpdate.TabIndex = 3;
            this.lblunitPriceUpdate.Text = "UnitPrice";
            // 
            // txtUniUpdate
            // 
            this.txtUniUpdate.Location = new System.Drawing.Point(143, 64);
            this.txtUniUpdate.Name = "txtUniUpdate";
            this.txtUniUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtUniUpdate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 467);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.dbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.dbxAdd.ResumeLayout(false);
            this.dbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxunitPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbxstockAmount;
        private System.Windows.Forms.GroupBox dbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox txtStockUpdate;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblunitPriceUpdate;
        private System.Windows.Forms.TextBox txtUniUpdate;
    }
}

