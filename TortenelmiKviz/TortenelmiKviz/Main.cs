namespace TortenelmiKviz
{
    public partial class tortenelmiKv�zMain : Form
    {
        public tortenelmiKv�zMain()
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
