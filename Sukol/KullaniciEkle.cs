using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukol
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        Veritabani db = new Veritabani();

        /* 
    veritabani.sorgu(...);
    veritabani.parametreEkle("key", value);
    veritabani.baslat();
    veritabani.calistir();
    OleDbDataReader oku = veritabani.oku();
    while (oku.Read())
    {
        ...
    }
    veritabani.kapat();
*/

        private void button1_Click(object sender, EventArgs e)
        {
            if( !checkBox_gorevli.Checked &&
                !checkBox_ogretmen.Checked &&
                !checkBox_ogrenci.Checked)
            {
                MessageBox.Show("Rol seçmen gerek", "Hata");
                return;
            }

            string values = "VALUES(@kullanici_adi, @sifre, @ogrenci, @ogretmen, @gorevli, @isim, @soyisim, @profilfoto)";
            db.sorgu("INSERT INTO kullanicilar(kullanici_adi, sifre, ogrenci, ogretmen, gorevli, isim, soyisim, profilfoto) " + values);
            db.parametreEkle("kullanici_adi", textBox_kullaniciAdi.Text);
            db.parametreEkle("sifre", textBox_sifre.Text);
            db.parametreEkle("gorevli", checkBox_gorevli.Checked);
            db.parametreEkle("ogretmen", checkBox_ogretmen.Checked);
            db.parametreEkle("ogrenci", checkBox_ogrenci.Checked);
            db.parametreEkle("isim", textBox_ad.Text);
            db.parametreEkle("soyisim", textBox_soyad.Text);
            db.parametreEkle("profilfoto", "");
            db.baslat();
            db.calistir();
            db.kapat();

            MessageBox.Show("Kullanıcı eklendi");
        }
    }
}
