using System;
using System.Windows.Forms;

namespace Sukol
{
    public partial class FormAna : Form
    {
        public int kullanici_id;
        Gorevli gorevli = new Gorevli();
        public void gorevliGiris()
        {
            görevliToolStripMenuItem.Enabled = true;
            gorevli.erisim = true;
        }
        Ogretmen ogretmen = new Ogretmen();
        public void ogretmenGiris()
        {
            öğretmenToolStripMenuItem.Enabled = true;
            ogretmen.erisim = true;
        }
        Ogrenci ogrenci = new Ogrenci();
        public void ogrenciGiris(int numara)
        {
            öğrenciToolStripMenuItem.Enabled = true;
            ogrenci.erisim = true;
            ogrenci.numara = numara;
        }
        Kullanici kullanici = new Kullanici();
        public void kullaniciGiris(string isim, string soyisim)
        {
            kullanici.isim = isim;
            kullanici.soyisim = soyisim;
            labelIsim.Visible = true;
            labelIsimYazan.Text = isim;
            labelIsimYazan.Visible = true;
            labelSoyIsim.Visible = true;
            labelSoyIsimYazan.Visible = true;
            labelSoyIsimYazan.Text = soyisim;
            button_girisyap.Visible = false;
            button_cikisYap.Visible = true;
        }
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

        private void button_cikisYap_Click(object sender, EventArgs e)
        {
            gorevli = new Gorevli();
            ogretmen = new Ogretmen();
            ogrenci = new Ogrenci();
            kullanici = new Kullanici();
            kullanici_id = 0;
            öğrenciToolStripMenuItem.Enabled = false;
            öğretmenToolStripMenuItem.Enabled = false;
            görevliToolStripMenuItem.Enabled = false;
            button_girisyap.Visible = true;
            button_cikisYap.Visible = false;
            labelIsim.Visible = false;
            labelIsimYazan.Visible = false;
            labelSoyIsim.Visible = false;
            labelSoyIsimYazan.Visible = false;
        }
    }
}
