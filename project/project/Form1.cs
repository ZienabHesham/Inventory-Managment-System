using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        Context DB = new Context();
        frmEmployee frmEmployee = new frmEmployee();
        frmStore frmStore = new frmStore();
        frmStoreReport frmStoreReport = new frmStoreReport();

        frmCustomer frmCustomer =new frmCustomer();
        frmSupplier frmSupplier= new frmSupplier(); 
        frmSupplyOrder frmSupplyOrder = new frmSupplyOrder();
        frmIssueOrder frmIssueOrder = new frmIssueOrder();
        frmTransferItem frmTransferOrder = new frmTransferItem();
        frmProductReport2 frmProductReport= new frmProductReport2();
        frmTransferItems frmTransferItems = new frmTransferItems();
        frmProductExpReport frmProductExpReport= new frmProductExpReport();
        frmProduct frmProduct=new frmProduct();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_Store.Focus();
            frmStore1.Visible = true;
            frmCustomer1.Visible = false;
            frmEmployee1.Visible = false;
            frmSupplier1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frmCustomer1.Visible= true;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmSupplier1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;


            frmCustomer.LoadComboBox();
        }

        private void btn_Store_Click(object sender, EventArgs e)
        {
            frmStore1.Visible= true;
            frmCustomer1.Visible= false;
            frmEmployee1.Visible = false;
            frmSupplier1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmStore.StoreComBoxLoad();

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            frmEmployee1.Visible = true;
            frmStore1.Visible = false;
            frmCustomer1.Visible = false;
            frmSupplier1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmEmployee.LoadComboBox();
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            frmSupplier1.Visible = true;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmSupplier.LoadComboBox();
        }

        private void btn_SupplyOrder_Click(object sender, EventArgs e)
        {
            frmSupplyOrder1.Visible = true;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmSupplyOrder.LoadComboBox();
        }

        private void btn_IssueOrder_Click(object sender, EventArgs e)
        {
            frmIssueOrder1.Visible = true;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmTransferItem1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmIssueOrder.LoadComboBox();
        }

        private void btn_TransferOrder_Click(object sender, EventArgs e)
        {
            frmTransferItem1.Visible = true;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmStoreReport1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmTransferOrder.LoadComboBox();
        }

        private void btn_ReportStore_Click(object sender, EventArgs e)
        {
            frmStoreReport1.Visible = true;
            frmTransferItem1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmProductReport21.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;


            frmStoreReport.StoreComBoxLoad();
        }

        private void btn_ProductReport_Click(object sender, EventArgs e)
        {

            frmProductReport21.Visible = true;
            frmStoreReport1.Visible = false;
            frmTransferItem1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductExpReport1.Visible = false;
            frmProduct1.Visible = false;

            frmProductReport.ComBoxLoad();
        }

        private void btn_TransItmReport_Click(object sender, EventArgs e)
        {
            frmTransferItems1.Visible = true;
            frmProductReport21.Visible = false;
            frmStoreReport1.Visible = false;
            frmTransferItem1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmProduct1.Visible = false;

            frmTransferItems.ComBoxLoad();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProductExpReport1.Visible = true;
            frmTransferItems1.Visible = false;
            frmProductReport21.Visible = false;
            frmStoreReport1.Visible = false;
            frmTransferItem1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmProduct1.Visible = false;

            frmProductExpReport.StoreComBoxLoad();

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            frmProduct1.Visible = true;
            frmProductExpReport1.Visible = false;
            frmTransferItems1.Visible = false;
            frmProductReport21.Visible = false;
            frmStoreReport1.Visible = false;
            frmTransferItem1.Visible = false;
            frmIssueOrder1.Visible = false;
            frmSupplyOrder1.Visible = false;
            frmSupplier1.Visible = false;
            frmCustomer1.Visible = false;
            frmStore1.Visible = false;
            frmEmployee1.Visible = false;
            frmProduct.LoadComboBox();
        }
        private void frmStore1_Load(object sender, EventArgs e)
        {

        }
        private void frmEmployee1_Load(object sender, EventArgs e)
        {

        }

        

        private void frmProduct1_Load(object sender, EventArgs e)
        {

        }

        private void frmProductReport21_Load(object sender, EventArgs e)
        {

        }
    }
}
