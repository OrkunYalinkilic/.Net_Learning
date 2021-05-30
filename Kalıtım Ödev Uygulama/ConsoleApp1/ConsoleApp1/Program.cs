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

            Bilgisayar b1 = new Bilgisayar();
            //b1.id = 1; // Bu değer set edilemesin. Sadece gösterilsin.
            b1.marka = "Asus";
            b1.model = "z50";
            b1.islemci = "Core i7";
            b1.alisFiyati = 4500M;
            b1.satisFiyati = 4600M;
            b1.kampanyaFiyati = 5000M;
            b1.barkod = "1234567890";

            sanalDatabese.yeniUrunEkle(b1);

            Bilgisayar b2 = new Bilgisayar();
            b2.marka = "Asus";
            b2.model = "z50";
            b2.islemci = "Core i7";
            b2.alisFiyati = 4500M;
            b2.satisFiyati = 4600M;
            b2.kampanyaFiyati = 5000M;
            //b2.barkod = ";

            sanalDatabese.yeniUrunEkle(b2);

            Bilgisayar b3 = new Bilgisayar();
            b3.marka = "Asus";
            b3.model = "z50";
            b3.islemci = "Core i7";
            b3.alisFiyati = 4500M;
            b3.satisFiyati = 4600M;
            b3.kampanyaFiyati = 5000M;
            b3.barkod = "1234567890";

            sanalDatabese.yeniUrunEkle(b3);

            Bilgisayar b4 = new Bilgisayar();
            b4.marka = "Asus";
            b4.model = "z50";
            b4.islemci = "Core i7";
            b4.alisFiyati = 4500M;
            b4.satisFiyati = 4600M;
            b4.kampanyaFiyati = 5000M;
            b4.barkod = "1234567810";

            sanalDatabese.yeniUrunEkle(b3);

            Console.ReadLine();

        }
    }
}
