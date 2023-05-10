using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace project
{
    public partial class frmProduct : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            tBox_Code.Text=tBox_Name.Text = string.Empty;
            tBox_MU.Text = tBox_Qty.Text = comBox_Store.Text = string.Empty;
        }
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            
        }

        public void LoadComboBox()
        {
            foreach (Product prod in DB.Products)
            {
                comBox_Product.Items.Add(prod.Name);
            }
            foreach (Store store in DB.Stores)
            {
                comBox_Store.Items.Add(store.Name);
            }
        }    

        private void comBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBox_Store.Items.Clear();
            string name = comBox_Product.Text;
            Product prod = DB.Products
                .FirstOrDefault(p => p.Name == name);

            if (prod != null)
            {

                tBox_Name.Text = prod.Name;
                tBox_Code.Text = prod.Code;
                tBox_MU.Text = prod.MeasuringUnit;
                tBox_Qty.Text = prod.Quantity.ToString();
                comBox_Store.Text = prod.Store.Name;

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = comBox_Store.Text;
            Store store = DB.Stores
                .FirstOrDefault(p => p.Name == name);

            Product prod = new Product();
            if (tBox_Name.Text != "" && tBox_Code.Text != "" && tBox_MU.Text != "" &&tBox_Qty.Text != "" && comBox_Store.Text != "")
            {
                prod.Name = tBox_Name.Text;
                prod.Code = tBox_Code.Text;
                prod.MeasuringUnit= tBox_MU.Text;
                prod.Quantity = int.Parse(tBox_Qty.Text);
                prod.Store = store;

                DB.Products.Add(prod);
                DB.SaveChanges();
                comBox_Product.Items.Add(prod.Id);
                this.clear();
                MessageBox.Show("New Product added", "Sucsseful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Product Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = comBox_Product.Text;
            Product prod = DB.Products
                .FirstOrDefault(p => p.Name == name);

            if (prod != null)
            {
                if (tBox_Name.Text != "" &&  tBox_Code.Text != "" && tBox_MU.Text != "" && tBox_Qty.Text != "" && comBox_Store.Text != "")
                {
                    prod.Name = tBox_Name.Text;
                    prod.Name = tBox_Name.Text;
                    prod.Code = tBox_Code.Text;
                    prod.MeasuringUnit = tBox_MU.Text;
                    prod.Quantity = int.Parse(tBox_Qty.Text);
                    Store store = DB.Stores.SingleOrDefault(obj => obj.Name == comBox_Store.Text);
                    if (store != null)
                    {
                        prod.Store = store;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    DB.SaveChanges();
                    MessageBox.Show("Product Updated", "Sucsseful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid Product Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Not valid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string name = comBox_Product.Text;
            Product prod = DB.Products
                .FirstOrDefault(p => p.Name == name);

            if (prod != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB.Products.Remove(prod);
                    DB.SaveChanges();
                    comBox_Product.Items.Remove(prod.Name);
                    MessageBox.Show("Product Deleted", "Sucsseful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

            }
            else
            {
                MessageBox.Show("Not valid Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
