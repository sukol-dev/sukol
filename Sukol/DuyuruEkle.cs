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
    public partial class DuyuruEkle : Form
    {
        Kullanici k;
        string sinif;
        Veritabani db = new Veritabani();
        public DuyuruEkle(Kullanici k, string sinif_ad)
        {
            InitializeComponent();

            this.k = k;

            if (sinif_ad == null || sinif_ad.Length == 0)
                return;
            else
                sinif = sinif_ad;

            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Trim().Length < 5)
            {
                MessageBox.Show("Metin çok kısa");
            }

            db.sorgu("INSERT INTO duyurular(kullanici_id, sinif_ad, metin, tarih)"+
                "VALUES(@kullanici_id, @sinif_ad, @metin, @tarih)");
            db.parametreEkle("kullanici_id", k.id);
            db.parametreEkle("sinif_ad", sinif);
            db.parametreEkle("metin", richTextBox1.Text);
            db.parametreEkle("tarih", DateTime.Now.ToString());

            db.baslat();
            db.calistir();

            MessageBox.Show("Duyuru eklendi");

            db.kapat();
            Close();
        }
    }
}
