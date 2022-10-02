namespace CarSystemApp
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startporint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startporint += 1;
            myProgress.Value = startporint;
            Percentage.Text = "" + startporint;
            if(myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}