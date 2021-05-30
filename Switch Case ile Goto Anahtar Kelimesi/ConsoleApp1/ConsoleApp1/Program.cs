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
            string secim;

            YenidenSecim:

            Console.Write("Seciminiz: ");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1": Console.Write("Seciminiz gerçekleşmiştir.."); break;
                case "2": Console.Write("Seciminiz gerçekleşmiştir.."); break;
                case "3": Console.Write("Seciminiz gerçekleşmiştir.."); break;
                default: Console.WriteLine("Gecersiz bir secim yaptiniz.."); goto YenidenSecim;
            }

            Console.ReadLine();
        }
    }
}
