using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //debug modunda incele

            YeniKlasorOlustur("d:\\udemy1");
            YeniKlasorOlustur("d:\\udemy2");
            YeniKlasorOlustur("d:\\udemy3");

            bool kontrol = KlasorVarlikKontrol("d:\\udemy1");

            klasorSil1("d:\\udemy1");
            klasorSil2("d:\\udemy2");
            klasorSil2("d:\\udemy3");

            //KlasorTasima("c:\\Udemy", "c:\\TasimaIslemi\\Udemy");

        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path);
        }

        static bool KlasorVarlikKontrol(String path)
        {
           bool kont = Directory.Exists(path);
            return kont;
        }

        static void klasorSil1(string path)
        {
            Directory.Delete(path);
        }

        static void klasorSil2(string path)
        {
            Directory.Delete(path, true);
        }

        static void KlasorTasima(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }


    }
}
