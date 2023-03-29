namespace Pharmacy_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.startpoint += 1;
            this.bunifuCircleProgress1.Value = startpoint;
            if (bunifuCircleProgress1.Value == 100)
            {
                this.bunifuCircleProgress1.Value = 0;

                timer1.Stop();

                Login firstlogin = new Login();
                this.Hide(); /// to hide this window after timer stops
                firstlogin.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}