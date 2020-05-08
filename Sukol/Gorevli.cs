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

            string identity = "select @@IDENTITY from kullanicilar";
            db.sorgu(identity);
            db.calistir();
            int kullaniciId = db.scalar();


            if (k.ogrenci != null)
            {
                string sorgu_ogrenci = "INSERT INTO ogrenciler(okul_no, kullanici_id) " +
                       "VALUES(@okul_no, @kullanici_id);";
                db.sorgu(sorgu_ogrenci);
                db.parametreEkle("okul_no", k.ogrenci.numara);
                db.parametreEkle("kullanici_id", kullaniciId);
                db.calistir();
            }
            if (k.ogretmen != null)
            {
                string sorgu_ogrenci = "INSERT INTO ogretmenler(sinif, kullanici_id) " +
                       "VALUES(@sinif, @kullanici_id);";
                db.sorgu(sorgu_ogrenci);
                db.parametreEkle("sinif", k.ogretmen.sinif);
                db.parametreEkle("kullanici_id", kullaniciId);
                db.calistir();
            }
            if (k.gorevli != null)
            {
            }
            db.kapat();
        }
    }
}
