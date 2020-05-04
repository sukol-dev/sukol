using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sukol
{
    /* 
        veritabani.baslat();
        veritabani.sorgu(...);
        veritabani.calistir();
        OleDbDataReader oku = veritabani.oku();
        while (oku.Read())
        {
            ...
        }
        veritabani.kapat();
    */
    class Veritabani
    {
        OleDbConnection baglantim = new OleDbConnection("Provider= Microsoft.JET.OleDb.4.0;Data Source=" + Application.StartupPath + "\\sukol.mdb");
        private OleDbCommand komut;
        public void baslat()
        {
            try
            {
                baglantim.Open();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                baglantim.Close();
            }
        }
        public void sorgu(string sorguCumlesi)
        {
            try
            {
                komut = new OleDbCommand(@sorguCumlesi, baglantim);
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                baglantim.Close();
            }
        }

        public void parametreEkle(string key, string value)
        {
            komut.Parameters.AddWithValue("@" + key, value);
        }
        public void calistir()
        {
            komut.ExecuteNonQuery();
        }
        public OleDbDataReader oku()
        {
            return komut.ExecuteReader();
        }
        public void kapat()
        {
            baglantim.Close();
        }
    }
}
