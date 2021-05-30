using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { // json için newtonsoft.json adlı kütüphaneyi dahil ettim
        static void Main(string[] args)
        {
            List<Personel> Personellerim = new List<Personel>();

            for (int i = 0; i < 1000; i++)
            {
                Personel temp = new Personel();
                temp.id = Guid.NewGuid();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.EMailAdres = temp.isim + temp.soyisim + "@" + FakeData.NetworkData.GetDomain();
                temp.telefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                Personellerim.Add(temp);
            }

            Console.WriteLine("Bilgileriniz json formatında d içinde jsonislemlerim - personellerim.json'a kayıt edilecektir.");

            if (Directory.Exists("d:\\JSonIslemlerim\\"))
            {
                // İlgili klasör varsa herhangi bir işlem yapmıyoruz.
            }
            else
            {
                Directory.CreateDirectory("d:\\JSonIslemlerim\\"); // böyle bir klasör yoksa oluştu.
            }

            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personellerim);
            // Personellerim listesi json formatına çevirildi..
            File.WriteAllText("d:\\JSonIslemlerim\\Personellerim.json", JsonPersonellerim);
            // Personellerim adında json formatında bir dosya oluşturulup jsonPersonellerim içine basıldı.

            Console.WriteLine("Json Export işlemi tamamlandı..");

            Console.ReadLine();

            Console.ReadLine();

        }
    }
}
