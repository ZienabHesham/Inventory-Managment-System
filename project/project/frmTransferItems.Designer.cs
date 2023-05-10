namespace project
{
    partial class frmTransferItems
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
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.comBox_Store = new System.Windows.Forms.ComboBox();
            this.lbl_StoreReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(167, 214);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 24;
            this.dgv_ProductList.Size = new System.Drawing.Size(668, 233);
            this.dgv_ProductList.TabIndex = 84;
            this.dgv_ProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellContentClick);
            // 
            // comBox_Store
            // 
            this.comBox_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Store.FormattingEnabled = true;
            this.comBox_Store.Location = new System.Drawing.Point(374, 104);
            this.comBox_Store.Name = "comBox_Store";
            this.comBox_Store.Size = new System.Drawing.Size(236, 28);
            this.comBox_Store.TabIndex = 76;
            this.comBox_Store.Text = "Choose store";
            this.comBox_Store.SelectedIndexChanged += new System.EventHandler(this.comBox_Store_SelectedIndexChanged);
            // 
            // lbl_StoreReport
            // 
            this.lbl_StoreReport.AutoSize = true;
            this.lbl_StoreReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_StoreReport.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreReport.Location = new System.Drawing.Point(298, 26);
            this.lbl_StoreReport.Name = "lbl_StoreReport";
            this.lbl_StoreReport.Size = new System.Drawing.Size(370, 34);
            this.lbl_StoreReport.TabIndex = 85;
            this.lbl_StoreReport.Text = "Transfer Items Report";
            // 
            // frmTransferItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_StoreReport);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.comBox_Store);
            this.Name = "frmTransferItems";
            this.Size = new System.Drawing.Size(992, 653);
            this.Load += new System.EventHandler(this.frmTransferItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.ComboBox comBox_Store;
        private System.Windows.Forms.Label lbl_StoreReport;
    }
}
