using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sukol
{
    public partial class DuyuruPaneli : Form
    {
        public Kullanici k;
        string sinif;
        Veritabani db = new Veritabani();
        public DuyuruPaneli(Kullanici k, bool gorevli)
        {
            InitializeComponent();

            this.k = k;
            if (!gorevli)
            {
                db.sorgu("SELECT sinif FROM ogrenciler WHERE kullanici_id=@kid");
                db.parametreEkle("kid", k.id);
                db.baslat();
                OleDbDataReader reader = db.oku();

                if (!reader.HasRows)
                {
                    db.sorgu("SELECT sinif FROM ogretmenler WHERE kullanici_id=@kid");
                    db.parametreEkle("kid", k.id);
                    reader = db.oku();
                }

                while (reader.Read())
                {
                    sinif = reader["sinif"].ToString();
                    comboBox_siniflar.Text = sinif;
                    LoadDuyurular(true);
                }
                db.kapat();
            }

            ShowDialog();
        }

        void LoadComboBox()
        {
            db.sorgu("SELECT isim FROM siniflar");
            db.baslat();
            db.calistir();
            OleDbDataReader reader = db.oku();

            if (!reader.HasRows)
                MessageBox.Show("Sınıf yok");

            while (reader.Read())
            {
                comboBox_siniflar.Items.Add(reader["isim"].ToString());
            }

            db.kapat();
        }

        void LoadDuyurular(bool a)
        {
            db.sorgu("SELECT (SELECT isim + ' ' + soyisim FROM kullanicilar WHERE duyurular.kullanici_id=kullanicilar.id), metin, tarih FROM duyurular WHERE sinif_ad=@sinif_adi");

            if (sinif == null)
            {
                db.parametreEkle("sinif_adi", comboBox_siniflar.Text);
            }
            else
            {
                db.parametreEkle("sinif_adi", sinif);
                comboBox_siniflar.Enabled = false;
                button_duyuruEkle.Enabled = false;
            }

            if (!a) db.baslat();

            OleDbDataReader reader = db.oku();

            while (reader.Read())
            {
                flowLayout_duyurular.Controls.Add(new DuyuruItem(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            }

            if (!a) db.kapat();
        }

        private void DuyuruPaneli_Load(object sender, EventArgs e)
        {
            if (k.gorevli == null)
            {
                LoadComboBox();
            }
        }

        private void comboBox_siniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayout_duyurular.Controls.Clear();
            LoadDuyurular(false);
        }

        private void button_duyuruEkle_Click(object sender, EventArgs e)
        {
            new DuyuruEkle(k, comboBox_siniflar.Text);
            flowLayout_duyurular.Controls.Clear();
            LoadDuyurular(false);
        }
    }
}
