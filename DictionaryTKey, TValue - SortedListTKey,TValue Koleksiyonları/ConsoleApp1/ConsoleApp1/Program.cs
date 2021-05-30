using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //debug modunda incele..

            Hashtable h = new Hashtable();
            h.Add(1, "Orkun");
            h.Add(2, true);
            h.Add("Fatih", 3.5);

            Dictionary<int, string> dictionaryList = new Dictionary<int, string>();
            dictionaryList.Add(1, "Orkun");
            dictionaryList.Add(2, "Fatih");
            dictionaryList.Add(3, "Ali");

            bool silmeSonuc = dictionaryList.Remove(2);

            if (silmeSonuc)
            {
                Console.WriteLine("Silme islemi gerceklesti.");
            }
            else
            {
                Console.WriteLine("Silme islemi gerceklesmedi.");

            }

            bool arananSonuc = dictionaryList.ContainsKey(1);

            if (arananSonuc)
            {
                dictionaryList[1] = "Yenilenen Deger";
            }
            else
            {
                Console.WriteLine("Deger bulunamadi.");
            }

            bool arananSonuc2 = dictionaryList.ContainsValue("Orkun");

            if (arananSonuc2)
            {
                Console.WriteLine("Deger bulundu.");
            }
            else
            {
                Console.WriteLine("Deger bulunamadi.");
            }

            Console.WriteLine("******************************");

            foreach (KeyValuePair<int,string> item in dictionaryList)
            {
                Console.WriteLine("Key:" + item.Key + " Value:" + item.Value);
            }

            dictionaryList.Clear();
            h.Clear();

            SortedList<int, string> sortedListe = new SortedList<int, string>();
            sortedListe.Add(35, "otuzbes");
            sortedListe.Add(1, "bir");
            sortedListe.Add(23, "yirmiuc");
            sortedListe.Add(2, "iki");

         }
    }
}
