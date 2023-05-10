using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmStoreReport : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            comBox_Store.Text = tBox_Mgr.Text = string.Empty;
            tBox_Name.Text = tBox_Address.Text = string.Empty;

        }
        public frmStoreReport()
        {
            InitializeComponent();
        }
        private void frmStoreReport_Load(object sender, EventArgs e)
        {
            StoreComBoxLoad();
            this.date_Start.Format = this.date_End.Format = DateTimePickerFormat.Custom;
            date_Start.CustomFormat = date_End.CustomFormat  = "yyyy/MM/dd";

        }
        public void StoreComBoxLoad()
        {
            foreach (Store store in DB.Stores)
            {
                comBox_Store.Items.Add(store.Name);
            }

        }
        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comBox_Store.Text;
            Store store = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());

            if (store != null)
            {
                tBox_Name.Text = store.Name;
                tBox_Address.Text = store.Address;
                tBox_Mgr.Text = store.PersonInCharge.Name;
            }
            LoadProductListGridView(store);
            LoadSupplyOrderListGridView(store);
            LoadIssueOrderListGridView(store);

        }

        private void LoadProductListGridView(Store selectedStore)
        {
            var query = from prod in DB.Products
                        where prod.Store.Id == selectedStore.Id
                        select new { prod.Code, prod.Name, prod.Quantity };

            dgv_ProductList.DataSource = query.ToList();
            dgv_ProductList.Columns["Code"].HeaderText = "Product Code";
            dgv_ProductList.Columns["Name"].HeaderText = "Product Name";
            dgv_ProductList.Columns["Quantity"].HeaderText = "Product Quantity";
        }
        private void LoadSupplyOrderListGridView(Store selectedStore)
        {
            DateTime startDate = date_Start.Value.Date;
            DateTime endDate = date_End.Value.Date;

            var query = from supOrdr in DB.SupplyOrders
                        join orderItem in DB.SupplyOrderItems on supOrdr.Id equals orderItem.SupplyOrderId
                        where supOrdr.Store.Id == selectedStore.Id && supOrdr.OrderDate >= startDate && supOrdr.OrderDate <= endDate
                        select new
                        {
                            supOrdr.OrderNumber,
                            supOrdr.OrderDate,
                            SupplierName = supOrdr.Supplier.Name,
                            ProductName = orderItem.Product.Name,
                            orderItem.Quantity,
                            supOrdr.ProductionDate,
                            supOrdr.ExpiryDate
                        };

            dgv_SupplyOrderList.DataSource = query.ToList();
            dgv_SupplyOrderList.Columns["OrderNumber"].HeaderText = "Order Num";
            dgv_SupplyOrderList.Columns["OrderDate"].HeaderText = "Order Date";
            dgv_SupplyOrderList.Columns["SupplierName"].HeaderText = "Supplier";
            dgv_SupplyOrderList.Columns["ProductName"].HeaderText = "Product Name";
            dgv_SupplyOrderList.Columns["Quantity"].HeaderText = "Product Quantity";
            dgv_SupplyOrderList.Columns["ProductionDate"].HeaderText = "ProductionDate";
            dgv_SupplyOrderList.Columns["ExpiryDate"].HeaderText = "ExpiryDate";
        }

        private void LoadIssueOrderListGridView(Store selectedStore)
        {
            DateTime startDate = date_Start.Value.Date;
            DateTime endDate = date_End.Value.Date;

            var query = from issueOrdr in DB.IssueOrders
                        join orderItem in DB.IssueOrderItems on issueOrdr.Id equals orderItem.IssueOrderId
                        where issueOrdr.Store.Id == selectedStore.Id && issueOrdr.OrderDate >= startDate && issueOrdr.OrderDate <= endDate
                        select new
                        {
                            issueOrdr.OrderNumber,
                            issueOrdr.OrderDate,
                            SupplierName = issueOrdr.Supplier.Name,
                            ProductName = orderItem.Product.Name,
                            orderItem.Quantity
                        };

            dgv_IssueOrderList.DataSource = query.ToList();
            dgv_IssueOrderList.Columns["OrderNumber"].HeaderText = "Order Num";
            dgv_IssueOrderList.Columns["OrderDate"].HeaderText = "Order Date";
            dgv_IssueOrderList.Columns["SupplierName"].HeaderText = "Supplier";
            dgv_IssueOrderList.Columns["ProductName"].HeaderText = "Product Name";
            dgv_IssueOrderList.Columns["Quantity"].HeaderText = "Product Quantity";
        }

        private void date_Start_ValueChanged(object sender, EventArgs e)
        {
            Store store = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());
            LoadSupplyOrderListGridView(store);
            LoadIssueOrderListGridView(store);

        }

        private void date_End_ValueChanged(object sender, EventArgs e)
        {
            Store store = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());
            LoadSupplyOrderListGridView(store);
            LoadIssueOrderListGridView(store);
        }
    }
}
