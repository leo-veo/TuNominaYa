using TuNominaYa.Forms.Configuration;
using TuNominaYa.Methods_Funcs;

namespace TuNominaYa
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcs.Adopt(this, new Company());
        }
    }
}
