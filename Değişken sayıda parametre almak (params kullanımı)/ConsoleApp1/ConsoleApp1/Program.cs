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
            topla("Orkun","yk",20,10,30,28,12);
        }

        static void topla(string isim, string soyisim ,params int[] sayilar)
        {
            int toplam = 0;

            for(int i=0; i<sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Merhaba " + isim);
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();
        }
    }
}
