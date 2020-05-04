using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sukol
{
    class Veritabani
    {
        OleDbConnection baglantim = new OleDbConnection("Provider= Microsoft.JET.OleDb.4.0;Data Source=" + Application.StartupPath + "\\sukol.mdb");
        private void sorgu(string sorguCumlesi)
        {
            try
            {
                baglantim.Open();
                OleDbCommand komut = new OleDbCommand(sorguCumlesi, baglantim);
                komut.ExecuteNonQuery();
                baglantim.Close();
                MessageBox.Show("Başarı ile eklendi");
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                baglantim.Close();
            }
        }
    }
}
