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
        string sinif = "";
        Veritabani db = new Veritabani();
        public DuyuruPaneli(Kullanici k)
        {
            InitializeComponent();

            this.k = k;

            if (k.gorevli == null)
                sinif = null;

            ShowDialog();
        }

        void LoadComboBox()
        {
            db.sorgu("SELECT isim FROM siniflar");
            db.baslat();
            db.calistir();
            OleDbDataReader reader = db.oku();

            if (!reader.HasRows)
                MessageBox.Show("NULL2!");

            while (reader.Read())
            {
                comboBox_siniflar.Items.Add(reader["isim"].ToString());
            }

            db.kapat();
        }

        void LoadDuyurular()
        {
            if(sinif == null)
            {
                db.sorgu("SELECT (SELECT isim + \" \" + soyisim FROM kullanicilar WHERE kullanici_id=@kullanici_id) AS yazar_ad,"+
                    " metin, tarih FROM duyurular" +
                    " WHERE sinif_ad IN (SELECT sinif FROM ogrenciler WHERE kullanici_id=@kullanici_id)" +
                    " OR sinif_ad IN (SELECT sinif FROM ogretmenler WHERE kullanici_id=@kullanici_id)");
                db.parametreEkle("kullanici_id", k.id);
            }
            else
            {
                db.sorgu("SELECT kullanici_id, metin, tarih FROM duyurular WHERE sinif_ad=@sinif_adi");
                db.parametreEkle("sinif_adi", comboBox_siniflar.Text);
            }

            db.baslat();
            OleDbDataReader reader = db.oku();

            while (reader.Read())
            {
                flowLayout_duyurular.Controls.Add(new DuyuruItem(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            }

            db.kapat();
        }

        private void DuyuruPaneli_Load(object sender, EventArgs e)
        {
            if(k.gorevli == null)
            {

            }
            else
            {
                LoadComboBox();
            }
        }

        private void comboBox_siniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayout_duyurular.Controls.Clear();
            LoadDuyurular();
        }

        private void button_duyuruEkle_Click(object sender, EventArgs e)
        {
            new DuyuruEkle(k, comboBox_siniflar.Text);
            flowLayout_duyurular.Controls.Clear();
            LoadDuyurular();
        }
    }
}
