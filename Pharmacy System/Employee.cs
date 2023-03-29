using Pharmacy_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        PharmacySysContext _db = new PharmacySysContext();

        private void numbprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            var employees = _db.Emloyees.ToList();
            this.dgv_emp.DataSource = employees;
            dgv_emp.Columns[0].Visible = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Emloyee newemp = new Emloyee();

            newemp.Name = this.emp_name.Text;
            newemp.salary = (int)numsalary.Value;
            newemp.Age = (int)numage.Value;
            newemp.Sex = (string)comboBoxgender.SelectedItem;
            newemp.Phone = this.txt_phone.Text;
            newemp.password = this.txt_password.Text;
            newemp.Role = (string)comboRole.SelectedItem;


            if (emp_name.Text == "" || numsalary.Value == 0 || numage.Value == 0 || comboBoxgender.SelectedItem == null || comboRole.SelectedItem == null || txt_phone.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Error!! full all the required data");
            }
            else
            {
                _db.Emloyees.Add(newemp);
                _db.SaveChanges();
                MessageBox.Show("Item added successfully");
                this.dgv_emp.DataSource = _db.Emloyees.ToList();
            }
        }

        private int id;

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)this.dgv_emp.SelectedRows[0].Cells[0].Value;
            this.emp_name.Text = this.dgv_emp.SelectedRows[0].Cells[1].Value.ToString();
            this.numsalary.Value = (int)this.dgv_emp.SelectedRows[0].Cells[2].Value;
            this.numage.Value = (int)this.dgv_emp.SelectedRows[0].Cells[3].Value;
            this.comboBoxgender.SelectedItem = this.dgv_emp.SelectedRows[0].Cells[4].Value;
            this.txt_phone.Text = this.dgv_emp.SelectedRows[0].Cells[5].Value.ToString();
            this.txt_password.Text = this.dgv_emp.SelectedRows[0].Cells[6].Value.ToString();
            this.comboRole.SelectedItem = this.dgv_emp.SelectedRows[0].Cells[7].Value;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            this.dgv_emp.EndEdit();

            var myitem = _db.Emloyees.Where(a => a.Id == id).SingleOrDefault();

            myitem.Name = this.emp_name.Text;
            myitem.salary = (int)this.numsalary.Value;
            myitem.Age = (int)this.numage.Value;
            myitem.Sex = (string)this.comboBoxgender.SelectedItem;
            myitem.Phone = this.txt_phone.Text;
            myitem.password = (string)this.txt_password.Text;
            myitem.Role = (string)this.comboRole.SelectedItem;


            if (emp_name.Text == "" || numsalary.Value == 0 || numage.Value == 0 || comboBoxgender.SelectedItem == null || comboRole.SelectedItem == null || txt_password.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("Error!! full all the required data");
            }
            else
            {
                _db.SaveChanges();
                MessageBox.Show("Item Updated successfully");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var res = _db.Emloyees.Where(a => a.Id == id).FirstOrDefault();
            if (res == null)
            {
                MessageBox.Show("Error while delaeting this item !!!!!");
            }
            try
            {
                _db.Emloyees.Remove(res);
                _db.SaveChanges();
                this.dgv_emp.DataSource = _db.Emloyees.ToList();
                MessageBox.Show("item deleted successfully");

            }
            catch (Exception)
            {

                MessageBox.Show("click on an item to delete");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeForm myhome = new HomeForm();
            this.Hide();
            myhome.Show();
        }
    }
}

