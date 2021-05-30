using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> Musterilerim = new List<Musteri>();

            for (int i = 0; i < 50; i++)
            {
                Musteri temp = new Musteri();
                temp.ID = i.ToString();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.EMailAdres = temp.isim + "." + temp.soyisim + "@" + FakeData.NetworkData.GetDomain();
                temp.telefonNo = FakeData.PhoneNumberData.GetPhoneNumber();

                Musterilerim.Add(temp);

            }
            StreamReader SR = new StreamReader(@"d:\\CSV\Musteriler.csv");
            CsvHelper.CsvReader reader = new CsvHelper.CsvReader(SR);
            List<Musteri> OkunanData = reader.GetRecords<Musteri>().ToList();

            Console.WriteLine("Okuma islemi tamamlandı.");

            StreamWriter SW = new StreamWriter(@"d:\\CSV\Musteriler.csv");
            CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);
            write.WriteHeader(typeof(Musteri)); // csv nin kolonlarını belirtmiş oldum.
            foreach (Musteri item in Musterilerim)
            {
                write.WriteRecord(item);
            }

            SW.Close();

            Console.WriteLine("CSV olarak kayıt işlemi tamamlanmıştır.");

        }
    }
}
