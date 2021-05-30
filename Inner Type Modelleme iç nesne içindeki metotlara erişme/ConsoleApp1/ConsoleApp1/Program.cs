using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            #region M1 TEMEL FİELD'LAR EKLENİYOR..

            M1.isim = "Orkun";
            M1.soyisim = "Yalinkilic";
            M1.musteriID = 71;
            M1.olusturmaTarih = DateTime.Now;
            M1.tcKimlikNumarasi = "26243821432";

            #endregion

            #region M1 MUSTERİ ADRESLERİ İSLEMLERİ YAPILIYOR..

            M1.MusteriAdresleri[0] = new MusteriAdres() // Dizi örneklemede 1. yöntem
            {
                il = "İstanbul",
                ilce = "Esenler",
                adresTip = "ev",
                adres = "sdfgfsd gsd sd asfd"
            };

            M1.MusteriAdresleri[1] = new MusteriAdres(); // Dizi örneklemede 2. yöntem
            M1.MusteriAdresleri[1].il = "İstanbul";
            M1.MusteriAdresleri[1].ilce = "Halkali";
            M1.MusteriAdresleri[1].adresTip = "okul";
            M1.MusteriAdresleri[1].adres = "asfdas asfd fas afs";

            M1.MusteriAdresleri[0].musteriAdresTestMetot();

            #endregion

            #region M1 İLETİŞİM BİLGİLERİ YAPILIYOR..

            M1.MusteriIletisimBilgileri[0] = new MusteriIletisimBilgisi()
            {
                aktifPasif = true,
                alanKodu = "+90521",
                numara = "1245678",
                iletisimTip = 1
            };

            M1.MusteriIletisimBilgileri[0].iletisimTestMetot();

            #endregion

            #region M1 SİPARİŞ BİLGİLERİ VE URUN EKLEMESİ YAPILIYOR..

            M1.MusteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "1354334535",
            };

            M1.MusteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                tanim = "Bilgisayar",
                urunID = 745,
                fiyat = 8500,
            };

            M1.MusteriSiparisBilgileri[0].urunler[1] = new Urun()
            {
                tanim = "Telefon",
                urunID = 746,
                fiyat = 1500,
            };
         
            M1.MusteriSiparisBilgileri[0].siparistestmetot();

            #endregion

        }
    }
}

