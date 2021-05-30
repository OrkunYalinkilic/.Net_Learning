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
            int tahminSayaci = 1;
            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 10);

            Console.Write("Tahmininiz: ");
            string tahmin = Console.ReadLine();
            Console.Clear();

            while (int.Parse(tahmin) != uretilenSayi)
            {
                Console.WriteLine("YANLIS TAHMİN");
                Console.WriteLine("Deneme Sayisi: " + tahminSayaci);
                Console.Write("Tahmininiz:");
                tahmin = Console.ReadLine();
                tahminSayaci++;          
                Console.Clear();
            }

            Console.WriteLine("TEBRIKLER DOGRU TAHMİN");
            Console.WriteLine("Deneme Sayisi: " + tahminSayaci);
            Console.Write("Cikis icin herhangi bir tusa basabilirsiniz..");
            Console.ReadLine();
        }
    }
}
