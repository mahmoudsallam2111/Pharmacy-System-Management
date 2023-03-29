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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MidicineForm medcineform = new MidicineForm();
        Employee employee = new Employee();
        CompanyForm CompanyForm = new CompanyForm();
        BillForm BillForm = new BillForm();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            medcineform.Show();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyForm.Show();

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillForm.Show();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }

}
