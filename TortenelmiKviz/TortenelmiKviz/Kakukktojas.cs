namespace TortenelmiKviz
{
    public partial class tortenelmiKvizKakukktojas : Form
    {
        public tortenelmiKvizKakukktojas()
        {
            InitializeComponent();
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            Form formMain = new tortenelmiKvízMain();
            formMain.Show();
            this.Close();
        }

        private void buttonABuvosHetesSzam_Click(object sender, EventArgs e)
        {
            Form ABHSZ = new ABuvosHetesSzam();
            ABHSZ.Show();
            this.Close();
        }
    }
}
