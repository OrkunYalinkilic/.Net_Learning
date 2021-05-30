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
            string secim = "";

            YenidenSecim:

            Console.Write("Seciminiz: ");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                case "2":
                case "3":
                case "4":

              Console.WriteLine("Seciminiz 1.fazda gerceklesti..");
              break;

                case "5":
                case "6":
                case "7":
                case "8":

              Console.WriteLine("Seciminiz 2.fazda gerceklesti..");
              break;

                case "9":
                case "10":
                case "11":
                case "12":

             Console.WriteLine("Seciminiz 3.fazda gerceklesti..");
             break;

                default: Console.WriteLine("Hatali secim gerceklesti.."); goto YenidenSecim;

            }

            Console.ReadLine();
        }
    }
}
