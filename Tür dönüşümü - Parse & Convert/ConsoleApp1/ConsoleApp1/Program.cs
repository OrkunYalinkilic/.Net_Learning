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
            string a;
            int toplam; 

            Console.Write("Sayiyi giriniz: ");
            a = Console.ReadLine();

            toplam = 100 + int.Parse(a);
            //toplam = 100 + Convert.ToInt32(a);

            Console.Write(toplam);

            Console.ReadLine();

            Console.Clear();

            string text1 = "250";
            string text2 = null;
            string text3 = "250";
            string text4 = null;

            int x = -1;
            int y = -1;
            x = int.Parse(text1);
            y = int.Parse(text2);
            Console.WriteLine("{0} {1}", x, y);

            int z = -1;
            int t = -1;
            z = Convert.ToInt32(text3);
            t = Convert.ToInt32(text4);
            Console.WriteLine("{0} {1}", z, t);

            Console.ReadLine();

        }
    }
}
