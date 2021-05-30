using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.isim = "Orkun";
            m1.soyisim = "yk";
            m1.emailAdres = "fdks@kf.com";
            m1.id = 321421;
            m1.musteriNumara = "MSN24";

            SanalDatabese sb = new SanalDatabese();
            musteriReturnValue kayitSonuc = sb.yeniMusteriKayit(m1);

            /*if(kayitSonuc ==717770001)
            {
                //........  // BU OKUNAKSIZ DÜZENSİZ
            }*/

            if (kayitSonuc == musteriReturnValue.kayitBasarili)
            {
                Console.WriteLine("Kayit islemi basarili..");
            }

            int intEnum1 = (int)musteriReturnValue.kayitBasarili;
            int intEnum2 = (int)musteriReturnValue.kayitBasarisiz;
            int intEnum3 = (int)musteriReturnValue.calismaZamaniHatasi;
            int intEnum4 = (int)musteriReturnValue.parametreHatasi;
            int intEnum5 = (int)musteriReturnValue.varolanMusteri;

            Console.WriteLine(intEnum1 + " " + intEnum2 + " " + intEnum3 + " " + intEnum4 + " " + intEnum5);

            Console.ReadLine();

        }
    }
}
