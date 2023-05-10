namespace project
{
    partial class frmProductReport2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.tBox_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tBox_MU = new System.Windows.Forms.TextBox();
            this.lbl_Mgr = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_Code = new System.Windows.Forms.TextBox();
            this.lbl_StoreReport = new System.Windows.Forms.Label();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // comBox_Product
            // 
            this.comBox_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(142, 118);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(236, 28);
            this.comBox_Product.TabIndex = 74;
            this.comBox_Product.Text = "Choose product";
            this.comBox_Product.SelectedIndexChanged += new System.EventHandler(this.comBox_Product_SelectedIndexChanged);
            // 
            // tBox_Qty
            // 
            this.tBox_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Qty.Location = new System.Drawing.Point(384, 327);
            this.tBox_Qty.Name = "tBox_Qty";
            this.tBox_Qty.Size = new System.Drawing.Size(213, 28);
            this.tBox_Qty.TabIndex = 73;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(284, 275);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(39, 22);
            this.lbl_Address.TabIndex = 72;
            this.lbl_Address.Text = "MU";
            // 
            // tBox_MU
            // 
            this.tBox_MU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_MU.Location = new System.Drawing.Point(384, 272);
            this.tBox_MU.Name = "tBox_MU";
            this.tBox_MU.Size = new System.Drawing.Size(213, 28);
            this.tBox_MU.TabIndex = 71;
            // 
            // lbl_Mgr
            // 
            this.lbl_Mgr.AutoSize = true;
            this.lbl_Mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mgr.Location = new System.Drawing.Point(284, 330);
            this.lbl_Mgr.Name = "lbl_Mgr";
            this.lbl_Mgr.Size = new System.Drawing.Size(85, 22);
            this.lbl_Mgr.TabIndex = 70;
            this.lbl_Mgr.Text = "Quantity";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(284, 221);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(57, 22);
            this.lbl_Name.TabIndex = 69;
            this.lbl_Name.Text = "Code";
            // 
            // tBox_Code
            // 
            this.tBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Code.Location = new System.Drawing.Point(384, 218);
            this.tBox_Code.Name = "tBox_Code";
            this.tBox_Code.Size = new System.Drawing.Size(213, 28);
            this.tBox_Code.TabIndex = 68;
            // 
            // lbl_StoreReport
            // 
            this.lbl_StoreReport.AutoSize = true;
            this.lbl_StoreReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StoreReport.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreReport.Location = new System.Drawing.Point(342, 32);
            this.lbl_StoreReport.Name = "lbl_StoreReport";
            this.lbl_StoreReport.Size = new System.Drawing.Size(255, 34);
            this.lbl_StoreReport.TabIndex = 67;
            this.lbl_StoreReport.Text = "Product Report";
            // 
            // comBox_Store
            // 
            this.comBox_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(583, 104);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(236, 28);
            this.comBox_Store.TabIndex = 66;
            this.comBox_Store.Text = "Choose store";
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(151, 406);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 24;
            this.dgv_ProductList.Size = new System.Drawing.Size(668, 179);
            this.dgv_ProductList.TabIndex = 75;
            // 
            // frmProductReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.tBox_Qty);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tBox_MU);
            this.Controls.Add(this.lbl_Mgr);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Code);
            this.Controls.Add(this.lbl_StoreReport);
            this.Controls.Add(this.comBox_Store);
            this.Name = "frmProductReport2";
            this.Size = new System.Drawing.Size(1032, 743);
            this.Load += new System.EventHandler(this.frmProductReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox_Product;
        private System.Windows.Forms.TextBox tBox_Qty;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tBox_MU;
        private System.Windows.Forms.Label lbl_Mgr;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_Code;
        private System.Windows.Forms.Label lbl_StoreReport;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.DataGridView dgv_ProductList;
    }
}
