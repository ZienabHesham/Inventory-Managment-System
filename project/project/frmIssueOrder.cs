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
    public partial class frmIssueOrder : UserControl
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

        public frmIssueOrder()
        {
            InitializeComponent();
        }

        private void frmIssueOrder_Load(object sender, EventArgs e)
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
            this.date_Order.Format =  DateTimePickerFormat.Custom;
            date_Order.CustomFormat =  "yyyy/MM/dd";

        }
        public void LoadComboBox()
        {
            foreach (IssueOrder issueOrdr in DB.IssueOrders)
            {
                comBox_IssueOrder.Items.Add(issueOrdr.Id);
            }
        }

        private void LoadDataGridView()
        {
            int issueOrderId = int.Parse(comBox_IssueOrder.Text);

            var query = from order in DB.IssueOrderItems
                        where order.IssueOrderId == issueOrderId
                        select new { order.Product.Code, order.Product.Name, order.Quantity };

            dgv_IssueOrderItems.DataSource = query.ToList();
            dgv_IssueOrderItems.Columns["Code"].HeaderText = "Product Code";
            dgv_IssueOrderItems.Columns["Name"].HeaderText = "Product Name";
            dgv_IssueOrderItems.Columns["Quantity"].HeaderText = "Product Quantity";
        }

        private void comBox_IssueOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_IssueOrder.Text);
            IssueOrder issueOrdr = DB.IssueOrders.Find(Id);

            if (issueOrdr != null)
            {
                tBox_OrderNum.Text = issueOrdr.OrderNumber;
                comBox_Store.Text = issueOrdr.Store != null ? issueOrdr.Store.Name : string.Empty;
                comBox_Supplier.Text = issueOrdr.Supplier != null ? issueOrdr.Supplier.Name : string.Empty;
                date_Order.Text = issueOrdr.OrderDate.ToString("yyyy/MM/dd");
            
                LoadDataGridView();

                var products = DB.Products.Where(p => p.Store.Id == issueOrdr.Store.Id).ToList();
                comBox_Product.DataSource = products;
                comBox_Product.DisplayMember = "Name";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            IssueOrder issueOrder = new IssueOrder();
            IssueOrderItem issueOrderItm = new IssueOrderItem();

            if (tBox_OrderNum.Text != "" && date_Order.Text != "" && comBox_Supplier.Text != "" &&
                 comBox_Store.Text != "" && comBox_Product.Text != "")
            {
                string storeName = comBox_Store.Text;
                Store store = DB.Stores.SingleOrDefault(obj => obj.Name == storeName);
                if (store != null)
                {
                    issueOrder.Store = store;
                }
                else
                {
                    MessageBox.Show("Invalid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

                string supplierName = comBox_Supplier.Text;
                Supplier sup = DB.Suppliers.SingleOrDefault(obj => obj.Name == supplierName);
                if (sup != null)
                {
                    issueOrder.Supplier = sup;
                }
                else
                {
                    MessageBox.Show("Invalid Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                issueOrder.OrderNumber = tBox_OrderNum.Text;
                issueOrder.OrderDate = DateTime.ParseExact(date_Order.Text, "yyyy/MM/dd", null);
                
                DB.IssueOrders.Add(issueOrder);
                DB.SaveChanges();
                comBox_IssueOrder.Items.Add(issueOrder.Id);

                string productName = comBox_Product.Text;
                Product prod = DB.Products.SingleOrDefault(obj => obj.Name == productName && obj.Store.Id == store.Id);
                if (prod != null)
                {
                    issueOrderItm.Product = prod;
                }
                else
                {
                    MessageBox.Show("Invalid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                issueOrderItm.Quantity = (int)num_Quantity.Value;
                issueOrderItm.IssueOrderId = issueOrder.Id;

                DB.IssueOrderItems.Add(issueOrderItm);
                DB.SaveChanges();

                this.Clear();

                MessageBox.Show("New Issue Order added", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Issue Order Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBox_Store.SelectedItem != null && comBox_Store.SelectedItem is string)
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
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (comBox_IssueOrder.SelectedItem != null)
            {
                int selectedOrderId = (int)comBox_IssueOrder.SelectedItem;
                IssueOrder issueOrder = DB.IssueOrders.SingleOrDefault(obj => obj.Id == selectedOrderId);
                if (issueOrder == null)
                {
                    MessageBox.Show("Invalid Issue Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tBox_OrderNum.Text != "")
                {
                    issueOrder.OrderNumber = tBox_OrderNum.Text;
                }
                if (date_Order.Text != "")
                {
                    issueOrder.OrderDate = DateTime.ParseExact(date_Order.Text, "yyyy/MM/dd", null);
                }
               
                if (comBox_Product.Text != "" && num_Quantity.Value > 0)
                {
                    string productName = comBox_Product.Text;
                    Product prod = DB.Products.SingleOrDefault(obj => obj.Name == productName);
                    if (prod != null)
                    {
                        IssueOrderItem issueOrderItm = DB.IssueOrderItems.SingleOrDefault(obj => obj.IssueOrderId == issueOrder.Id && obj.Product.Id == prod.Id);
                        if (issueOrderItm != null)
                        {
                            issueOrderItm.Quantity = (int)num_Quantity.Value;
                        }
                        else
                        {
                            issueOrderItm = new IssueOrderItem();
                            issueOrderItm.Product = prod;
                            issueOrderItm.Quantity = (int)num_Quantity.Value;
                            issueOrderItm.IssueOrderId = issueOrder.Id;
                            DB.IssueOrderItems.Add(issueOrderItm);
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

                MessageBox.Show("Issue Order updated", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an Issue Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
