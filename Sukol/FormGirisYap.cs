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
            veritabani.sorgu(
                "select " +
                " kullanicilar.id as kullanici_id," +

                " kullanicilar.isim as kullanici_isim," +
                " kullanicilar.soyisim as kullanici_soyisim," +
                " kullanicilar.profilfoto as profilfoto," +

                " kullanicilar.ogrenci as kullanici_ogrenci," +
                " kullanicilar.ogretmen as kullanici_ogretmen," +
                " kullanicilar.gorevli as kullanici_gorevli," +

                " ogrenciler.okul_no as ogrenci_okul_no" +

                " from ((kullanicilar" +

                " left join ogrenciler on kullanicilar.id=ogrenciler.kullanici_id)" +
                " left join ogretmenler on kullanicilar.id=ogretmenler.kullanici_id)" +
                " left join gorevliler on kullanicilar.id=gorevliler.kullanici_id" +

                " where kullanicilar.kullanici_adi=@kullanici_adi and kullanicilar.sifre=@sifre"
            );
            veritabani.parametreEkle("kullaniciadi", textBox_kullaniciAdi.Text);
            veritabani.parametreEkle("sifre", maskedTextBox_sifre.Text);
            veritabani.baslat();
            veritabani.calistir();
            OleDbDataReader oku = veritabani.oku();
            bool giris = false;
            if (!oku.HasRows)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata");
                maskedTextBox_sifre.Text = "";
            }

            while (oku.Read())
            {
                if (!giris)
                {
                    FormAna formAna = (FormAna)Application.OpenForms["FormAna"];
                    formAna.kullanici_id = Convert.ToInt32(oku["kullanici_id"]);
                    bool ogrenci = false;
                    bool ogretmen = false;
                    bool gorevli = false;
                    if (oku["kullanici_ogrenci"].ToString() == "True")
                    {
                        ogrenci = true;
                        formAna.ogrenciGiris(Convert.ToInt32(oku["ogrenci_okul_no"]));
                    }
                    if (oku["kullanici_gorevli"].ToString() == "True")
                    {
                        gorevli = true;
                        formAna.gorevliGiris();
                    }
                    if (oku["kullanici_ogretmen"].ToString() == "True")
                    {
                        ogretmen = true;
                        formAna.ogretmenGiris();
                    }
                    formAna.kullaniciGiris(oku["kullanici_isim"].ToString(), oku["kullanici_soyisim"].ToString(), oku["profilfoto"].ToString(), ogrenci, ogretmen, gorevli);
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
