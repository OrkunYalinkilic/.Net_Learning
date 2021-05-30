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
            Console.WriteLine(carp(5, 4)); 
            Console.WriteLine( carp(5, 4, 3));
            Console.WriteLine(carp(5, 4, 3, 2));

            Console.ReadLine();
        }

        static int carp(int sayi1, int sayi2 , int sayi3=1, int sayi4 = 1)
            //sayi3 ve veya sayi4 degeri girilmezse default değerlerini atayacak.
            //defalt deger atamaları parametreler içinde en sonda yapılmalıdır.
        {
            return sayi1 * sayi2 * sayi3 * sayi4;
        }
    }
}
