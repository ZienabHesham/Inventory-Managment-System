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
    public partial class frmEmployee : UserControl
    {
        Context DB= new Context();
        public void clear()
        {
            comBox_Emp.Text=string.Empty;
            tBox_Name.Text = tBox_Email.Text = tBox_Phone.Text = string.Empty;
            num_Salary.Value = 0m;
        }

        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            foreach (Employee empId in DB.Employees)
            {
                comBox_Emp.Items.Add(empId.Id);
            }

        }

        private void comBox_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Id = int.Parse(comBox_Emp.Text);
            Employee emp = DB.Employees.Find(Id);

            if (emp != null)
            {
                tBox_Name.Text=emp.Name;
                tBox_Email.Text = emp.Email;
                tBox_Phone.Text = emp.Phone;
                num_Salary.Value = Convert.ToDecimal(emp.Salary);

            }

        }
        public void LoadComboBox()
        {
            foreach (Employee empId in DB.Employees)
            {
                comBox_Emp.Items.Add(empId);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && num_Salary.Value != 0)
            {
                emp.Name = tBox_Name.Text;
                emp.Email = tBox_Email.Text;
                emp.Phone = tBox_Phone.Text;
                emp.Salary = Convert.ToDouble(num_Salary.Value);
                DB.Employees.Add(emp);
                DB.SaveChanges();
                comBox_Emp.Items.Add(emp.Id);
                MessageBox.Show("New employee added", "Sucsseful Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid employee Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Employee emp = DB.Employees.Find(int.Parse(comBox_Emp.Text));
            if (emp != null)
            {
                if (tBox_Name.Text != "" && tBox_Email.Text != "" && tBox_Phone.Text != "" && num_Salary.Value != 0)
                {
                    emp.Name= tBox_Name.Text;
                    emp.Email= tBox_Email.Text; 
                    emp.Phone= tBox_Phone.Text; 
                    emp.Salary = Convert.ToDouble(num_Salary.Value);
                    DB.SaveChanges();
                    MessageBox.Show("Employee Updated", "Sucsseful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid employee Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Not valid employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Employee emp = DB.Employees.Find(int.Parse(comBox_Emp.Text));
            if (emp!=null) 
            {
                DialogResult result = MessageBox.Show("Do you want to delete the employee?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DB.Employees.Remove(emp);
                    DB.SaveChanges();
                    comBox_Emp.Items.Remove(emp.Id);
                    MessageBox.Show("Employee Deleted", "Sucsseful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                    this.clear();
                }
                
            }
            else
            {
                MessageBox.Show("Not valid employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
