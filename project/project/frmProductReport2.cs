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
    public partial class frmProductReport2 : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            comBox_Product.Text = comBox_Store.Text = tBox_Code.Text = tBox_MU.Text = tBox_Qty.Text = string.Empty;

        }
        public frmProductReport2()
        {
            InitializeComponent();
        }

        private void frmProductReport2_Load(object sender, EventArgs e)
        {
            ComBoxLoad();
            LoadProductListGridView();
        }

        public void ComBoxLoad()
        {
            var products = DB.Products.ToList();

            foreach (Product prod in products)
            {
                comBox_Product.Items.Add(prod.Name);
            }
        }

        private void comBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBox_Store.Items.Clear(); 

            string name = comBox_Product.Text;
            Product prod = DB.Products.FirstOrDefault(s => s.Name == comBox_Product.SelectedItem.ToString());

            if (prod != null)
            {
                tBox_Code.Text = prod.Code;
                tBox_MU.Text = prod.MeasuringUnit;
                tBox_Qty.Text = prod.Quantity.ToString();

                comBox_Store.Items.Add(prod.Store.Name);
            }
            LoadProductListGridView();
        }

        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBox_Product.Items.Clear(); 

            string name = comBox_Store.Text;
            var products = DB.Products.Where(p => p.Store.Name == name).Select(p => p.Name).Distinct().ToList();

            comBox_Product.Items.AddRange(products.ToArray());
            LoadProductListGridView();
        }

        private void LoadProductListGridView()

        {
            if (comBox_Store.SelectedItem == null)
            {
                return;
            }

            Store selectedStore = DB.Stores.FirstOrDefault(s => s.Name == comBox_Store.SelectedItem.ToString());

            var query = from prod in DB.Products
                        where prod.Store.Id == selectedStore.Id
                        select new { prod.Code, prod.Name, prod.Quantity };

            dgv_ProductList.DataSource = query.ToList();
            dgv_ProductList.Columns["Code"].HeaderText = "Product Code";
            dgv_ProductList.Columns["Name"].HeaderText = "Product Name";
            dgv_ProductList.Columns["Quantity"].HeaderText = "Product Quantity";
        }
    }
}
