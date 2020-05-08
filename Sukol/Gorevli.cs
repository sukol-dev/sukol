using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukol
{
    public class Gorevli
    {
        public bool erisim;
        public void gorev()
        {

        }

        Veritabani db = new Veritabani();
        public void KullaniciEkle(Kullanici k)
        {
            string sorgu = "INSERT INTO kullanicilar(kullanici_adi, sifre, ogrenci, ogretmen, gorevli, isim, soyisim, profilfoto) " +
                   "VALUES(@kullanici_adi, @sifre, @ogrenci, @ogretmen, @gorevli, @isim, @soyisim, @profilfoto);";
            db.sorgu(sorgu);
            db.parametreEkle("kullanici_adi", k.kullaniciAdi);
            db.parametreEkle("sifre", k.sifre);

            if (k.ogrenci == null)
                db.parametreEkle("ogrenci", 0);
            else
                db.parametreEkle("ogrenci", 1);

            if (k.ogretmen == null)
                db.parametreEkle("ogretmen", 0);
            else
            {
                db.parametreEkle("ogretmen", 1);
            }

            if (k.gorevli == null)
                db.parametreEkle("gorevli", 0);
            else
            {
                db.parametreEkle("gorevli", 1);
            }

            db.parametreEkle("isim", k.isim);
            db.parametreEkle("soyisim", k.soyisim);
            db.parametreEkle("profilfoto", "");

            db.baslat();
            db.calistir();
            db.kapat();
        }
    }
}
