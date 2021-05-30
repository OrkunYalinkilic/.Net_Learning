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
            List<Musteri> musteriListesi = new List<Musteri>();
            musteriListesi.Add(new Musteri()
            {
                id = 1,
                isim = "Orkun",
                soyisim = "yk"
            });
            musteriListesi.Add(new Musteri()
            {
                id = 2,
                isim = "Fatih",
                soyisim = "yk"
            });
            musteriListesi.Add(new Musteri()
            {
                id = 3,
                isim = "Berat",
                soyisim = "yk"
            });

            Console.WriteLine("Musteri Listesi");
            foreach (var item in musteriListesi)
            {
                Console.WriteLine(item.id + " " + item.isim + " " + item.soyisim);
            }

            Console.ReadLine();
        }
    }
}
