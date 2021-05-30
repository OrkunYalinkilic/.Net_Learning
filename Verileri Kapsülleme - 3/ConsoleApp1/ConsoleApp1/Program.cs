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
            Musteri m = new Musteri();

            m.Tc_kimlikNo = "11445585377";

            Console.WriteLine(m.Tc_kimlikNo);

            Console.ReadLine();

        }
    }
}
