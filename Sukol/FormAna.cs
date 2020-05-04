using System;
using System.Windows.Forms;

namespace Sukol
{
    public partial class FormAna : Form
    {
        Gorevli _gorevli = new Gorevli();
        Ogrenci _ogrenci = new Ogrenci();
        Ogretmen _ogretmen = new Ogretmen();
        public FormAna()
        {
            InitializeComponent();
            panel_ana_sayfa.BringToFront();
        }

        private void girisyap_button_Click(object sender, EventArgs e)
        {
            FormGirisYap girisYap = new FormGirisYap();
            girisYap.Show();
        }

        private void websitemiz_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sukol.herokuapp.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sukol-dev/sukol");
        }
    }
}
