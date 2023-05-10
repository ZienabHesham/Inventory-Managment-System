namespace project
{
    partial class frmCustomer
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
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.comBox_Customer = new System.Windows.Forms.ComboBox();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.tBox_Mobile = new System.Windows.Forms.TextBox();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.tBox_Fax = new System.Windows.Forms.TextBox();
            this.lbl_website = new System.Windows.Forms.Label();
            this.tBox_Website = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Customer.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(72, 32);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(167, 34);
            this.lbl_Customer.TabIndex = 26;
            this.lbl_Customer.Text = "Customer";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(74, 197);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(67, 22);
            this.lbl_Phone.TabIndex = 23;
            this.lbl_Phone.Text = "Phone";
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Phone.Location = new System.Drawing.Point(174, 194);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(213, 28);
            this.tBox_Phone.TabIndex = 22;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(74, 252);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 22);
            this.lbl_Email.TabIndex = 21;
            this.lbl_Email.Text = "Email";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Email.Location = new System.Drawing.Point(174, 249);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(213, 28);
            this.tBox_Email.TabIndex = 20;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(567, 496);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(210, 36);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Remove Customer";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(325, 496);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 18;
            this.btn_Edit.Text = "Modify Customer";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(83, 496);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Add Customer";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(74, 143);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 22);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Name.Location = new System.Drawing.Point(174, 140);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(213, 28);
            this.tBox_Name.TabIndex = 15;
            // 
            // comBox_Customer
            // 
            this.comBox_Customer.FormattingEnabled = true;
            this.comBox_Customer.Location = new System.Drawing.Point(174, 90);
            this.comBox_Customer.Name = "comBox_Customer";
            this.comBox_Customer.Size = new System.Drawing.Size(225, 24);
            this.comBox_Customer.TabIndex = 14;
            this.comBox_Customer.Text = "Choose customer ID";
            this.comBox_Customer.SelectedIndexChanged += new System.EventHandler(this.comBox_Customer_SelectedIndexChanged);
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.Location = new System.Drawing.Point(74, 308);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(68, 22);
            this.lbl_Mobile.TabIndex = 30;
            this.lbl_Mobile.Text = "Mobile";
            // 
            // tBox_Mobile
            // 
            this.tBox_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Mobile.Location = new System.Drawing.Point(174, 305);
            this.tBox_Mobile.Name = "tBox_Mobile";
            this.tBox_Mobile.Size = new System.Drawing.Size(213, 28);
            this.tBox_Mobile.TabIndex = 29;
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fax.Location = new System.Drawing.Point(74, 363);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(43, 22);
            this.lbl_Fax.TabIndex = 28;
            this.lbl_Fax.Text = "Fax";
            // 
            // tBox_Fax
            // 
            this.tBox_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Fax.Location = new System.Drawing.Point(174, 360);
            this.tBox_Fax.Name = "tBox_Fax";
            this.tBox_Fax.Size = new System.Drawing.Size(213, 28);
            this.tBox_Fax.TabIndex = 27;
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_website.Location = new System.Drawing.Point(74, 420);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(82, 22);
            this.lbl_website.TabIndex = 32;
            this.lbl_website.Text = "Website";
            // 
            // tBox_Website
            // 
            this.tBox_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Website.Location = new System.Drawing.Point(174, 417);
            this.tBox_Website.Name = "tBox_Website";
            this.tBox_Website.Size = new System.Drawing.Size(213, 28);
            this.tBox_Website.TabIndex = 31;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbl_website);
            this.Controls.Add(this.tBox_Website);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.tBox_Mobile);
            this.Controls.Add(this.lbl_Fax);
            this.Controls.Add(this.tBox_Fax);
            this.Controls.Add(this.lbl_Customer);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.comBox_Customer);
            this.Name = "frmCustomer";
            this.Size = new System.Drawing.Size(970, 623);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tBox_Email;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.ComboBox comBox_Customer;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.TextBox tBox_Mobile;
        private System.Windows.Forms.Label lbl_Fax;
        private System.Windows.Forms.TextBox tBox_Fax;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.TextBox tBox_Website;
    }
}
