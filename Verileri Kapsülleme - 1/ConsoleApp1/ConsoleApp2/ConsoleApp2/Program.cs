using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Field deger ataması yapılmasın ama deger okunabilsin. */

            Musteri m1 = new Musteri();

            m1.ad = "Orkun";
            m1.soyad = "Yk";
            m1.EmailAdres = "sa@hotmail.com";
            //m1.ID = 53595;

            Console.WriteLine(m1.ad);
            Console.WriteLine(m1.soyad);
            Console.WriteLine(m1.EmailAdres);
            Console.WriteLine(m1.ID.ToString());
            Console.ReadLine();

        }
    }
}
