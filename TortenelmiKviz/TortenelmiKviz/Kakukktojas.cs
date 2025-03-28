﻿namespace TortenelmiKviz
{
    public partial class tortenelmiKvizKakukktojas : Form
    {
        private Form formMain;

        public tortenelmiKvizKakukktojas(Form Main)
        {
            InitializeComponent();
            formMain = Main;
            this.FormClosing += tortenelmiKvizKakukktojas_FormClosing;
        }

        private void tortenelmiKvizKakukktojas_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain.Enabled = true; // Re-enable the previous form
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            formMain.Enabled = true;
            this.Close();
        }

        private void buttonABuvosHetesSzam_Click(object sender, EventArgs e)
        {
            Form ABHSZ = new ABuvosHetesSzam(this);
            ABHSZ.Show();
            this.Enabled = false;
        }

        private void buttonHazankTajain_Click(object sender, EventArgs e)
        {
            Form HT = new HazankTajain(this);
            HT.Show();
            this.Enabled = false;
        }

        private void buttonKiNemIllikBele_Click(object sender, EventArgs e)
        {
            Form KNIB = new KiNemIllikBele(this);
            KNIB.Show();
            this.Enabled = false;
        }
    }
}
