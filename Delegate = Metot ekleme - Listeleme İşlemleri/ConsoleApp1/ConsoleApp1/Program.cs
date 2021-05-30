using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //debugger modunda incele

        // metot imzası = metodun ne tipte deger döndürfügü + içerisindeki parametreler

        delegate void matematikselIslemler(int sayi1, int sayi2);

        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayilarin toplami:" + (sayi1 + sayi2));
        }

        static void Cikar(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayilarin farki:" + (sayi1 - sayi2));
        }

        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayilarin carpimi:" + (sayi1 * sayi2));
        }

        static void Main(string[] args)
        {
            matematikselIslemler m1 = new matematikselIslemler(Topla); // burada parametre kısmına gelindiginde void,int,int şeklinde bana metot ver diyor zaten.
            m1.Invoke(10, 20); // ilgili delegemi çağırıyorum. İçerde kaç tane metotu işaret ediyosam bu iki deger içim çalış diyorum.

            matematikselIslemler m2 = new matematikselIslemler(Topla);
            m2 += Cikar; 
            m2 += Carp; // şu artık benim delegem sırasıyla topla,cikar,carp olmak üzere 3 metodu işaret ediyor.
            m2.Invoke(30, 2); //metotları sırasıyla çalıştırır.

            Delegate[] isaretEdilenM2Metotlari = m2.GetInvocationList();

            foreach (var item in isaretEdilenM2Metotlari)  
            {
                Console.WriteLine(item.Method.Name);
            }

            Console.WriteLine();

            m2 -= Cikar; // artık cikar metoduna işaret etmiyorum.
            foreach (var item in m2.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine();

            m2 -= Topla;
            foreach (var item in m2.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            m2 -= Carp;

            //Delegate ler bu şekilde uygulama sırasında bazı metotlara artık işaret etmeyebilir veya edebilir.

            Console.ReadLine();

        }
    }
}
