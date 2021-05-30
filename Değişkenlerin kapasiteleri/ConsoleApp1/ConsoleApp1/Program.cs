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
            Console.WriteLine("İNT");
            int sayi1 = 0;
            sayi1 = int.MaxValue;
            Console.Write("Max Degeri: ");
            Console.WriteLine(sayi1);
            sayi1 = int.MinValue;
            Console.Write("Min Degeri: ");
            Console.WriteLine(sayi1);

            Console.WriteLine("DOUBLE");
            double sayi2 = 0;
            sayi2 = double.MaxValue;
            Console.Write("Max Degeri: ");
            Console.WriteLine(sayi2);
            sayi2 = double.MinValue;
            Console.Write("Min Degeri: ");
            Console.WriteLine(sayi2);

            Console.ReadLine();
        }
    }
}
