using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmTransferItem : UserControl
    {
        Context DB = new Context();
        public void Clear()
        {

            tBox_OrderNum.Text = "";
            comBox_SrcStore.SelectedIndex = -1;
            comBox_DesStore.SelectedIndex = -1;
            comBox_Supplier.SelectedIndex = -1;
            comBox_Product.SelectedIndex = -1;
            num_Quantity.Value = 1;
        }
        public frmTransferItem()
        {
            InitializeComponent();
        }

        private void frmTransferItem_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            foreach (Store store in DB.Stores)
            {
                comBox_SrcStore.Items.Add(store.Name);
                comBox_DesStore.Items.Add(store.Name);

            }
            foreach (Supplier sup in DB.Suppliers)
            {
                comBox_Supplier.Items.Add(sup.Name);
            }
            this.date_Order.Format = this.date_Prod.Format = this.date_Exp.Format = DateTimePickerFormat.Custom;
            date_Order.CustomFormat = date_Prod.CustomFormat = date_Exp.CustomFormat = "yyyy/MM/dd";
        }
        public void LoadComboBox()
        {
            foreach (TransferOrder transOrdr in DB.TransferOrders)
            {
                comBox_TransferOrder.Items.Add(transOrdr.Id);
            }
        }

        private void LoadDataGridView()
        {
            int transOrderId = int.Parse(comBox_TransferOrder.Text);

            var query = from order in DB.TransferOrderItems
                        where order.TransferOrderId == transOrderId
                        select new { order.Product.Code, order.Product.Name, order.Quantity };

            dgv_TransferOrderItems.DataSource = query.ToList();
            dgv_TransferOrderItems.Columns["Code"].HeaderText = "Product Code";

            dgv_TransferOrderItems.Columns["Name"].HeaderText = "Product Name";
            dgv_TransferOrderItems.Columns["Quantity"].HeaderText = "Product Quantity";
        }

        private void comBox_TransferOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_TransferOrder.Text);
            TransferOrder transOrdr = DB.TransferOrders.Find(Id);

            if (transOrdr != null)
            {
                tBox_OrderNum.Text = transOrdr.OrderNumber;
                comBox_SrcStore.Text = transOrdr.SourceStore != null ? transOrdr.SourceStore.Name : string.Empty;
                comBox_DesStore.Text = transOrdr.DestinationStore != null ? transOrdr.DestinationStore.Name : string.Empty;
                comBox_Supplier.Text = transOrdr.Supplier != null ? transOrdr.Supplier.Name : string.Empty;
                date_Order.Text = transOrdr.OrderDate.ToString("yyyy/MM/dd");
                date_Prod.Text = transOrdr.ProductionDate.ToString("yyyy/MM/dd");
                date_Exp.Text = transOrdr.ExpiryDate.ToString("yyyy/MM/dd");

                LoadDataGridView();

                var products = DB.Products.Where(p => p.Store.Id == transOrdr.SourceStore.Id).ToList();
                comBox_Product.DataSource = products;
                comBox_Product.DisplayMember = "Name";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            TransferOrder transOrder = new TransferOrder();
            TransferOrderItem transOrderItm = new TransferOrderItem();

            if (tBox_OrderNum.Text != "" && date_Order.Text != "" && comBox_Supplier.Text != "" &&
                date_Prod.Text != "" && date_Exp.Text != "" && comBox_SrcStore.Text != ""&& comBox_DesStore.Text != "" && comBox_Product.Text != "")
            {
                string srcStoreName = comBox_SrcStore.Text;
                string desStoreName = comBox_DesStore.Text;

                Store srcStore = DB.Stores.SingleOrDefault(obj => obj.Name == srcStoreName);
                if (srcStore != null)
                {
                    transOrder.SourceStore = srcStore;
                }
                else
                {
                    MessageBox.Show("Invalid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Store desStore = DB.Stores.SingleOrDefault(obj => obj.Name == desStoreName);
                if (desStore != null)
                {
                    transOrder.DestinationStore = desStore;
                }
                else
                {
                    MessageBox.Show("Invalid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                string supplierName = comBox_Supplier.Text;
                Supplier sup = DB.Suppliers.SingleOrDefault(obj => obj.Name == supplierName);
                if (sup != null)
                {
                    transOrder.Supplier = sup;
                }
                else
                {
                    MessageBox.Show("Invalid Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                transOrder.OrderNumber = tBox_OrderNum.Text;
                transOrder.OrderDate = DateTime.ParseExact(date_Order.Text, "yyyy/MM/dd", null);
                transOrder.ProductionDate = DateTime.ParseExact(date_Prod.Text, "yyyy/MM/dd", null);
                transOrder.ExpiryDate = DateTime.ParseExact(date_Exp.Text, "yyyy/MM/dd", null);

                DB.TransferOrders.Add(transOrder);
                DB.SaveChanges();
                comBox_TransferOrder.Items.Add(transOrder.Id);

                string productName = comBox_Product.Text;
                Product prod = DB.Products.SingleOrDefault(obj => obj.Name == productName && obj.Store.Id == srcStore.Id);
                if (prod != null)
                {
                    int quantity = (int)num_Quantity.Value;
                    if (prod.Quantity < quantity)
                    {
                        MessageBox.Show("Insufficient Quantity in Source Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        this.RemoveItemQuantity(srcStore, prod, quantity);
                        this.AddItemQuantity(desStore, prod, quantity);

                        transOrderItm.Product = prod;
                        transOrderItm.Quantity = (int)num_Quantity.Value;
                        transOrderItm.TransferOrderId = transOrder.Id;
                        DB.TransferOrderItems.Add(transOrderItm);
                        DB.SaveChanges();

                        this.Clear();

                        MessageBox.Show("New Transfer Order added", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Transfer Order Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveItemQuantity(Store srcStore,Product product, int quantityToRemove)
        {
            if (product != null && quantityToRemove > 0 &&srcStore.Id==product.Store.Id)
            {
                if (product.Quantity >= quantityToRemove)
                {
                    product.Quantity -= quantityToRemove;
                    DB.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Insufficient quantity to transfer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddItemQuantity(Store desStore, Product product, int quantityToAdd)
        {
            if (product != null && quantityToAdd > 0)
            {
                if(product.Store.Id == desStore.Id)
                {                  
                    product.Quantity += quantityToAdd;
                    DB.SaveChanges();
                }
                else
                {
                    Product newProduct = new Product();
                    newProduct.Store = desStore;
                    newProduct.Name=product.Name;
                    newProduct.Code = product.Code;
                    newProduct.MeasuringUnit = product.MeasuringUnit;
                    newProduct.Quantity = quantityToAdd;
                    DB.Products.Add(newProduct);    
                    DB.SaveChanges();

                }

            }
        }

        private void comBox_SrcStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStore = DB.Stores.Find(comBox_SrcStore.SelectedValue);
            if (selectedStore != null)
            {
                var products = DB.Products.Where(p => p.Store.Id == selectedStore.Id).ToList();
                comBox_Product.DataSource = products;
                comBox_Product.DisplayMember = "Name";
                comBox_Product.ValueMember = "Id";
            }
        }
    }
}
