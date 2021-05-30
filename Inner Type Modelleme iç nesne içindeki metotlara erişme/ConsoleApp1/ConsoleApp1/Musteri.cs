using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {
        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciID { get; set; }

        #region Inner Type gerektiren fieldlar

        // Dizi şeklinde oluşturma sebebimiz, musterinin birden fazla adresi, iletisim bilgisi olabileceğindendir.

        public MusteriAdres[] MusteriAdresleri;
        public MusteriIletisimBilgisi[] MusteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] MusteriSiparisBilgileri;

        public Musteri()
        {
            MusteriAdresleri = new MusteriAdres[5];
            MusteriIletisimBilgileri = new MusteriIletisimBilgisi[4];
            MusteriSiparisBilgileri = new MusteriSiparisBilgisi[6];
        }

        #endregion

    }
}
