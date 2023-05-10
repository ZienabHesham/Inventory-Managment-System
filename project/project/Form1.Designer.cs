namespace project
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Store = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Supplier = new System.Windows.Forms.Button();
            this.btn_SupplyOrder = new System.Windows.Forms.Button();
            this.btn_IssueOrder = new System.Windows.Forms.Button();
            this.btn_TransferOrder = new System.Windows.Forms.Button();
            this.btn_ReportStore = new System.Windows.Forms.Button();
            this.btn_ProductReport = new System.Windows.Forms.Button();
            this.btn_TransItmReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.frmProductReport21 = new project.frmProductReport2();
            this.frmTransferItems1 = new project.frmTransferItems();
            this.frmProductExpReport1 = new project.frmProductExpReport();
            this.frmStoreReport1 = new project.frmStoreReport();
            this.frmIssueOrder1 = new project.frmIssueOrder();
            this.frmTransferItem1 = new project.frmTransferItem();
            this.frmSupplyOrder1 = new project.frmSupplyOrder();
            this.frmEmployee1 = new project.frmEmployee();
            this.frmSupplier1 = new project.frmSupplier();
            this.frmCustomer1 = new project.frmCustomer();
            this.frmProduct1 = new project.frmProduct();
            this.frmStore1 = new project.frmStore();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SideBar.Controls.Add(this.btn_Store);
            this.SideBar.Controls.Add(this.btn_Product);
            this.SideBar.Controls.Add(this.btn_Customer);
            this.SideBar.Controls.Add(this.btn_Supplier);
            this.SideBar.Controls.Add(this.btn_Employee);
            this.SideBar.Controls.Add(this.btn_SupplyOrder);
            this.SideBar.Controls.Add(this.btn_TransferOrder);
            this.SideBar.Controls.Add(this.btn_IssueOrder);
            this.SideBar.Controls.Add(this.btn_ReportStore);
            this.SideBar.Controls.Add(this.button1);
            this.SideBar.Controls.Add(this.btn_TransItmReport);
            this.SideBar.Controls.Add(this.btn_ProductReport);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(233, 625);
            this.SideBar.TabIndex = 0;
            // 
            // btn_Store
            // 
            this.btn_Store.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Store.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Store.Location = new System.Drawing.Point(3, 3);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(222, 46);
            this.btn_Store.TabIndex = 2;
            this.btn_Store.Text = "Store";
            this.btn_Store.UseVisualStyleBackColor = false;
            this.btn_Store.Click += new System.EventHandler(this.btn_Store_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Customer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(3, 107);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(222, 46);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Employee.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.Location = new System.Drawing.Point(3, 211);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(222, 46);
            this.btn_Employee.TabIndex = 3;
            this.btn_Employee.Text = "Employee";
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Supplier.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supplier.Location = new System.Drawing.Point(3, 159);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Size = new System.Drawing.Size(222, 46);
            this.btn_Supplier.TabIndex = 4;
            this.btn_Supplier.Text = "Supplier";
            this.btn_Supplier.UseVisualStyleBackColor = false;
            this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
            // 
            // btn_SupplyOrder
            // 
            this.btn_SupplyOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SupplyOrder.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SupplyOrder.Location = new System.Drawing.Point(3, 263);
            this.btn_SupplyOrder.Name = "btn_SupplyOrder";
            this.btn_SupplyOrder.Size = new System.Drawing.Size(222, 46);
            this.btn_SupplyOrder.TabIndex = 5;
            this.btn_SupplyOrder.Text = "Supply Order";
            this.btn_SupplyOrder.UseVisualStyleBackColor = false;
            this.btn_SupplyOrder.Click += new System.EventHandler(this.btn_SupplyOrder_Click);
            // 
            // btn_IssueOrder
            // 
            this.btn_IssueOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_IssueOrder.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IssueOrder.Location = new System.Drawing.Point(3, 367);
            this.btn_IssueOrder.Name = "btn_IssueOrder";
            this.btn_IssueOrder.Size = new System.Drawing.Size(222, 46);
            this.btn_IssueOrder.TabIndex = 6;
            this.btn_IssueOrder.Text = "Issue Order";
            this.btn_IssueOrder.UseVisualStyleBackColor = false;
            this.btn_IssueOrder.Click += new System.EventHandler(this.btn_IssueOrder_Click);
            // 
            // btn_TransferOrder
            // 
            this.btn_TransferOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TransferOrder.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransferOrder.Location = new System.Drawing.Point(3, 315);
            this.btn_TransferOrder.Name = "btn_TransferOrder";
            this.btn_TransferOrder.Size = new System.Drawing.Size(222, 46);
            this.btn_TransferOrder.TabIndex = 7;
            this.btn_TransferOrder.Text = "Transfer Order";
            this.btn_TransferOrder.UseVisualStyleBackColor = false;
            this.btn_TransferOrder.Click += new System.EventHandler(this.btn_TransferOrder_Click);
            // 
            // btn_ReportStore
            // 
            this.btn_ReportStore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ReportStore.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportStore.Location = new System.Drawing.Point(3, 419);
            this.btn_ReportStore.Name = "btn_ReportStore";
            this.btn_ReportStore.Size = new System.Drawing.Size(222, 46);
            this.btn_ReportStore.TabIndex = 8;
            this.btn_ReportStore.Text = "Store Report";
            this.btn_ReportStore.UseVisualStyleBackColor = false;
            this.btn_ReportStore.Click += new System.EventHandler(this.btn_ReportStore_Click);
            // 
            // btn_ProductReport
            // 
            this.btn_ProductReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ProductReport.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductReport.Location = new System.Drawing.Point(3, 575);
            this.btn_ProductReport.Name = "btn_ProductReport";
            this.btn_ProductReport.Size = new System.Drawing.Size(222, 46);
            this.btn_ProductReport.TabIndex = 9;
            this.btn_ProductReport.Text = "Product Report";
            this.btn_ProductReport.UseVisualStyleBackColor = false;
            this.btn_ProductReport.Click += new System.EventHandler(this.btn_ProductReport_Click);
            // 
            // btn_TransItmReport
            // 
            this.btn_TransItmReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TransItmReport.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransItmReport.Location = new System.Drawing.Point(3, 523);
            this.btn_TransItmReport.Name = "btn_TransItmReport";
            this.btn_TransItmReport.Size = new System.Drawing.Size(222, 46);
            this.btn_TransItmReport.TabIndex = 10;
            this.btn_TransItmReport.Text = "Transfer Report";
            this.btn_TransItmReport.UseVisualStyleBackColor = false;
            this.btn_TransItmReport.Click += new System.EventHandler(this.btn_TransItmReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Expiration Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Product.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.Location = new System.Drawing.Point(3, 55);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(222, 46);
            this.btn_Product.TabIndex = 12;
            this.btn_Product.Text = "Product ";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // frmProductReport21
            // 
            this.frmProductReport21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmProductReport21.Location = new System.Drawing.Point(233, 0);
            this.frmProductReport21.Name = "frmProductReport21";
            this.frmProductReport21.Size = new System.Drawing.Size(841, 625);
            this.frmProductReport21.TabIndex = 12;
            this.frmProductReport21.Load += new System.EventHandler(this.frmProductReport21_Load);
            // 
            // frmTransferItems1
            // 
            this.frmTransferItems1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTransferItems1.Location = new System.Drawing.Point(233, 0);
            this.frmTransferItems1.Name = "frmTransferItems1";
            this.frmTransferItems1.Size = new System.Drawing.Size(841, 625);
            this.frmTransferItems1.TabIndex = 11;
            // 
            // frmProductExpReport1
            // 
            this.frmProductExpReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmProductExpReport1.Location = new System.Drawing.Point(233, 0);
            this.frmProductExpReport1.Name = "frmProductExpReport1";
            this.frmProductExpReport1.Size = new System.Drawing.Size(841, 625);
            this.frmProductExpReport1.TabIndex = 10;
            // 
            // frmStoreReport1
            // 
            this.frmStoreReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmStoreReport1.Location = new System.Drawing.Point(233, 0);
            this.frmStoreReport1.Name = "frmStoreReport1";
            this.frmStoreReport1.Size = new System.Drawing.Size(841, 625);
            this.frmStoreReport1.TabIndex = 9;
            // 
            // frmIssueOrder1
            // 
            this.frmIssueOrder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmIssueOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmIssueOrder1.Location = new System.Drawing.Point(233, 0);
            this.frmIssueOrder1.Name = "frmIssueOrder1";
            this.frmIssueOrder1.Size = new System.Drawing.Size(841, 625);
            this.frmIssueOrder1.TabIndex = 8;
            // 
            // frmTransferItem1
            // 
            this.frmTransferItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmTransferItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTransferItem1.Location = new System.Drawing.Point(233, 0);
            this.frmTransferItem1.Name = "frmTransferItem1";
            this.frmTransferItem1.Size = new System.Drawing.Size(841, 625);
            this.frmTransferItem1.TabIndex = 7;
            // 
            // frmSupplyOrder1
            // 
            this.frmSupplyOrder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmSupplyOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSupplyOrder1.Location = new System.Drawing.Point(233, 0);
            this.frmSupplyOrder1.Name = "frmSupplyOrder1";
            this.frmSupplyOrder1.Size = new System.Drawing.Size(841, 625);
            this.frmSupplyOrder1.TabIndex = 6;
            // 
            // frmEmployee1
            // 
            this.frmEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmEmployee1.Location = new System.Drawing.Point(233, 0);
            this.frmEmployee1.Name = "frmEmployee1";
            this.frmEmployee1.Size = new System.Drawing.Size(841, 625);
            this.frmEmployee1.TabIndex = 5;
            // 
            // frmSupplier1
            // 
            this.frmSupplier1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmSupplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSupplier1.Location = new System.Drawing.Point(233, 0);
            this.frmSupplier1.Name = "frmSupplier1";
            this.frmSupplier1.Size = new System.Drawing.Size(841, 625);
            this.frmSupplier1.TabIndex = 4;
            // 
            // frmCustomer1
            // 
            this.frmCustomer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmCustomer1.Location = new System.Drawing.Point(233, 0);
            this.frmCustomer1.Name = "frmCustomer1";
            this.frmCustomer1.Size = new System.Drawing.Size(841, 625);
            this.frmCustomer1.TabIndex = 3;
            // 
            // frmProduct1
            // 
            this.frmProduct1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmProduct1.Location = new System.Drawing.Point(233, 0);
            this.frmProduct1.Name = "frmProduct1";
            this.frmProduct1.Size = new System.Drawing.Size(841, 625);
            this.frmProduct1.TabIndex = 2;
            // 
            // frmStore1
            // 
            this.frmStore1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmStore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmStore1.Location = new System.Drawing.Point(233, 0);
            this.frmStore1.Name = "frmStore1";
            this.frmStore1.Size = new System.Drawing.Size(841, 625);
            this.frmStore1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 625);
            this.Controls.Add(this.frmProductReport21);
            this.Controls.Add(this.frmTransferItems1);
            this.Controls.Add(this.frmProductExpReport1);
            this.Controls.Add(this.frmStoreReport1);
            this.Controls.Add(this.frmIssueOrder1);
            this.Controls.Add(this.frmTransferItem1);
            this.Controls.Add(this.frmSupplyOrder1);
            this.Controls.Add(this.frmEmployee1);
            this.Controls.Add(this.frmSupplier1);
            this.Controls.Add(this.frmCustomer1);
            this.Controls.Add(this.frmProduct1);
            this.Controls.Add(this.frmStore1);
            this.Controls.Add(this.SideBar);
            this.Name = "Form1";
            this.Text = "Inventory Mangment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Store;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_Supplier;
        private System.Windows.Forms.Button btn_SupplyOrder;
        private System.Windows.Forms.Button btn_IssueOrder;
        private System.Windows.Forms.Button btn_TransferOrder;
        private System.Windows.Forms.Button btn_ReportStore;
        private System.Windows.Forms.Button btn_ProductReport;
        private System.Windows.Forms.Button btn_TransItmReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Product;
        private frmStore frmStore1;
        private frmProduct frmProduct1;
        private frmCustomer frmCustomer1;
        private frmSupplier frmSupplier1;
        private frmEmployee frmEmployee1;
        private frmSupplyOrder frmSupplyOrder1;
        private frmTransferItem frmTransferItem1;
        private frmIssueOrder frmIssueOrder1;
        private frmStoreReport frmStoreReport1;
        private frmProductExpReport frmProductExpReport1;
        private frmTransferItems frmTransferItems1;
        private frmProductReport2 frmProductReport21;
    }
}

