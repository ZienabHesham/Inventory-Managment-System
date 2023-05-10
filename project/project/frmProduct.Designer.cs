namespace project
{
    partial class frmProduct
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
            this.lbl_Store = new System.Windows.Forms.Label();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comBox_Product
            // 
            this.comBox_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Product.FormattingEnabled = true;
            this.comBox_Product.Location = new System.Drawing.Point(406, 86);
            this.comBox_Product.Name = "comBox_Product";
            this.comBox_Product.Size = new System.Drawing.Size(236, 28);
            this.comBox_Product.TabIndex = 82;
            this.comBox_Product.Text = "Choose product";
            this.comBox_Product.SelectedIndexChanged += new System.EventHandler(this.comBox_Product_SelectedIndexChanged);
            // 
            // tBox_Qty
            // 
            this.tBox_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Qty.Location = new System.Drawing.Point(159, 291);
            this.tBox_Qty.Name = "tBox_Qty";
            this.tBox_Qty.Size = new System.Drawing.Size(213, 28);
            this.tBox_Qty.TabIndex = 81;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(59, 239);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(39, 22);
            this.lbl_Address.TabIndex = 80;
            this.lbl_Address.Text = "MU";
            // 
            // tBox_MU
            // 
            this.tBox_MU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_MU.Location = new System.Drawing.Point(159, 236);
            this.tBox_MU.Name = "tBox_MU";
            this.tBox_MU.Size = new System.Drawing.Size(213, 28);
            this.tBox_MU.TabIndex = 79;
            // 
            // lbl_Mgr
            // 
            this.lbl_Mgr.AutoSize = true;
            this.lbl_Mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mgr.Location = new System.Drawing.Point(59, 294);
            this.lbl_Mgr.Name = "lbl_Mgr";
            this.lbl_Mgr.Size = new System.Drawing.Size(85, 22);
            this.lbl_Mgr.TabIndex = 78;
            this.lbl_Mgr.Text = "Quantity";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(59, 185);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(57, 22);
            this.lbl_Name.TabIndex = 77;
            this.lbl_Name.Text = "Code";
            // 
            // tBox_Code
            // 
            this.tBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Code.Location = new System.Drawing.Point(159, 182);
            this.tBox_Code.Name = "tBox_Code";
            this.tBox_Code.Size = new System.Drawing.Size(213, 28);
            this.tBox_Code.TabIndex = 76;
            // 
            // lbl_StoreReport
            // 
            this.lbl_StoreReport.AutoSize = true;
            this.lbl_StoreReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StoreReport.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreReport.Location = new System.Drawing.Point(141, 36);
            this.lbl_StoreReport.Name = "lbl_StoreReport";
            this.lbl_StoreReport.Size = new System.Drawing.Size(148, 34);
            this.lbl_StoreReport.TabIndex = 75;
            this.lbl_StoreReport.Text = "Product ";
            // 
            // lbl_Store
            // 
            this.lbl_Store.AutoSize = true;
            this.lbl_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store.Location = new System.Drawing.Point(59, 360);
            this.lbl_Store.Name = "lbl_Store";
            this.lbl_Store.Size = new System.Drawing.Size(58, 22);
            this.lbl_Store.TabIndex = 83;
            this.lbl_Store.Text = "Store";
            // 
            // comBox_Store
            // 
            this.comBox_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(159, 360);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(213, 28);
            this.comBox_Store.TabIndex = 84;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(649, 472);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(210, 36);
            this.btn_Delete.TabIndex = 87;
            this.btn_Delete.Text = "Remove Product";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(406, 472);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 86;
            this.btn_Edit.Text = "Modify Product";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(165, 472);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 85;
            this.btn_Add.Text = "Add Product";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "Name";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Name.Location = new System.Drawing.Point(159, 122);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(213, 28);
            this.tBox_Name.TabIndex = 88;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comBox_Store);
            this.Controls.Add(this.lbl_Store);
            this.Controls.Add(this.comBox_Product);
            this.Controls.Add(this.tBox_Qty);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tBox_MU);
            this.Controls.Add(this.lbl_Mgr);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Code);
            this.Controls.Add(this.lbl_StoreReport);
            this.Name = "frmProduct";
            this.Size = new System.Drawing.Size(1000, 548);
            this.Load += new System.EventHandler(this.frmProduct_Load);
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
        private System.Windows.Forms.Label lbl_Store;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_Name;
    }
}
