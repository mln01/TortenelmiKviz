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
            Form formKakukktojas = new tortenelmiKvizKakukktojas(this);
            formKakukktojas.Show();
            this.Enabled = false;
        }

        private void buttonAranykopesek_Click(object sender, EventArgs e)
        {
            Form Aranykopesek = new Aranykopesek(this);
            Aranykopesek.Show();
            this.Enabled = false;
        }
    }
}
