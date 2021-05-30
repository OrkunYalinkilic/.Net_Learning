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
            Personel p1 = new Personel();
            p1.isim = "Fatih";
            p1.soyisim = "Yilmaz";
            p1.Email = "fatih.yl";

            Personel p2 = new Personel();
            p2.isim = "Fatih";
            p2.soyisim = "Yilmaz";
            p2.Email = "fatih.yl";

            Personel p3 = new Personel();
            p3.isim = "Fatih";
            p3.soyisim = "Yilmaz";
            p3.Email = "fatih.yl";

            Personel p4 = new Personel();
            p4.isim = "Fatih";
            p4.soyisim = "Yilmaz";
            p4.Email = "fatih.yl";

            Console.ReadLine();

            //STATİC KURUCU SADECE Bİ KERE ÇALIŞIR. S

        }
    }
}
