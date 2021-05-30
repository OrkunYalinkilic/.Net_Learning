using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Linq_Nedir__Neden_Avantajlıdır
{
    public class dataSource
    {
        List<Musteri> Musteriler;

        public dataSource()
        {
            Musteriler = new List<Musteri>();
        }

        public List<Musteri> musteriListesi()

        {
            for (int i = 1; i <= 1000; i++)
            {
                Musteri M = new Musteri();
                M.musteriNumara = i;
                M.isim = FakeData.NameData.GetFirstName();
                M.soyisim = FakeData.NameData.GetSurname();
                M.dogumTarih = FakeData.DateTimeData.GetDatetime(new DateTime(1984, 01, 01), new DateTime(1999, 01, 01));
                // getdatetime bizden baslangıç ve bitis tarihleri istiyor. O iki tarih arasında degerler uretecek.
                M.ulke = FakeData.PlaceData.GetCountry();
                M.il = FakeData.PlaceData.GetCity();
                M.il = FakeData.PlaceData.GetCountry();

                M.emailAdres = $"{M.isim.ToLower()}.{M.soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                M.telefonNumara = FakeData.PhoneNumberData.GetPhoneNumber();
                 
                Musteriler.Add(M);
            }

            return Musteriler;
        }


    }
}
