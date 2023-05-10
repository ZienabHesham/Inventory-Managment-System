using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace project
{
    public partial class frmSupplyOrder : UserControl
    {
        Context DB = new Context();
        public void Clear()
        {

            tBox_OrderNum.Text = "";
            comBox_Store.SelectedIndex = -1;
            comBox_Supplier.SelectedIndex = -1;
            comBox_Product.SelectedIndex = -1;
            num_Quantity.Value = 1;
        }
       
        public frmSupplyOrder()
        {
            InitializeComponent();
        }

        private void frmSupplyOrder_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            foreach (Store store in DB.Stores)
            {
                comBox_Store.Items.Add(store.Name);
            }
            foreach (Supplier sup in DB.Suppliers)
            {
                comBox_Supplier.Items.Add(sup.Name);
            }
            this.date_Order.Format=this.date_Prod.Format=this.date_Exp.Format = DateTimePickerFormat.Custom;
            date_Order.CustomFormat = date_Prod.CustomFormat= date_Exp.CustomFormat = "yyyy/MM/dd";
        }

        public void LoadComboBox()
        {
            foreach (SupplyOrder supOrdr in DB.SupplyOrders)
            {
                comBox_SupplyOrder.Items.Add(supOrdr.Id);
            }
        }

        private void LoadDataGridView()
        {
            int supplyOrderId = int.Parse(comBox_SupplyOrder.Text);

            var query = from order in DB.SupplyOrderItems
                        where order.SupplyOrderId == supplyOrderId
                        select new {order.Product.Code, order.Product.Name, order.Quantity };

            dgv_SupplyOrderItems.DataSource = query.ToList();
            dgv_SupplyOrderItems.Columns["Code"].HeaderText = "Product Code";

            dgv_SupplyOrderItems.Columns["Name"].HeaderText = "Product Name";
            dgv_SupplyOrderItems.Columns["Quantity"].HeaderText = "Product Quantity";
        }


        private void comBox_SupplyOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_SupplyOrder.Text);
            SupplyOrder supOrdr = DB.SupplyOrders.Find(Id);

            if (supOrdr != null)
            {
                tBox_OrderNum.Text = supOrdr.OrderNumber;
                comBox_Store.Text = supOrdr.Store != null ? supOrdr.Store.Name : string.Empty;
                comBox_Supplier.Text = supOrdr.Supplier != null ? supOrdr.Supplier.Name : string.Empty;
                date_Order.Text = supOrdr.OrderDate.ToString("yyyy/MM/dd");
                date_Prod.Text = supOrdr.ProductionDate.ToString("yyyy/MM/dd");
                date_Exp.Text = supOrdr.ExpiryDate.ToString("yyyy/MM/dd");

                LoadDataGridView();

                var products = DB.Products.Where(p => p.Store.Id == supOrdr.Store.Id).ToList();
                comBox_Product.DataSource = products;
                comBox_Product.DisplayMember = "Name";

                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SupplyOrder supOrder = new SupplyOrder();
            SupplyOrderItem supOrderItm = new SupplyOrderItem();

            if (tBox_OrderNum.Text != "" && date_Order.Text != "" && comBox_Supplier.Text != "" &&
                date_Prod.Text != "" && date_Exp.Text != "" && comBox_Store.Text != "" && comBox_Product.Text != "")
            {
                string storeName = comBox_Store.Text;
                Store store = DB.Stores.SingleOrDefault(obj => obj.Name == storeName);
                if (store != null)
                {
                    supOrder.Store = store;
                }
                else
                {
                    MessageBox.Show("Invalid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

                string supplierName = comBox_Supplier.Text;
                Supplier sup = DB.Suppliers.SingleOrDefault(obj => obj.Name == supplierName);
                if (sup != null)
                {
                    supOrder.Supplier = sup;
                }
                else
                {
                    MessageBox.Show("Invalid Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                supOrder.OrderNumber = tBox_OrderNum.Text;
                supOrder.OrderDate = DateTime.ParseExact(date_Order.Text, "yyyy/MM/dd", null);
                supOrder.ProductionDate = DateTime.ParseExact(date_Prod.Text, "yyyy/MM/dd", null);
                supOrder.ExpiryDate = DateTime.ParseExact(date_Exp.Text, "yyyy/MM/dd", null);

                DB.SupplyOrders.Add(supOrder);
                DB.SaveChanges();
                comBox_SupplyOrder.Items.Add(supOrder.Id);

                string productName = comBox_Product.Text;
                Product prod = DB.Products.SingleOrDefault(obj => obj.Name == productName && obj.Store.Id == store.Id);
                if (prod != null)
                {
                    supOrderItm.Product = prod;
                }
                else
                {
                    MessageBox.Show("Invalid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                supOrderItm.Quantity = (int)num_Quantity.Value;
                supOrderItm.SupplyOrderId = supOrder.Id;

                DB.SupplyOrderItems.Add(supOrderItm);
                DB.SaveChanges();

                this.Clear();

                MessageBox.Show("New Supply Order added", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Supply Order Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStore = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());
            if (selectedStore != null)
            {
                var products = DB.Products.Where(p => p.Store.Id == selectedStore.Id).ToList();
                comBox_Product.DataSource = products;
                comBox_Product.DisplayMember = "Name";
                comBox_Product.ValueMember = "Id";
            }
        }


        private void btn_Edit_Click(object sender, EventArgs e)
            {
                if (comBox_SupplyOrder.SelectedItem != null)
                {
                    int selectedOrderId = (int)comBox_SupplyOrder.SelectedItem;
                    SupplyOrder supOrder = DB.SupplyOrders.SingleOrDefault(obj => obj.Id == selectedOrderId);
                    if (supOrder == null)
                    {
                        MessageBox.Show("Invalid Supply Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (tBox_OrderNum.Text != "")
                    {
                        supOrder.OrderNumber = tBox_OrderNum.Text;
                    }
                    if (date_Order.Text != "")
                    {
                        supOrder.OrderDate = DateTime.ParseExact(date_Order.Text, "yyyy/MM/dd", null);
                    }
                    if (date_Prod.Text != "")
                    {
                        supOrder.ProductionDate = DateTime.ParseExact(date_Prod.Text, "yyyy/MM/dd", null);
                    }
                    if (date_Exp.Text != "")
                    {
                        supOrder.ExpiryDate = DateTime.ParseExact(date_Exp.Text, "yyyy/MM/dd", null);
                    }

                    if (comBox_Product.Text != "" && num_Quantity.Value > 0)
                    {
                        string productName = comBox_Product.Text;
                        Product prod = DB.Products.SingleOrDefault(obj => obj.Name == productName );
                        if (prod != null)
                        {
                            SupplyOrderItem supOrderItm = DB.SupplyOrderItems.SingleOrDefault(obj => obj.SupplyOrderId == supOrder.Id && obj.Product.Id == prod.Id);
                            if (supOrderItm != null)
                            {
                                supOrderItm.Quantity = (int)num_Quantity.Value;
                            }
                            else
                            {
                                supOrderItm = new SupplyOrderItem();
                                supOrderItm.Product = prod;
                                supOrderItm.Quantity = (int)num_Quantity.Value;
                                supOrderItm.SupplyOrderId = supOrder.Id;
                                DB.SupplyOrderItems.Add(supOrderItm);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DB.SaveChanges();
                LoadDataGridView();

                MessageBox.Show("Supply Order updated", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a Supply Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            }
    }
}
