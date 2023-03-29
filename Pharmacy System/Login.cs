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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        PharmacySysContext _db = new PharmacySysContext();

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            HomeForm myform = new HomeForm();
            var res = _db.Emloyees.ToList();
            foreach (var item in res)
            {
                if (this.Username.Text.ToLower() == item.Name)
                {
                    if (this.password.Text.ToLower() == item.password && item.Role == "A")
                    {
                        this.Hide();
                        myform.Show();

                    }
                    else
                    {
                        MessageBox.Show("USERNAME OR PASSWORD IS INCORRCT!!", "warning");

                    }
                }

            }


        }




    }
}
