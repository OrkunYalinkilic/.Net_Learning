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
            //Debugger modunda incele...

            int[] eklenecek = new int[7] { 32, 23, 24, 123, 43, 1, 2};

            List<int> sayilarim = new List<int>();
            sayilarim.AddRange(eklenecek);

            sayilarim.Insert(3,9999);

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i => i > 40);
            bool kontrol3 = sayilarim.Any(o => o > 99999);

            sayilarim.Sort();
            sayilarim.Reverse();

            bool bool1 = sayilarim.Remove(32);
            int silinenAdet = sayilarim.RemoveAll(i => i > 120);
            sayilarim.RemoveAt(2);

            // sayilarim.Clear(); // sayilarim koleksiyonun içindeki tüm sayilari siler.

            int maximum = sayilarim.Max();
            int minumum = sayilarim.Min();
            int toplam = sayilarim.Sum();


        }
    }
}

