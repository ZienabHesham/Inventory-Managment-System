namespace project
{
    partial class frmStoreReport
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
            this.lbl_StoreReport = new System.Windows.Forms.Label();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tBox_Address = new System.Windows.Forms.TextBox();
            this.lbl_Mgr = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_Mgr = new System.Windows.Forms.TextBox();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.dgv_SupplyOrderList = new System.Windows.Forms.DataGridView();
            this.lbl_ProductList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_IssueOrderList = new System.Windows.Forms.DataGridView();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_End = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StoreReport
            // 
            this.lbl_StoreReport.AutoSize = true;
            this.lbl_StoreReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StoreReport.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreReport.Location = new System.Drawing.Point(324, 29);
            this.lbl_StoreReport.Name = "lbl_StoreReport";
            this.lbl_StoreReport.Size = new System.Drawing.Size(217, 34);
            this.lbl_StoreReport.TabIndex = 27;
            this.lbl_StoreReport.Text = "Store Report";
            // 
            // comBox_Store
            // 
            this.comBox_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(318, 79);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(236, 28);
            this.comBox_Store.TabIndex = 26;
            this.comBox_Store.Text = "Choose store";
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(62, 190);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(83, 22);
            this.lbl_Address.TabIndex = 35;
            this.lbl_Address.Text = "Address";
            // 
            // tBox_Address
            // 
            this.tBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Address.Location = new System.Drawing.Point(162, 187);
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(213, 28);
            this.tBox_Address.TabIndex = 34;
            // 
            // lbl_Mgr
            // 
            this.lbl_Mgr.AutoSize = true;
            this.lbl_Mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mgr.Location = new System.Drawing.Point(62, 245);
            this.lbl_Mgr.Name = "lbl_Mgr";
            this.lbl_Mgr.Size = new System.Drawing.Size(87, 22);
            this.lbl_Mgr.TabIndex = 33;
            this.lbl_Mgr.Text = "Manager";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(62, 136);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 22);
            this.lbl_Name.TabIndex = 32;
            this.lbl_Name.Text = "Name";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Name.Location = new System.Drawing.Point(162, 133);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(213, 28);
            this.tBox_Name.TabIndex = 31;
            // 
            // tBox_Mgr
            // 
            this.tBox_Mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Mgr.Location = new System.Drawing.Point(162, 242);
            this.tBox_Mgr.Name = "tBox_Mgr";
            this.tBox_Mgr.Size = new System.Drawing.Size(213, 28);
            this.tBox_Mgr.TabIndex = 36;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(426, 133);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 24;
            this.dgv_ProductList.Size = new System.Drawing.Size(400, 150);
            this.dgv_ProductList.TabIndex = 37;
            // 
            // dgv_SupplyOrderList
            // 
            this.dgv_SupplyOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplyOrderList.Location = new System.Drawing.Point(66, 343);
            this.dgv_SupplyOrderList.Name = "dgv_SupplyOrderList";
            this.dgv_SupplyOrderList.RowHeadersWidth = 51;
            this.dgv_SupplyOrderList.RowTemplate.Height = 24;
            this.dgv_SupplyOrderList.Size = new System.Drawing.Size(760, 129);
            this.dgv_SupplyOrderList.TabIndex = 38;
            // 
            // lbl_ProductList
            // 
            this.lbl_ProductList.AutoSize = true;
            this.lbl_ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductList.Location = new System.Drawing.Point(563, 286);
            this.lbl_ProductList.Name = "lbl_ProductList";
            this.lbl_ProductList.Size = new System.Drawing.Size(117, 22);
            this.lbl_ProductList.TabIndex = 39;
            this.lbl_ProductList.Text = "Product List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Supply Order List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Issue Order List";
            // 
            // dgv_IssueOrderList
            // 
            this.dgv_IssueOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IssueOrderList.Location = new System.Drawing.Point(66, 509);
            this.dgv_IssueOrderList.Name = "dgv_IssueOrderList";
            this.dgv_IssueOrderList.RowHeadersWidth = 51;
            this.dgv_IssueOrderList.RowTemplate.Height = 24;
            this.dgv_IssueOrderList.Size = new System.Drawing.Size(760, 129);
            this.dgv_IssueOrderList.TabIndex = 41;
            // 
            // date_Start
            // 
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(175, 315);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(200, 22);
            this.date_Start.TabIndex = 43;
            this.date_Start.ValueChanged += new System.EventHandler(this.date_Start_ValueChanged);
            // 
            // date_End
            // 
            this.date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_End.Location = new System.Drawing.Point(516, 315);
            this.date_End.Name = "date_End";
            this.date_End.Size = new System.Drawing.Size(200, 22);
            this.date_End.TabIndex = 44;
            this.date_End.ValueChanged += new System.EventHandler(this.date_End_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(478, 315);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(32, 22);
            this.lbl_To.TabIndex = 46;
            this.lbl_To.Text = "To";
            // 
            // frmStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_End);
            this.Controls.Add(this.date_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_IssueOrderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ProductList);
            this.Controls.Add(this.dgv_SupplyOrderList);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.tBox_Mgr);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tBox_Address);
            this.Controls.Add(this.lbl_Mgr);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.lbl_StoreReport);
            this.Controls.Add(this.comBox_Store);
            this.Name = "frmStoreReport";
            this.Size = new System.Drawing.Size(958, 669);
            this.Load += new System.EventHandler(this.frmStoreReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StoreReport;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tBox_Address;
        private System.Windows.Forms.Label lbl_Mgr;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.TextBox tBox_Mgr;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.DataGridView dgv_SupplyOrderList;
        private System.Windows.Forms.Label lbl_ProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_IssueOrderList;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DateTimePicker date_End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_To;
    }
}
