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
            var bir = "Berat";
            var iki = 6;

            Console.WriteLine(bir + iki);

            Musteri m1 = new Musteri(); //isimli tip
            m1.isim = "Orkun";
            m1.soyisim = "Yalinkilic"; // get ve set 

            Console.WriteLine(m1.isim + m1.soyisim);

            var Ogrenci = new // isimsiz tip
            {
                id = 1,
                ad = "Fatih",
                soyisim = "Yalinkilic",
                yas = 12
            }; // sadece get

            // isimsiz tip sadece get edilebilir. Tool tipte yazıyor.

            Console.WriteLine(Ogrenci.id + Ogrenci.ad + Ogrenci.soyisim + Ogrenci.yas);

            Console.ReadLine();
        }
    }
}
