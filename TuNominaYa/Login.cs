namespace TuNominaYa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard form = new DashBoard();

            form.FormClosed += (s, a) => Close();
            form.Show();
            this.Hide();
        }
    }
}
