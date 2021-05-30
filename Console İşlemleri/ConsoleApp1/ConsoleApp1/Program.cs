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
            string ad, soyad, yas;

            Console.Write("Adinizi giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Soyadinizi giriniz: ");
            soyad = Console.ReadLine();

            Console.Write("Yasinizi giriniz: ");
            yas = Console.ReadLine();

            Console.Clear();

            /*
                string mesaj = yas + "yasindaki kullanicimiz Sayin" ad + soyad + " hosgeldiniz..";
                Console.Write(mesaj);
            */

            /*
                string mesaj2;
                mesaj2= string.Format(" {0} yasindaki kullanicimiz Sayin {1} {2} hosgeldiniz..", yas, ad, soyad);
            */

            Console.Write(" {0} yasindaki kullanicimiz Sayin {1} {2} hosgeldiniz..",yas,ad,soyad);
            Console.ReadLine();
        }
    }
}
