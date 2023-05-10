namespace project
{
    partial class frmSupplyOrder
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
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_ProdDate = new System.Windows.Forms.Label();
            this.lbl_SupplyOrder = new System.Windows.Forms.Label();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.lbl_Store = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_OrderNum = new System.Windows.Forms.Label();
            this.tBox_OrderNum = new System.Windows.Forms.TextBox();
            this.comBox_SupplyOrder = new System.Windows.Forms.ComboBox();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.date_Order = new System.Windows.Forms.DateTimePicker();
            this.date_Prod = new System.Windows.Forms.DateTimePicker();
            this.date_Exp = new System.Windows.Forms.DateTimePicker();
            this.dgv_SupplyOrderItems = new System.Windows.Forms.DataGridView();
            this.comBox_Supplier = new System.Windows.Forms.ComboBox();
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.AutoSize = true;
            this.lbl_ExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(85, 418);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(114, 22);
            this.lbl_ExpiryDate.TabIndex = 66;
            this.lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.Location = new System.Drawing.Point(85, 306);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(84, 22);
            this.lbl_Supplier.TabIndex = 64;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // lbl_ProdDate
            // 
            this.lbl_ProdDate.AutoSize = true;
            this.lbl_ProdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdDate.Location = new System.Drawing.Point(85, 361);
            this.lbl_ProdDate.Name = "lbl_ProdDate";
            this.lbl_ProdDate.Size = new System.Drawing.Size(154, 22);
            this.lbl_ProdDate.TabIndex = 62;
            this.lbl_ProdDate.Text = "Production Date";
            // 
            // lbl_SupplyOrder
            // 
            this.lbl_SupplyOrder.AutoSize = true;
            this.lbl_SupplyOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_SupplyOrder.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyOrder.Location = new System.Drawing.Point(83, 30);
            this.lbl_SupplyOrder.Name = "lbl_SupplyOrder";
            this.lbl_SupplyOrder.Size = new System.Drawing.Size(224, 34);
            this.lbl_SupplyOrder.TabIndex = 60;
            this.lbl_SupplyOrder.Text = "Supply Order";
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDate.Location = new System.Drawing.Point(85, 195);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(109, 22);
            this.lbl_OrderDate.TabIndex = 59;
            this.lbl_OrderDate.Text = "Order Date";
            // 
            // lbl_Store
            // 
            this.lbl_Store.AutoSize = true;
            this.lbl_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store.Location = new System.Drawing.Point(85, 250);
            this.lbl_Store.Name = "lbl_Store";
            this.lbl_Store.Size = new System.Drawing.Size(58, 22);
            this.lbl_Store.TabIndex = 57;
            this.lbl_Store.Text = "Store";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(331, 517);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 54;
            this.btn_Edit.Text = "Modify SupplyOrder";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(89, 517);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 53;
            this.btn_Add.Text = "Add SupplyOrder";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_OrderNum
            // 
            this.lbl_OrderNum.AutoSize = true;
            this.lbl_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNum.Location = new System.Drawing.Point(85, 141);
            this.lbl_OrderNum.Name = "lbl_OrderNum";
            this.lbl_OrderNum.Size = new System.Drawing.Size(136, 22);
            this.lbl_OrderNum.TabIndex = 52;
            this.lbl_OrderNum.Text = "Order Number";
            // 
            // tBox_OrderNum
            // 
            this.tBox_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_OrderNum.Location = new System.Drawing.Point(245, 138);
            this.tBox_OrderNum.Name = "tBox_OrderNum";
            this.tBox_OrderNum.Size = new System.Drawing.Size(213, 28);
            this.tBox_OrderNum.TabIndex = 51;
            // 
            // comBox_SupplyOrder
            // 
            this.comBox_SupplyOrder.FormattingEnabled = true;
            this.comBox_SupplyOrder.Location = new System.Drawing.Point(185, 88);
            this.comBox_SupplyOrder.Name = "comBox_SupplyOrder";
            this.comBox_SupplyOrder.Size = new System.Drawing.Size(225, 24);
            this.comBox_SupplyOrder.TabIndex = 50;
            this.comBox_SupplyOrder.Text = "Choose Supply Order ID";
            this.comBox_SupplyOrder.SelectedIndexChanged += new System.EventHandler(this.comBox_SupplyOrder_SelectedIndexChanged);
            // 
            // comBox_Store
            // 
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(245, 248);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(213, 24);
            this.comBox_Store.TabIndex = 67;
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // date_Order
            // 
            this.date_Order.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Order.Location = new System.Drawing.Point(245, 195);
            this.date_Order.Name = "date_Order";
            this.date_Order.Size = new System.Drawing.Size(213, 22);
            this.date_Order.TabIndex = 69;
            // 
            // date_Prod
            // 
            this.date_Prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Prod.Location = new System.Drawing.Point(245, 361);
            this.date_Prod.Name = "date_Prod";
            this.date_Prod.Size = new System.Drawing.Size(213, 22);
            this.date_Prod.TabIndex = 70;
            // 
            // date_Exp
            // 
            this.date_Exp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Exp.Location = new System.Drawing.Point(245, 418);
            this.date_Exp.Name = "date_Exp";
            this.date_Exp.Size = new System.Drawing.Size(213, 22);
            this.date_Exp.TabIndex = 71;
            // 
            // dgv_SupplyOrderItems
            // 
            this.dgv_SupplyOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplyOrderItems.Location = new System.Drawing.Point(497, 88);
            this.dgv_SupplyOrderItems.Name = "dgv_SupplyOrderItems";
            this.dgv_SupplyOrderItems.RowHeadersWidth = 51;
            this.dgv_SupplyOrderItems.RowTemplate.Height = 24;
            this.dgv_SupplyOrderItems.Size = new System.Drawing.Size(337, 156);
            this.dgv_SupplyOrderItems.TabIndex = 72;
            // 
            // comBox_Supplier
            // 
            this.comBox_Supplier.FormattingEnabled = true;
            this.comBox_Supplier.Location = new System.Drawing.Point(245, 304);
            this.comBox_Supplier.Name = "comBox_Supplier";
            this.comBox_Supplier.Size = new System.Drawing.Size(213, 24);
            this.comBox_Supplier.TabIndex = 73;
            // 
            // comBox_Product
            // 
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(641, 308);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(161, 24);
            this.comBox_Product.TabIndex = 74;
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(641, 357);
            this.num_Quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(161, 22);
            this.num_Quantity.TabIndex = 75;
            this.num_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(493, 306);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(85, 22);
            this.lbl_Product.TabIndex = 76;
            this.lbl_Product.Text = "Product ";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(493, 357);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(85, 22);
            this.lbl_Quantity.TabIndex = 77;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // frmSupplyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.comBox_Supplier);
            this.Controls.Add(this.dgv_SupplyOrderItems);
            this.Controls.Add(this.date_Exp);
            this.Controls.Add(this.date_Prod);
            this.Controls.Add(this.date_Order);
            this.Controls.Add(this.comBox_Store);
            this.Controls.Add(this.lbl_ExpiryDate);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.lbl_ProdDate);
            this.Controls.Add(this.lbl_SupplyOrder);
            this.Controls.Add(this.lbl_OrderDate);
            this.Controls.Add(this.lbl_Store);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_OrderNum);
            this.Controls.Add(this.tBox_OrderNum);
            this.Controls.Add(this.comBox_SupplyOrder);
            this.Name = "frmSupplyOrder";
            this.Size = new System.Drawing.Size(1107, 652);
            this.Load += new System.EventHandler(this.frmSupplyOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExpiryDate;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_ProdDate;
        private System.Windows.Forms.Label lbl_SupplyOrder;
        private System.Windows.Forms.Label lbl_OrderDate;
        private System.Windows.Forms.Label lbl_Store;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_OrderNum;
        private System.Windows.Forms.TextBox tBox_OrderNum;
        private System.Windows.Forms.ComboBox comBox_SupplyOrder;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.DateTimePicker date_Order;
        private System.Windows.Forms.DateTimePicker date_Prod;
        private System.Windows.Forms.DateTimePicker date_Exp;
        private System.Windows.Forms.DataGridView dgv_SupplyOrderItems;
        private System.Windows.Forms.ComboBox comBox_Supplier;
        private System.Windows.Forms.ComboBox comBox_Product;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Quantity;
    }
}
