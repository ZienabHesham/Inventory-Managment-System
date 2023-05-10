using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmProductExpReport : UserControl
    {
        Context DB = new Context();

        public frmProductExpReport()
        {
            InitializeComponent();
        }

        private void frmProductExpReport_Load(object sender, EventArgs e)
        {
            StoreComBoxLoad();

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
            LoadSupplyOrderListGridView(store);
        }

        private void LoadSupplyOrderListGridView(Store selectedStore)
        {
            var query = (from supOrdr in DB.SupplyOrders
                         join orderItem in DB.SupplyOrderItems on supOrdr.Id equals orderItem.SupplyOrderId
                         where supOrdr.Store.Id == selectedStore.Id
                         select new
                         {
                             supOrdr.OrderNumber,
                             supOrdr.OrderDate,
                             SupplierName = supOrdr.Supplier.Name,
                             ProductName = orderItem.Product.Name,
                             orderItem.Quantity,
                             supOrdr.ProductionDate,
                             supOrdr.ExpiryDate
                         }).ToList();

            var formattedQuery = query.Select(q => new
            {
                q.OrderNumber,
                q.OrderDate,
                q.SupplierName,
                q.ProductName,
                q.Quantity,
                q.ProductionDate,
                ExpirationDate = q.ExpiryDate.ToString("yyyy/MM/dd"),
                ExpirationDays = (q.ExpiryDate - DateTime.Today).Days
            });

            dgv_SupplyOrderList.DataSource = formattedQuery.ToList();

            dgv_SupplyOrderList.Columns["OrderNumber"].HeaderText = "Order Num";
            dgv_SupplyOrderList.Columns["OrderDate"].HeaderText = "Order Date";
            dgv_SupplyOrderList.Columns["SupplierName"].HeaderText = "Supplier";
            dgv_SupplyOrderList.Columns["ProductName"].HeaderText = "Product Name";
            dgv_SupplyOrderList.Columns["Quantity"].HeaderText = "Product Quantity";
            dgv_SupplyOrderList.Columns["ProductionDate"].HeaderText = "ProductionDate";
            dgv_SupplyOrderList.Columns["ExpirationDate"].HeaderText = "Expiry Date";
            dgv_SupplyOrderList.Columns["ExpirationDays"].HeaderText = "Expiry days";

            foreach (DataGridViewRow row in dgv_SupplyOrderList.Rows)
            {
                int expDays = int.Parse(row.Cells["ExpirationDays"].Value.ToString());
                if (expDays <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red; 
                }
            }
        }

    }

}
