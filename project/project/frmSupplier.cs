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
    public partial class frmSupplier : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            comBox_Supplier.Text = string.Empty;
            tBox_Name.Text = tBox_Email.Text = tBox_Phone.Text = tBox_Fax.Text = tBox_Mobile.Text = tBox_Website.Text = string.Empty;
        }
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            foreach (Supplier sup in DB.Suppliers)
            {
                comBox_Supplier.Items.Add(sup.Id);
            }
        }

        public void LoadComboBox()
        {
            foreach (Supplier sup in DB.Suppliers)
            {
                comBox_Supplier.Items.Add(sup);
            }
        }

        private void comBox_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_Supplier.Text);
            Supplier sup = DB.Suppliers.Find(Id);

            if (sup != null)
            {
                tBox_Name.Text = sup.Name;
                tBox_Email.Text = sup.Email;
                tBox_Phone.Text = sup.Phone;
                tBox_Fax.Text = sup.Fax;
                tBox_Mobile.Text = sup.Mobile;
                tBox_Website.Text = sup.Website;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && tBox_Website.Text != "" && tBox_Fax.Text != "" && tBox_Mobile.Text != "")
            {
                sup.Name = tBox_Name.Text;
                sup.Email = tBox_Email.Text;
                sup.Phone = tBox_Phone.Text;
                sup.Fax = tBox_Fax.Text;
                sup.Mobile = tBox_Mobile.Text;
                sup.Website = tBox_Website.Text;
                DB.Suppliers.Add(sup);
                DB.SaveChanges();
                comBox_Supplier.Items.Add(sup.Id);
                this.clear();
                MessageBox.Show("New Supplier added", "Sucsseful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Supplier Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Supplier sup = DB.Suppliers.Find(int.Parse(comBox_Supplier.Text));
            
            if (sup != null)
            {
                if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && tBox_Website.Text != "" && tBox_Fax.Text != "" && tBox_Mobile.Text != "")
                {
                    sup.Name = tBox_Name.Text;
                    sup.Email = tBox_Email.Text;
                    sup.Phone = tBox_Phone.Text;
                    sup.Fax = tBox_Fax.Text;
                    sup.Mobile = tBox_Mobile.Text;
                    sup.Website = tBox_Website.Text;

                    DB.SaveChanges();
                    MessageBox.Show("Supplier Updated", "Sucsseful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid Supplier Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Not valid Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Supplier sup = DB.Suppliers.Find(int.Parse(comBox_Supplier.Text));
            if (sup != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Supplier?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB.Suppliers.Remove(sup);
                    DB.SaveChanges();
                    comBox_Supplier.Items.Remove(sup.Id);
                    MessageBox.Show("Customer Supplier", "Sucsseful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

            }
            else
            {
                MessageBox.Show("Not valid Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
