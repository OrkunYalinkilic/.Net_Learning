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
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(12);
            sayiListesi.Add(34);

            int[] eklenecekDizi = new int[5] { 90,98,87,76,65};

            sayiListesi.AddRange(eklenecekDizi);

            Console.Write("Sayi Listesi: ");
            sayiListesi.ForEach(i => Console.Write(i + " "));
            Console.ReadLine();
        }
    }
}
