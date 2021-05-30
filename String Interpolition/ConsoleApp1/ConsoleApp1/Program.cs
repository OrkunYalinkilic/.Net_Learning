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
            string isim = "Orkun";
            string soyisim = "Yalinkilic";

            //1.YOL
            Console.WriteLine("Merhaba "+ isim + " " + soyisim);

            //2.YOL
            Console.WriteLine(string.Format("Merhaba {0} {1}",isim,soyisim));

            //YENİ YOL
            Console.WriteLine($"Merhaba {isim} -- {soyisim}");

            Console.ReadLine();
        }
    }
}
