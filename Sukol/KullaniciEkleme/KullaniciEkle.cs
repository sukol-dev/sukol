using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukol.KullaniciEkleme
{
    public partial class KullaniciEkle : Form
    {
        Gorevli gorevli = new Gorevli();
        Kullanici kullanici = new Kullanici();

        public KullaniciEkle()
        {
            InitializeComponent();
        }

        public KullaniciEkle(Gorevli g)
        {
            InitializeComponent();
            gorevli = g;
        }

        private void button_ekle_click(object sender, EventArgs e)
        {
            if (!TextBoxlariKontrolEt())
                return;

            if (checkBox_gorevli.Checked)
            {
                kullanici.gorevli = new Gorevli();
            }

            if (checkBox_ogrenci.Checked)
            {
                kullanici.ogrenci = new Ogrenci();
                kullanici.ogrenci.numara = Convert.ToInt32(ogrenciEkle.tb_no.Text);
            }

            if (checkBox_ogretmen.Checked)
            {
                kullanici.ogretmen = new Ogretmen();
                kullanici.ogretmen.sinif = ogretmenEkle.tb_sinif.Text;
            }

            kullanici.isim = textBox_ad.Text;
            kullanici.soyisim = textBox_soyad.Text;
            kullanici.kullaniciAdi = textBox_kullaniciAdi.Text;
            kullanici.sifre = maskedTextBox_sifre.Text;

            gorevli.KullaniciEkle(kullanici);

            MessageBox.Show("Kullanıcı eklendi");
        }

        private bool TextBoxlariKontrolEt()
        {
            if (!checkBox_gorevli.Checked &&
                !checkBox_ogretmen.Checked &&
                !checkBox_ogrenci.Checked)
            {
                MessageBox.Show("Rol seçmen gerek", "Hata");
                return false;
            }

            if(textBox_ad.Text.Trim().Length < 2 &&
                textBox_soyad.Text.Trim().Length < 2 &&
                textBox_kullaniciAdi.Text.Trim().Length < 2 &&
                maskedTextBox_sifre.Text.Trim().Length < 2)
            {
                MessageBox.Show("Alanları boş geçme", "Hata");
                return false;
            }

            if(checkBox_ogrenci.Checked && ogrenciEkle.tb_no.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ogrenci bilgilerini dogru girin", "Hata");
                return false;
            }

            if (checkBox_ogretmen.Checked && ogretmenEkle.tb_sinif.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ogretmen bilgilerini dogru girin", "Hata");
                return false;
            }

            return true;
        }

        OgrenciEkle ogrenciEkle;
        OgretmenEkle ogretmenEkle;

        private void checkBox_gorevli_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
            }
            else
            {
            }
        }

        private void checkBox_ogretmen_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                ogretmenEkle = new OgretmenEkle();
                panel_rol_giris.Controls.Add(ogretmenEkle);
            }
            else
            {
                panel_rol_giris.Controls.Remove(ogretmenEkle);
            }
        }

        private void checkBox_ogrenci_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ogrenciEkle = new OgrenciEkle();
                panel_rol_giris.Controls.Add(ogrenciEkle);
            }
            else
            {
                panel_rol_giris.Controls.Remove(ogrenciEkle);
            }
        }
    }
}
