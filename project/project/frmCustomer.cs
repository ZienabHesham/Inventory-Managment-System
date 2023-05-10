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
    public partial class frmCustomer : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            comBox_Customer.Text = string.Empty;
            tBox_Name.Text = tBox_Email.Text = tBox_Phone.Text=tBox_Fax.Text=tBox_Mobile.Text=tBox_Website.Text = string.Empty;
        }
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            foreach (Customer customer in DB.Customers)
            {
                comBox_Customer.Items.Add(customer.Id);
            }
        }        

        private void comBox_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_Customer.Text);
            Customer customer = DB.Customers.Find(Id);

            if (customer != null)
            {
                tBox_Name.Text = customer.Name;
                tBox_Email.Text = customer.Email;
                tBox_Phone.Text = customer.Phone;
                tBox_Fax.Text = customer.Fax;
                tBox_Mobile.Text = customer.Mobile;
                tBox_Website.Text = customer.Website;
            }
        }
        public void LoadComboBox()
        {
            foreach (Customer customer in DB.Customers)
            {
                comBox_Customer.Items.Add(customer);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && tBox_Website.Text!="" && tBox_Fax.Text!="" && tBox_Mobile.Text!="")
            {
                customer.Name = tBox_Name.Text;
                customer.Email = tBox_Email.Text;
                customer.Phone = tBox_Phone.Text;
                customer.Fax = tBox_Fax.Text;
                customer.Mobile = tBox_Mobile.Text;
                customer.Website = tBox_Website.Text;
                DB.Customers.Add(customer);
                DB.SaveChanges();
                comBox_Customer.Items.Add(customer.Id);
                this.clear();
                MessageBox.Show("New Customer added", "Sucsseful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Customer Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Customer customer = DB.Customers.Find(int.Parse(comBox_Customer.Text));
            if (customer != null)
            {
                if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && tBox_Website.Text != "" && tBox_Fax.Text != "" && tBox_Mobile.Text != "")
                {
                    customer.Name = tBox_Name.Text;
                    customer.Email = tBox_Email.Text;
                    customer.Phone = tBox_Phone.Text;
                    customer.Fax = tBox_Fax.Text;
                    customer.Mobile = tBox_Mobile.Text;
                    customer.Website = tBox_Website.Text;

                    DB.SaveChanges();
                    MessageBox.Show("Customer Updated", "Sucsseful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid Customer Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Not valid Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Customer customer = DB.Customers.Find(int.Parse(comBox_Customer.Text));
            if (customer != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Customer?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB.Customers.Remove(customer);
                    DB.SaveChanges();
                    comBox_Customer.Items.Remove(customer.Id);
                    MessageBox.Show("Customer Deleted", "Sucsseful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

            }
            else
            {
                MessageBox.Show("Not valid Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
