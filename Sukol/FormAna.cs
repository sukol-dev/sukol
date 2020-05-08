using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sukol
{
    public partial class FormAna : Form
    {
        public int kullanici_id;
        Veritabani veritabani = new Veritabani();
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
        public void kullaniciGiris(string isim, string soyisim, string profilfoto, bool ogrenci, bool ogretmen, bool gorevli)
        {
            kullanici.isim = isim;
            kullanici.soyisim = soyisim;

            labelIsim.Visible = true;
            labelIsimYazan.Text = isim;
            labelIsimYazan.Visible = true;
            labelSoyIsim.Visible = true;
            labelSoyIsimYazan.Text = soyisim;
            labelSoyIsimYazan.Visible = true;
            label_roller.Visible = true;
            string roller = "";
            if (ogrenci) roller += "öğrenci,";
            if (ogretmen) roller += "öğretmen,";
            if (gorevli) roller += "görevli,";
            roller = roller.Remove(roller.Length - 1);
            label_rollerYazan.Text = roller;
            label_rollerYazan.Visible = true;

            button_girisyap.Visible = false;
            button_cikisYap.Visible = true;

            kullanici.profilfoto = profilfoto;
            if (File.Exists(profilfoto)) pictureBox_profilFoto.Image = Image.FromFile(@profilfoto);

            button_profilFoto.Visible = true;
            pictureBox_profilFoto.Visible = true;
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
            label_roller.Visible = false;
            label_rollerYazan.Visible = false;

            button_profilFoto.Visible = false;
            pictureBox_profilFoto.Visible = false;
        }

        private void hakkimizda_button_Click(object sender, EventArgs e)
        {
            new AboutWindow("Unknown Productions", "Sukol", "1.0");
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ogrenci.BringToFront();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ana_sayfa.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog_profilFoto.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog_profilFoto.InitialDirectory + openFileDialog_profilFoto.FileName;
                veritabani.sorgu("UPDATE kullanicilar SET profilfoto=@profilfoto WHERE id=@kullanici_id");
                veritabani.parametreEkle("profilfoto",  path);
                veritabani.parametreEkle("kullanici_id", kullanici_id.ToString());
                veritabani.baslat();
                veritabani.calistir();
                veritabani.kapat();

                kullanici.profilfoto = path;
                pictureBox_profilFoto.Image = Image.FromFile(@path);
            }
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            int[] dizi = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                dizi[i] = rnd.Next(1, 49);
            }
            Array.Sort(dizi);
            label_sansliSayi.Text = "Şanslı Sayılar:" + dizi[0].ToString() + "," + dizi[1].ToString() + "," + dizi[2].ToString() + "," + dizi[3].ToString() + "," + dizi[4].ToString() + "," + dizi[5].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = 0;
            if (radioButton1.Checked)
                sonuc = sayi1 + sayi2;
            else if (radioButton2.Checked)
                sonuc = sayi1 - sayi2;
            else if (radioButton4.Checked)
                sonuc = sayi1 * sayi2;
            else if (radioButton3.Checked)
                if (sayi2 == 0)
                {
                    MessageBox.Show("Bölen 0 olamaz, başka bir rakam giriniz");
                    textBox2.Clear();
                }
                else
                    sonuc = sayi1 / sayi2;
            label_hesapmakSonuc.Text = "Sonuc:" + sonuc.ToString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_hesapMakinesi.BringToFront();
        }
    }
}
