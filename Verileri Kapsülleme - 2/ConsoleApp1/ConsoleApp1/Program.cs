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
            Musteri m1 = new Musteri();

            m1.ad = "Orkun";
            m1.soyad = "YK";
            m1.ID = 64545;

            Console.WriteLine(m1.ad);
            Console.WriteLine(m1.soyad);
          //  Console.Write(m1.ID);
            Console.ReadLine();

        }
    }
}
