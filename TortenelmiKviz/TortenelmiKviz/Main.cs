namespace TortenelmiKviz
{
    public partial class tortenelmiKvízMain : Form
    {
        public tortenelmiKvízMain()
        {
            InitializeComponent();
        }

        private void ButtonKakukktojas_Click(object sender, EventArgs e)
        {
            Form formKakukktojas = new tortenelmiKvizKakukktojas();
            formKakukktojas.Show();
        }
    }
}
