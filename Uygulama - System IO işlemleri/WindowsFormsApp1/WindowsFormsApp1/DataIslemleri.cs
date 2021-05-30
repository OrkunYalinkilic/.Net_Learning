using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DataIslemleri
    {
        public DataIslemleri()
        {

        }

        public List<Personel> personelOlustur(int adet)
        {
            List<Personel> Personeller = new List<Personel>();

            for (int i = 0; i <= adet; i++)
            {
                Personeller.Add(new Personel()
                {
                    id = i + 1,
                    isim = FakeData.NameData.GetFirstName(),
                    soyisim = FakeData.NameData.GetSurname(),
                    ulke = FakeData.PlaceData.GetCountry(),
                    firmaAdi = FakeData.NetworkData.GetDomain(),
                    eMailAdres = FakeData.NetworkData.GetEmail()
                });
            }

            return Personeller;
        }

        public void PersonelKaydet(string path, List<Personel> personelListesi)
        {
            DirectoryInfo ulkeBilgisi = null;
            for (int i = 0; i <= personelListesi.Count; i++)
            {
                if (Directory.Exists(path + "\\" + personelListesi[i].ulke) == true)
                {
                    ulkeBilgisi = new DirectoryInfo(path + "\\" + personelListesi[i].ulke);
                }
                else
                {
                    ulkeBilgisi = Directory.CreateDirectory(path + "\\" + personelListesi[i].ulke);
                }
                // Buraya kadar: 
                // Eğer bu klasör varsa o klasörü al ulkeBilgisine eşitle.
                // Eğer bu klasör yoksa o klasörü oluştur ve ulkeBilgisine eşitle.

                FileStream fs = File.Create(ulkeBilgisi.FullName + "\\" + personelListesi[i].isim + "." + personelListesi[i].soyisim + ".txt");


            }


        }

    }
}
