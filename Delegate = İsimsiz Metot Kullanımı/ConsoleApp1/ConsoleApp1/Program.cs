using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void ekranaYaz(string isim, string soyisim);

        static void test1Metot(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim);
        }

        static void Main(string[] args)
        {
            // var olan bir metodu delege ye işaret ettirdik.
            ekranaYaz test1 = new ekranaYaz(test1Metot);

            // Run time da fonksiyon oluşturup delegate imize o metoda işaret ettirebiliriz.Yani ismi olmayan bir metoda işaret ettiriyoruz.
            // hızlı bir yöntemdir.
            ekranaYaz test2 = new ekranaYaz(delegate (string Isim, string Soyisim)
            {
                Console.WriteLine(Isim + " " + Soyisim);
            });

            ekranaYaz test3 = (string isim, string soyisim) =>
            {
                Console.WriteLine(isim + " " + soyisim);
            };

            test1("Orkun", "Yalinkilic");

            test2("Berat", "Yalinkilic");

            test3("Fatih", "Yalinkilic");

        }



    }
}
