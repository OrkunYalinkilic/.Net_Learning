using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable sozlukHT = new Hashtable();
            string gecici = "";

            do
            {
                Console.Write("Yeni kayit eklemek istiyor musunuz? (E/H) : ");
                string secim = Console.ReadLine();

                if (secim.ToUpper() == "E")
                {

                    Console.Clear();
                    Console.Write("ENG kelimeyi giriniz: ");
                    string ing = Console.ReadLine();
                    bool kontrol = sozlukHT.Contains(ing);
                    if (kontrol)
                    {
                        Console.WriteLine("Girmis oldugunuz kelime sistemimizde zaten kayitli..");
                        Console.Write(ing + " = " + sozlukHT[ing].ToString());
                    }
                    else
                    {
                        Console.Write("TR karsiligini giriniz: ");
                        string tur = Console.ReadLine();

                        sozlukHT.Add(ing, tur);

                        Console.Write("Kayit basariyla eklendi..");
                    }

                    gecici = "1";
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (secim.ToUpper() == "H")
                {
                    Console.Clear();
                    foreach (var item in sozlukHT.Keys)
                    {
                        Console.WriteLine("ENG: " + item + "  TR: " + sozlukHT[item]);
                    }
                    Console.WriteLine("Devam etmek icin bir tusa basin..");
                    Console.ReadLine();
                }

                else
                {
                    Console.Write("Hatali secim yaptiniz\n\n");
                }

            } while (gecici == "1");


        }
    }
}
