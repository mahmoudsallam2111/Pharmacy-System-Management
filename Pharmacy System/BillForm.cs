using Pharmacy_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        PharmacySysContext _db = new PharmacySysContext();


        private void BillForm_Load(object sender, EventArgs e)
        {
            var mednames = _db.Medicines.ToList();
            this.medcombo_box.DataSource = mednames;
            this.medcombo_box.ValueMember = "Name";
            //this.medcombo_box.DisplayMember = "Name";

        }

        private int x;
        private int uprice;

        public void getqQuantity()
        {

            string compname = (string)this.medcombo_box.SelectedValue.ToString();
            var qty = _db.Medicines.Where(q => q.Name == compname).Select(a => a.Quantity).SingleOrDefault();
            var price = _db.Medicines.Where(q => q.Name == compname).Select(a => a.Sprice).SingleOrDefault();
            this.lable_ava.Text = "Available in stock is " + (string)qty.ToString();

            x = (int)qty;
            uprice = (int)price;
        }

        private void medcombo_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getqQuantity();

        }
        private int Gridtotal;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int n = 0;
            int Total = (int)Convert.ToUInt32(txt_quantity.Text) * uprice;

            if (this.txt_quantity.Text == "" || (int)Convert.ToInt32(txt_quantity.Text) > x)
            {
                MessageBox.Show("Please checkout Avaliable in Stock !!!!");
            }
            else
            {
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dgv_bill);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = medcombo_box.SelectedValue.ToString();

                newrow.Cells[2].Value = txt_quantity.Text;
                newrow.Cells[3].Value = uprice;
                newrow.Cells[4].Value = Total;

                dgv_bill.Rows.Add(newrow);

                Gridtotal = Gridtotal + Total;
                this.txt_totalAmu.Text = "RS" + " " + Gridtotal.ToString();

            }


        }
        Bitmap Bitmap;
        private void btn_print_Click(object sender, EventArgs e)
        {
            Panel panal = new Panel();
            this.Controls.Add(panal);
            Graphics graphics = panal.CreateGraphics();
            Size size = this.ClientSize;
            Bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(Bitmap);
            Point point = PointToScreen(panal.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();



        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bitmap, 0, 0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeForm myhome = new HomeForm();
            this.Hide();
            myhome.Show();
        }
    }
}
