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

            int sayi=0;
            int toplam=0;

            Console.Write("Sayiyi giriniz:");
            string alinan = Console.ReadLine();

            sayi = Convert.ToInt32(alinan);

            while (true)
            {
                if (sayi == 0) break;
                toplam += sayi;
                sayi--;
            }

            Console.Write("Girdiginiz sayidan 0'a kadar olan sayilarin toplami : " + toplam);
            Console.ReadLine();
        }
    }
}
