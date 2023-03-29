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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }
        PharmacySysContext _db = new PharmacySysContext();
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            ICollection<Company> comps = _db.Companies.ToList();

            this.dgv_comp.DataSource = comps;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Company newcomp = new Company();
            newcomp.Name = this.txt_name.Text;
            newcomp.Phone = this.txt_phonenum.Text;

            newcomp.Address = txt_address.Text;


            if (txt_name.Text == "" || txt_phonenum.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Error!! full all the required data");
            }
            else
            {
                _db.Companies.Add(newcomp);
                _db.SaveChanges();
                MessageBox.Show("Item added successfully");
                this.dgv_comp.DataSource = _db.Companies.ToList();
            }
        }
        private int id;


        private void dgv_comp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)this.dgv_comp.SelectedRows[0].Cells[0].Value;
            this.txt_name.Text = this.dgv_comp.SelectedRows[0].Cells[1].Value.ToString();
            this.txt_phonenum.Text = this.dgv_comp.SelectedRows[0].Cells[2].Value.ToString();
            this.txt_address.Text = this.dgv_comp.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.dgv_comp.EndEdit();

            var myitem = _db.Companies.Where(a => a.Id == id).SingleOrDefault();

            myitem.Name = this.txt_name.Text;
            myitem.Phone = this.txt_phonenum.Text;
            myitem.Address = this.txt_address.Text;



            if (txt_name.Text == "" || txt_phonenum.Text == "" || txt_address.Text == "")
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
            var res = _db.Companies.Where(a => a.Id == id).FirstOrDefault();
            if (res == null)
            {
                MessageBox.Show("Error while delaeting this item !!!!!");
            }
            try
            {
                _db.Companies.Remove(res);
                _db.SaveChanges();
                this.dgv_comp.DataSource = _db.Companies.ToList();
                MessageBox.Show("item deleted successfully");

            }
            catch (Exception)
            {

                MessageBox.Show("click on an item to select it");
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
