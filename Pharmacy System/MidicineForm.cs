using Bunifu.UI.WinForms.Helpers.Transitions;
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

namespace Pharmacy_System
{
    public partial class MidicineForm : Form
    {
        PharmacySysContext _db = new PharmacySysContext();
        public MidicineForm()
        {
            InitializeComponent();
        }



        private void MidicineForm_Load(object sender, EventArgs e)
        {
            var res = _db.Medicines.ToList();
            this.DGV.DataSource = res;
            // to populate combpbox with companynames
            var compnames = _db.Companies.ToList();
            this.comboBox1.DataSource = compnames;
            this.comboBox1.ValueMember = "Name";

            DGV.Columns[0].Visible = false;

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            Medicine NewMdeidine = new Medicine();
            NewMdeidine.Name = this.txt_name.Text;
            NewMdeidine.Bprice = (int)this.numbprice.Value;
            NewMdeidine.Sprice = (int)this.numsprice.Value;
            NewMdeidine.Quantity = (int)this.numQuanitty.Value;
            NewMdeidine.Expdate = (DateTime)this.txt_daat.Value;
            NewMdeidine.Company = (string)this.comboBox1.SelectedValue;

            if (txt_name.Text == "" || numbprice.Value == 0 || numsprice.Value == 0 || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error!! full all the required data");
            }
            else
            {
                _db.Medicines.Add(NewMdeidine);
                _db.SaveChanges();
                MessageBox.Show("Item added successfully");
                this.DGV.DataSource = _db.Medicines.ToList();
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.DGV.EndEdit();

            var myitem = _db.Medicines.Where(a => a.Id == id).SingleOrDefault();

            myitem.Name = this.txt_name.Text;
            myitem.Bprice = (int)this.numbprice.Value;
            myitem.Sprice = (int)this.numsprice.Value;
            myitem.Quantity = (int)this.numQuanitty.Value;
            myitem.Expdate = (DateTime)this.txt_daat.Value;
            myitem.Company = (string)this.comboBox1.SelectedValue;


            if (txt_name.Text == "" || numbprice.Value == 0 || numsprice.Value == 0 || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error!! full all the required data");
            }
            else
            {
                _db.SaveChanges();
                MessageBox.Show("Item Updated successfully");
            }

        }

        private int id;

        private void DGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)this.DGV.SelectedRows[0].Cells[0].Value;
            this.txt_name.Text = this.DGV.SelectedRows[0].Cells[1].Value.ToString();
            this.numbprice.Value = (int)this.DGV.SelectedRows[0].Cells[2].Value;
            this.numsprice.Value = (int)this.DGV.SelectedRows[0].Cells[3].Value;
            this.numQuanitty.Value = (int)this.DGV.SelectedRows[0].Cells[4].Value;
            this.txt_daat.Value = (DateTime)this.DGV.SelectedRows[0].Cells[5].Value;
            this.comboBox1.SelectedItem = this.DGV.SelectedRows[0].Cells[6].Value;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var res = _db.Medicines.Where(a => a.Id == id).FirstOrDefault();
            if (res == null)
            {
                MessageBox.Show("Error while delaeting this item !!!!!");
            }
            try
            {
                _db.Medicines.Remove(res);
                _db.SaveChanges();
                this.DGV.DataSource = _db.Medicines.ToList();
                MessageBox.Show("item deleted successfully");

            }
            catch (Exception)
            {

                MessageBox.Show("Double click on an item to delete");
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
