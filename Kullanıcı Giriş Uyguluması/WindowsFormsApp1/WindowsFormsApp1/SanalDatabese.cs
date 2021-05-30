using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SanalDatabese
    {
        public static List<Kullanici> kullaniciTablosu=new List<Kullanici>();

   /**/  static SanalDatabese()
        {
            kullaniciTablosu.Add(new Kullanici()
            {
                id = 1,
                isim = "Orkun",
                soyisim = "Yalinkilic",
                kullaniciAdi = "orkun.yk",
                sifre = "12",
                aciklama = "Orkun Yalınkılıç kullanıcı profil bilgisi",
            });

            kullaniciTablosu.Add(new Kullanici()
            {
                id = 2,
                isim = "Fatih",
                soyisim = "Yalinkilic",
                kullaniciAdi = "fatih.yalink",
                sifre = "123",
                aciklama = "Fatih Yalınkılıç kullanıcı profil bilgisi",
            });

            kullaniciTablosu.Add(new Kullanici()
            {
                id = 3,
                isim = "Berat",
                soyisim = "Yalinkilic",
                kullaniciAdi = "beratpasa.yalink",
                sifre = "12345",
                aciklama = "Berat Yalınkılıç kullanıcı profil bilgisi",
            });
        }
    }
}
