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
            sayiListesi.Add(321);
            sayiListesi.Add(143);
            //sayiListesi.Add("Orkun"); //hata

            List<string> isimListesi = new List<string>();
            isimListesi.Add("Orkun");
            isimListesi.Add("Fatih");
            isimListesi.Add("Berat");
            //isimListesi.Add(123); //hata

            Console.Write("Sayi Listesi: ");
            for(int i=0; i<sayiListesi.Count; i++)
            {
                Console.Write(sayiListesi[i] + " ");
            }

            Console.Write("\nIsim Listesi: ");
            for(int i=0; i<isimListesi.Count; i++)
            {
                Console.Write(isimListesi[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
