namespace project
{
    partial class frmProductExpReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_SupplyOrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StoreReport
            // 
            this.lbl_StoreReport.AutoSize = true;
            this.lbl_StoreReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StoreReport.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreReport.Location = new System.Drawing.Point(328, -46);
            this.lbl_StoreReport.Name = "lbl_StoreReport";
            this.lbl_StoreReport.Size = new System.Drawing.Size(217, 34);
            this.lbl_StoreReport.TabIndex = 48;
            this.lbl_StoreReport.Text = "Store Report";
            // 
            // comBox_Store
            // 
            this.comBox_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(338, 153);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(236, 28);
            this.comBox_Store.TabIndex = 47;
            this.comBox_Store.Text = "Choose store";
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 60;
            this.label1.Text = "Expiration Report";
            // 
            // dgv_SupplyOrderList
            // 
            this.dgv_SupplyOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplyOrderList.Location = new System.Drawing.Point(105, 249);
            this.dgv_SupplyOrderList.Name = "dgv_SupplyOrderList";
            this.dgv_SupplyOrderList.RowHeadersWidth = 51;
            this.dgv_SupplyOrderList.RowTemplate.Height = 24;
            this.dgv_SupplyOrderList.Size = new System.Drawing.Size(760, 232);
            this.dgv_SupplyOrderList.TabIndex = 61;
            // 
            // frmProductExpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_SupplyOrderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_StoreReport);
            this.Controls.Add(this.comBox_Store);
            this.Name = "frmProductExpReport";
            this.Size = new System.Drawing.Size(977, 652);
            this.Load += new System.EventHandler(this.frmProductExpReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplyOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_StoreReport;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_SupplyOrderList;
    }
}
