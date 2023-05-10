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
    public partial class frmStore : UserControl
    {
        Context DB = new Context();
        public void clear()
        {
            comBox_Store.Text =comBox_Mgr.Text= string.Empty;
            tBox_Name.Text  = tBox_Address.Text = string.Empty;
            
        }
        public frmStore()
        {
            InitializeComponent();
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            foreach (Store store in DB.Stores)
            {
                comBox_Store.Items.Add(store.Id);
            }

            foreach (Employee emp in DB.Employees)
            {
                comBox_Mgr.Items.Add(emp.Name);
            }
        }

        public void StoreComBoxLoad()
        {
            foreach (Store store in DB.Stores)
            {
                comBox_Store.Items.Add(store.Id);
            }

        }

        private void comBox_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(comBox_Store.Text);
            Store store = DB.Stores.Find(Id);

            if (store != null)
            {
                tBox_Name.Text = store.Name;
                tBox_Address.Text = store.Address;
                comBox_Mgr.Text = store.PersonInCharge.Name;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            if (tBox_Name.Text != "" && tBox_Address.Text != "" && comBox_Mgr.Text != "")
            {
                string empName = comBox_Mgr.Text;
                Employee emp = DB.Employees.SingleOrDefault(obj => obj.Name == empName);
                if (emp!= null) 
                {
                    store.PersonInCharge= emp;
                }
                else
                {
                    MessageBox.Show("Invalid Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                store.Name = tBox_Name.Text;
                store.Address = tBox_Address.Text;
                DB.Stores.Add(store);
                DB.SaveChanges();
                comBox_Store.Items.Add(store.Id);
                this.clear();
                MessageBox.Show("New Store added", "Sucsseful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Store Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comBox_Mgr_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Store store = DB.Stores.Find(int.Parse(comBox_Store.Text));
            if (store != null)
            {
                if (tBox_Name.Text != "" && tBox_Address.Text != "" && comBox_Mgr.Text != "" )
                {
                    store.Name = tBox_Name.Text;
                    store.Address = tBox_Address.Text;
                    string empName = comBox_Mgr.Text;
                    Employee emp = DB.Employees.SingleOrDefault(obj => obj.Name == empName);
                    if (emp != null)
                    {
                        store.PersonInCharge = emp;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    DB.SaveChanges();
                    MessageBox.Show("Store Updated", "Sucsseful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid Store Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Not valid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Store store = DB.Stores.Find(int.Parse(comBox_Store.Text));
            if (store != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Store?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB.Stores.Remove(store);
                    DB.SaveChanges();
                    comBox_Store.Items.Remove(store.Id);
                    MessageBox.Show("Store Deleted", "Sucsseful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

            }
            else
            {
                MessageBox.Show("Not valid Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
