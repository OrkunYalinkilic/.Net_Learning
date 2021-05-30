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
            Console.WriteLine("Merhabalar");
            topla(100, 100);
            topla(100/8,250/4);
            topla("Orkun", "YK");
            Console.ReadLine();
        }

        static void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam= " + toplam);
            
        }

        static void topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam= " + toplam);
        }

        static void topla(string giris1, string giris2)
        {
            Console.WriteLine(giris1 + " " + giris2);
        }
    }
}
