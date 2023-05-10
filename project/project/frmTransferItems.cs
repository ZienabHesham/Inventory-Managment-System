using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmTransferItems : UserControl
    {
        Context DB = new Context();

        public frmTransferItems()
        {
            InitializeComponent();
        }

        private void frmTransferItems_Load(object sender, EventArgs e)
        {
            ComBoxLoad();

        }

        public void ComBoxLoad()
        {
            var stores = DB.Stores.ToList();

            foreach (Store store in stores)
            {
                comBox_Store.Items.Add(store.Name);
            }
        }

        

        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = comBox_Store.Text;
         
            LoadProductListGridView();
        }

        private void LoadProductListGridView()

        {
            if (comBox_Store.SelectedItem == null)
            {
                return;
            }

            Store selectedStore = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());

            var query = from transOrdr in DB.TransferOrders
                        join transOrderItm in DB.TransferOrderItems on transOrdr.Id equals transOrderItm.TransferOrderId
                        where transOrdr.SourceStore.Id == selectedStore.Id 
                        select new
                        {
                            transOrdr.OrderNumber,
                            ProductName = transOrderItm.Product.Name,
                            transOrderItm.Quantity,
                            SourceStore = transOrdr.SourceStore.Name,
                            DestinationStore = transOrdr.DestinationStore.Name,
                            transOrdr.OrderDate,
                            SupplierName = transOrdr.Supplier.Name,
                            transOrdr.ProductionDate,
                            transOrdr.ExpiryDate,
                            
                        };

            dgv_ProductList.DataSource = query.ToList();
            dgv_ProductList.Columns["OrderNumber"].HeaderText = "Order Num";
            dgv_ProductList.Columns["ProductName"].HeaderText = "Product Name";
            dgv_ProductList.Columns["Quantity"].HeaderText = "Product Quantity";
            dgv_ProductList.Columns["SourceStore"].HeaderText = "Source Store";
            dgv_ProductList.Columns["DestinationStore"].HeaderText = "Destination Store";
            dgv_ProductList.Columns["OrderDate"].HeaderText = "Order Date";
            dgv_ProductList.Columns["SupplierName"].HeaderText = "Supplier";
            dgv_ProductList.Columns["ProductionDate"].HeaderText = "ProductionDate";
            dgv_ProductList.Columns["ExpiryDate"].HeaderText = "ExpiryDate";
        }

        private void dgv_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
