using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sukol
{
    public partial class FormGirisYap : Form
    {
        Veritabani veritabani = new Veritabani();
        public FormGirisYap()
        {
            InitializeComponent();
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            textBox_kullaniciAdi.Focus();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            veritabani.baslat();
            veritabani.sorgu("select id,ogrenci,ogretmen,gorevli from kullanicilar where kullanici_adi='" + textBox_kullaniciAdi.Text + "' and sifre='" + maskedTextBox_sifre.Text + "'");
            veritabani.calistir();
            OleDbDataReader oku = veritabani.oku();
            bool giris = false;
            while (oku.Read())
            {
                if (!giris)
                {
                    FormAna formAna = (FormAna)Application.OpenForms["FormAna"];

                }
                giris = true;
            }
            veritabani.kapat();
            if (giris)
                Close();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
