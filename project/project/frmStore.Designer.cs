namespace project
{
    partial class frmStore
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
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tBox_Address = new System.Windows.Forms.TextBox();
            this.lbl_Mgr = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.lbl_Store = new System.Windows.Forms.Label();
            this.comBox_Mgr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(106, 264);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(83, 22);
            this.lbl_Address.TabIndex = 22;
            this.lbl_Address.Text = "Address";
            // 
            // tBox_Address
            // 
            this.tBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Address.Location = new System.Drawing.Point(206, 261);
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(213, 28);
            this.tBox_Address.TabIndex = 21;
            // 
            // lbl_Mgr
            // 
            this.lbl_Mgr.AutoSize = true;
            this.lbl_Mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mgr.Location = new System.Drawing.Point(106, 319);
            this.lbl_Mgr.Name = "lbl_Mgr";
            this.lbl_Mgr.Size = new System.Drawing.Size(87, 22);
            this.lbl_Mgr.TabIndex = 20;
            this.lbl_Mgr.Text = "Manager";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(595, 481);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(210, 36);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Remove Store";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(352, 481);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Modify Store";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(111, 481);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add Store";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(106, 210);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 22);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "Name";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Name.Location = new System.Drawing.Point(206, 207);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(213, 28);
            this.tBox_Name.TabIndex = 14;
            // 
            // comBox_Store
            // 
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(206, 91);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(225, 24);
            this.comBox_Store.TabIndex = 13;
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // lbl_Store
            // 
            this.lbl_Store.AutoSize = true;
            this.lbl_Store.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Store.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store.Location = new System.Drawing.Point(105, 31);
            this.lbl_Store.Name = "lbl_Store";
            this.lbl_Store.Size = new System.Drawing.Size(100, 34);
            this.lbl_Store.TabIndex = 25;
            this.lbl_Store.Text = "Store";
            // 
            // comBox_Mgr
            // 
            this.comBox_Mgr.FormattingEnabled = true;
            this.comBox_Mgr.Location = new System.Drawing.Point(206, 317);
            this.comBox_Mgr.Name = "comBox_Mgr";
            this.comBox_Mgr.Size = new System.Drawing.Size(213, 24);
            this.comBox_Mgr.TabIndex = 26;
            this.comBox_Mgr.SelectedIndexChanged += new System.EventHandler(this.comBox_Mgr_SelectedIndexChanged);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.comBox_Mgr);
            this.Controls.Add(this.lbl_Store);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tBox_Address);
            this.Controls.Add(this.lbl_Mgr);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.comBox_Store);
            this.Name = "frmStore";
            this.Size = new System.Drawing.Size(906, 589);
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tBox_Address;
        private System.Windows.Forms.Label lbl_Mgr;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Label lbl_Store;
        private System.Windows.Forms.ComboBox comBox_Mgr;
    }
}
