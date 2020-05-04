using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sukol
{
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
        public void yaz(string sorguCumlesi)
        {
            try
            {
                komut = new OleDbCommand(sorguCumlesi, baglantim);
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                baglantim.Close();
            }
        }
        public void calistir()
        {
            komut.ExecuteNonQuery();
        }
        public void durdur()
        {
            baglantim.Close();
        }
    }
}
