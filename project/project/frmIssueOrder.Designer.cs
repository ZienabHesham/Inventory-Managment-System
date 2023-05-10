namespace project
{
    partial class frmIssueOrder
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
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.comBox_Product = new System.Windows.Forms.ComboBox();
            this.comBox_Supplier = new System.Windows.Forms.ComboBox();
            this.dgv_IssueOrderItems = new System.Windows.Forms.DataGridView();
            this.date_Order = new System.Windows.Forms.DateTimePicker();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_IssueOrder = new System.Windows.Forms.Label();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.lbl_Store = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_OrderNum = new System.Windows.Forms.Label();
            this.tBox_OrderNum = new System.Windows.Forms.TextBox();
            this.comBox_IssueOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(79, 428);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(85, 22);
            this.lbl_Quantity.TabIndex = 98;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(79, 377);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(85, 22);
            this.lbl_Product.TabIndex = 97;
            this.lbl_Product.Text = "Product ";
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(239, 426);
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
            this.comBox_Product.Location = new System.Drawing.Point(239, 377);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(161, 24);
            this.comBox_Product.TabIndex = 95;
            // 
            // comBox_Supplier
            // 
            this.comBox_Supplier.FormattingEnabled = true;
            this.comBox_Supplier.Location = new System.Drawing.Point(239, 309);
            this.comBox_Supplier.Name = "comBox_Supplier";
            this.comBox_Supplier.Size = new System.Drawing.Size(213, 24);
            this.comBox_Supplier.TabIndex = 94;
            // 
            // dgv_IssueOrderItems
            // 
            this.dgv_IssueOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IssueOrderItems.Location = new System.Drawing.Point(491, 93);
            this.dgv_IssueOrderItems.Name = "dgv_IssueOrderItems";
            this.dgv_IssueOrderItems.RowHeadersWidth = 51;
            this.dgv_IssueOrderItems.RowTemplate.Height = 24;
            this.dgv_IssueOrderItems.Size = new System.Drawing.Size(337, 156);
            this.dgv_IssueOrderItems.TabIndex = 93;
            // 
            // date_Order
            // 
            this.date_Order.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Order.Location = new System.Drawing.Point(239, 200);
            this.date_Order.Name = "date_Order";
            this.date_Order.Size = new System.Drawing.Size(213, 22);
            this.date_Order.TabIndex = 90;
            // 
            // comBox_Store
            // 
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(239, 253);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(213, 24);
            this.comBox_Store.TabIndex = 89;
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.Location = new System.Drawing.Point(79, 311);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(84, 22);
            this.lbl_Supplier.TabIndex = 87;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // lbl_IssueOrder
            // 
            this.lbl_IssueOrder.AutoSize = true;
            this.lbl_IssueOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_IssueOrder.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssueOrder.Location = new System.Drawing.Point(77, 35);
            this.lbl_IssueOrder.Name = "lbl_IssueOrder";
            this.lbl_IssueOrder.Size = new System.Drawing.Size(204, 34);
            this.lbl_IssueOrder.TabIndex = 85;
            this.lbl_IssueOrder.Text = "Issue Order";
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDate.Location = new System.Drawing.Point(79, 200);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(109, 22);
            this.lbl_OrderDate.TabIndex = 84;
            this.lbl_OrderDate.Text = "Order Date";
            // 
            // lbl_Store
            // 
            this.lbl_Store.AutoSize = true;
            this.lbl_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store.Location = new System.Drawing.Point(79, 255);
            this.lbl_Store.Name = "lbl_Store";
            this.lbl_Store.Size = new System.Drawing.Size(58, 22);
            this.lbl_Store.TabIndex = 83;
            this.lbl_Store.Text = "Store";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(325, 522);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 82;
            this.btn_Edit.Text = "Modify Issue Order";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(83, 522);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 81;
            this.btn_Add.Text = "Add Issue Order";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_OrderNum
            // 
            this.lbl_OrderNum.AutoSize = true;
            this.lbl_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNum.Location = new System.Drawing.Point(79, 146);
            this.lbl_OrderNum.Name = "lbl_OrderNum";
            this.lbl_OrderNum.Size = new System.Drawing.Size(136, 22);
            this.lbl_OrderNum.TabIndex = 80;
            this.lbl_OrderNum.Text = "Order Number";
            // 
            // tBox_OrderNum
            // 
            this.tBox_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_OrderNum.Location = new System.Drawing.Point(239, 143);
            this.tBox_OrderNum.Name = "tBox_OrderNum";
            this.tBox_OrderNum.Size = new System.Drawing.Size(213, 28);
            this.tBox_OrderNum.TabIndex = 79;
            // 
            // comBox_IssueOrder
            // 
            this.comBox_IssueOrder.FormattingEnabled = true;
            this.comBox_IssueOrder.Location = new System.Drawing.Point(179, 93);
            this.comBox_IssueOrder.Name = "comBox_IssueOrder";
            this.comBox_IssueOrder.Size = new System.Drawing.Size(225, 24);
            this.comBox_IssueOrder.TabIndex = 78;
            this.comBox_IssueOrder.Text = "Choose Issue Order ID";
            this.comBox_IssueOrder.SelectedIndexChanged += new System.EventHandler(this.comBox_IssueOrder_SelectedIndexChanged);
            // 
            // frmIssueOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.comBox_Supplier);
            this.Controls.Add(this.dgv_IssueOrderItems);
            this.Controls.Add(this.date_Order);
            this.Controls.Add(this.comBox_Store);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.lbl_IssueOrder);
            this.Controls.Add(this.lbl_OrderDate);
            this.Controls.Add(this.lbl_Store);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_OrderNum);
            this.Controls.Add(this.tBox_OrderNum);
            this.Controls.Add(this.comBox_IssueOrder);
            this.Name = "frmIssueOrder";
            this.Size = new System.Drawing.Size(1011, 659);
            this.Load += new System.EventHandler(this.frmIssueOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.ComboBox comBox_Product;
        private System.Windows.Forms.ComboBox comBox_Supplier;
        private System.Windows.Forms.DataGridView dgv_IssueOrderItems;
        private System.Windows.Forms.DateTimePicker date_Order;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_IssueOrder;
        private System.Windows.Forms.Label lbl_OrderDate;
        private System.Windows.Forms.Label lbl_Store;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_OrderNum;
        private System.Windows.Forms.TextBox tBox_OrderNum;
        private System.Windows.Forms.ComboBox comBox_IssueOrder;
    }
}
