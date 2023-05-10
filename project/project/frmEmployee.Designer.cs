namespace project
{
    partial class frmEmployee
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
            this.comBox_Emp = new System.Windows.Forms.ComboBox();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.num_Salary = new System.Windows.Forms.NumericUpDown();
            this.lbl_Emp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // comBox_Emp
            // 
            this.comBox_Emp.FormattingEnabled = true;
            this.comBox_Emp.Location = new System.Drawing.Point(190, 90);
            this.comBox_Emp.Name = "comBox_Emp";
            this.comBox_Emp.Size = new System.Drawing.Size(225, 24);
            this.comBox_Emp.TabIndex = 0;
            this.comBox_Emp.Text = "Choose Employee ID";
            this.comBox_Emp.SelectedIndexChanged += new System.EventHandler(this.comBox_Emp_SelectedIndexChanged);
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Name.Location = new System.Drawing.Point(190, 175);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(213, 28);
            this.tBox_Name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(90, 178);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 22);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(95, 449);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(196, 36);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add Employee";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(336, 449);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 36);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Modify Employee";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(579, 449);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(210, 36);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Remove Employee";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(90, 287);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 22);
            this.lbl_Email.TabIndex = 7;
            this.lbl_Email.Text = "Email";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Email.Location = new System.Drawing.Point(190, 284);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(213, 28);
            this.tBox_Email.TabIndex = 6;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(90, 232);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(67, 22);
            this.lbl_Phone.TabIndex = 9;
            this.lbl_Phone.Text = "Phone";
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Phone.Location = new System.Drawing.Point(190, 229);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(213, 28);
            this.tBox_Phone.TabIndex = 8;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(90, 342);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(67, 22);
            this.lbl_Salary.TabIndex = 11;
            this.lbl_Salary.Text = "Salary";
            // 
            // num_Salary
            // 
            this.num_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Salary.Location = new System.Drawing.Point(190, 345);
            this.num_Salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Salary.Name = "num_Salary";
            this.num_Salary.Size = new System.Drawing.Size(165, 28);
            this.num_Salary.TabIndex = 12;
            // 
            // lbl_Emp
            // 
            this.lbl_Emp.AutoSize = true;
            this.lbl_Emp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Emp.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp.Location = new System.Drawing.Point(88, 32);
            this.lbl_Emp.Name = "lbl_Emp";
            this.lbl_Emp.Size = new System.Drawing.Size(169, 34);
            this.lbl_Emp.TabIndex = 13;
            this.lbl_Emp.Text = "Employee";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbl_Emp);
            this.Controls.Add(this.num_Salary);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.comBox_Emp);
            this.Name = "frmEmployee";
            this.Size = new System.Drawing.Size(1019, 577);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox_Emp;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tBox_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.NumericUpDown num_Salary;
        private System.Windows.Forms.Label lbl_Emp;
    }
}
