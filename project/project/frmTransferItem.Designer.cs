namespace project
{
    partial class frmTransferItem
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
            this.comBox_Supplier = new System.Windows.Forms.ComboBox();
            this.dgv_TransferOrderItems = new System.Windows.Forms.DataGridView();
            this.date_Exp = new System.Windows.Forms.DateTimePicker();
            this.date_Prod = new System.Windows.Forms.DateTimePicker();
            this.date_Order = new System.Windows.Forms.DateTimePicker();
            this.comBox_SrcStore = new System.Windows.Forms.ComboBox();
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_ProdDate = new System.Windows.Forms.Label();
            this.lbl_TransferOrder = new System.Windows.Forms.Label();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.lbl_SrcStore = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_OrderNum = new System.Windows.Forms.Label();
            this.tBox_OrderNum = new System.Windows.Forms.TextBox();
            this.comBox_TransferOrder = new System.Windows.Forms.ComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.comBox_DesStore = new System.Windows.Forms.ComboBox();
            this.lbl_DesStore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransferOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comBox_Supplier
            // 
            this.comBox_Supplier.FormattingEnabled = true;
            this.comBox_Supplier.Location = new System.Drawing.Point(259, 348);
            this.comBox_Supplier.Name = "comBox_Supplier";
            this.comBox_Supplier.Size = new System.Drawing.Size(213, 24);
            this.comBox_Supplier.TabIndex = 94;
            // 
            // dgv_TransferOrderItems
            // 
            this.dgv_TransferOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransferOrderItems.Location = new System.Drawing.Point(498, 97);
            this.dgv_TransferOrderItems.Name = "dgv_TransferOrderItems";
            this.dgv_TransferOrderItems.RowHeadersWidth = 51;
            this.dgv_TransferOrderItems.RowTemplate.Height = 24;
            this.dgv_TransferOrderItems.Size = new System.Drawing.Size(337, 156);
            this.dgv_TransferOrderItems.TabIndex = 93;
            // 
            // date_Exp
            // 
            this.date_Exp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Exp.Location = new System.Drawing.Point(259, 462);
            this.date_Exp.Name = "date_Exp";
            this.date_Exp.Size = new System.Drawing.Size(213, 22);
            this.date_Exp.TabIndex = 92;
            // 
            // date_Prod
            // 
            this.date_Prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Prod.Location = new System.Drawing.Point(259, 405);
            this.date_Prod.Name = "date_Prod";
            this.date_Prod.Size = new System.Drawing.Size(213, 22);
            this.date_Prod.TabIndex = 91;
            // 
            // date_Order
            // 
            this.date_Order.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Order.Location = new System.Drawing.Point(259, 204);
            this.date_Order.Name = "date_Order";
            this.date_Order.Size = new System.Drawing.Size(213, 22);
            this.date_Order.TabIndex = 90;
            // 
            // comBox_SrcStore
            // 
            this.comBox_SrcStore.FormattingEnabled = true;
            this.comBox_SrcStore.Location = new System.Drawing.Point(259, 255);
            this.comBox_SrcStore.Name = "comBox_SrcStore";
            this.comBox_SrcStore.Size = new System.Drawing.Size(213, 24);
            this.comBox_SrcStore.TabIndex = 89;
            this.comBox_SrcStore.SelectedIndexChanged += new System.EventHandler(this.comBox_SrcStore_SelectedIndexChanged);
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.AutoSize = true;
            this.lbl_ExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(86, 462);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(114, 22);
            this.lbl_ExpiryDate.TabIndex = 88;
            this.lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.Location = new System.Drawing.Point(86, 350);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(84, 22);
            this.lbl_Supplier.TabIndex = 87;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // lbl_ProdDate
            // 
            this.lbl_ProdDate.AutoSize = true;
            this.lbl_ProdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdDate.Location = new System.Drawing.Point(86, 405);
            this.lbl_ProdDate.Name = "lbl_ProdDate";
            this.lbl_ProdDate.Size = new System.Drawing.Size(154, 22);
            this.lbl_ProdDate.TabIndex = 86;
            this.lbl_ProdDate.Text = "Production Date";
            // 
            // lbl_TransferOrder
            // 
            this.lbl_TransferOrder.AutoSize = true;
            this.lbl_TransferOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TransferOrder.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransferOrder.Location = new System.Drawing.Point(84, 39);
            this.lbl_TransferOrder.Name = "lbl_TransferOrder";
            this.lbl_TransferOrder.Size = new System.Drawing.Size(250, 34);
            this.lbl_TransferOrder.TabIndex = 85;
            this.lbl_TransferOrder.Text = "Transfer Order";
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDate.Location = new System.Drawing.Point(86, 204);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(109, 22);
            this.lbl_OrderDate.TabIndex = 84;
            this.lbl_OrderDate.Text = "Order Date";
            // 
            // lbl_SrcStore
            // 
            this.lbl_SrcStore.AutoSize = true;
            this.lbl_SrcStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrcStore.Location = new System.Drawing.Point(86, 257);
            this.lbl_SrcStore.Name = "lbl_SrcStore";
            this.lbl_SrcStore.Size = new System.Drawing.Size(127, 22);
            this.lbl_SrcStore.TabIndex = 83;
            this.lbl_SrcStore.Text = "Source Store";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(343, 527);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(255, 36);
            this.btn_Add.TabIndex = 81;
            this.btn_Add.Text = "Transfer products";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_OrderNum
            // 
            this.lbl_OrderNum.AutoSize = true;
            this.lbl_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNum.Location = new System.Drawing.Point(86, 150);
            this.lbl_OrderNum.Name = "lbl_OrderNum";
            this.lbl_OrderNum.Size = new System.Drawing.Size(136, 22);
            this.lbl_OrderNum.TabIndex = 80;
            this.lbl_OrderNum.Text = "Order Number";
            // 
            // tBox_OrderNum
            // 
            this.tBox_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_OrderNum.Location = new System.Drawing.Point(259, 147);
            this.tBox_OrderNum.Name = "tBox_OrderNum";
            this.tBox_OrderNum.Size = new System.Drawing.Size(213, 28);
            this.tBox_OrderNum.TabIndex = 79;
            // 
            // comBox_TransferOrder
            // 
            this.comBox_TransferOrder.FormattingEnabled = true;
            this.comBox_TransferOrder.Location = new System.Drawing.Point(186, 97);
            this.comBox_TransferOrder.Name = "comBox_TransferOrder";
            this.comBox_TransferOrder.Size = new System.Drawing.Size(225, 24);
            this.comBox_TransferOrder.TabIndex = 78;
            this.comBox_TransferOrder.Text = "Choose Transfer Order ID";
            this.comBox_TransferOrder.SelectedIndexChanged += new System.EventHandler(this.comBox_TransferOrder_SelectedIndexChanged);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(513, 366);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(85, 22);
            this.lbl_Quantity.TabIndex = 98;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(513, 315);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(85, 22);
            this.lbl_Product.TabIndex = 97;
            this.lbl_Product.Text = "Product ";
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(661, 366);
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
            this.num_Quantity.TabIndex = 96;
            this.num_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comBox_Product
            // 
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(661, 317);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(161, 24);
            this.comBox_Product.TabIndex = 95;
            // 
            // comBox_DesStore
            // 
            this.comBox_DesStore.FormattingEnabled = true;
            this.comBox_DesStore.Location = new System.Drawing.Point(259, 303);
            this.comBox_DesStore.Name = "comBox_DesStore";
            this.comBox_DesStore.Size = new System.Drawing.Size(213, 24);
            this.comBox_DesStore.TabIndex = 100;
            // 
            // lbl_DesStore
            // 
            this.lbl_DesStore.AutoSize = true;
            this.lbl_DesStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesStore.Location = new System.Drawing.Point(86, 305);
            this.lbl_DesStore.Name = "lbl_DesStore";
            this.lbl_DesStore.Size = new System.Drawing.Size(165, 22);
            this.lbl_DesStore.TabIndex = 99;
            this.lbl_DesStore.Text = "Destination Store";
            // 
            // frmTransferItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.comBox_DesStore);
            this.Controls.Add(this.lbl_DesStore);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.comBox_Supplier);
            this.Controls.Add(this.dgv_TransferOrderItems);
            this.Controls.Add(this.date_Exp);
            this.Controls.Add(this.date_Prod);
            this.Controls.Add(this.date_Order);
            this.Controls.Add(this.comBox_SrcStore);
            this.Controls.Add(this.lbl_ExpiryDate);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.lbl_ProdDate);
            this.Controls.Add(this.lbl_TransferOrder);
            this.Controls.Add(this.lbl_OrderDate);
            this.Controls.Add(this.lbl_SrcStore);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_OrderNum);
            this.Controls.Add(this.tBox_OrderNum);
            this.Controls.Add(this.comBox_TransferOrder);
            this.Name = "frmTransferItem";
            this.Size = new System.Drawing.Size(1043, 673);
            this.Load += new System.EventHandler(this.frmTransferItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransferOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comBox_Supplier;
        private System.Windows.Forms.DataGridView dgv_TransferOrderItems;
        private System.Windows.Forms.DateTimePicker date_Exp;
        private System.Windows.Forms.DateTimePicker date_Prod;
        private System.Windows.Forms.DateTimePicker date_Order;
        private System.Windows.Forms.ComboBox comBox_SrcStore;
        private System.Windows.Forms.Label lbl_ExpiryDate;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_ProdDate;
        private System.Windows.Forms.Label lbl_TransferOrder;
        private System.Windows.Forms.Label lbl_OrderDate;
        private System.Windows.Forms.Label lbl_SrcStore;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_OrderNum;
        private System.Windows.Forms.TextBox tBox_OrderNum;
        private System.Windows.Forms.ComboBox comBox_TransferOrder;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.ComboBox comBox_Product;
        private System.Windows.Forms.ComboBox comBox_DesStore;
        private System.Windows.Forms.Label lbl_DesStore;
    }
}
