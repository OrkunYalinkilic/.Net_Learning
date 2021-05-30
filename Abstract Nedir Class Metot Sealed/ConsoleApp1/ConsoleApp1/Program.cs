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
            // temelSinif t1 = new temelSinif();  // abstract örneklenmez.

            musteri m1 = new musteri();
            m1.ad = "Orkun";
            m1.guncellemeTarih = DateTime.Now;
            m1.olusturmaTarih = DateTime.Now;
            m1.yaz();
            m1.adCikar();

            superMusteri sm1 = new superMusteri();
            sm1.ad = "Berat";
            sm1.guncellemeTarih = DateTime.Now;
            sm1.olusturmaTarih = DateTime.Now;
            sm1.yaz();
            sm1.adCikar();

            Console.ReadLine();


        }
    }
}
