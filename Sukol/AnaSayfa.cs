using System;
using System.Windows.Forms;

namespace Sukol
{
    public partial class AnaSayfa : Form
    {
        Gorevli gorevli = new Gorevli();
        Veritabani veritabani = new Veritabani();
        public AnaSayfa()
        {
            InitializeComponent();
            panel_ana_sayfa.BringToFront();
        }

        private void girisyap_button_Click(object sender, EventArgs e)
        {
            panel_giris_yap.BringToFront();
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
