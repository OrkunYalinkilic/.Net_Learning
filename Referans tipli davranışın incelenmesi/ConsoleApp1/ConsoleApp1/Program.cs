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

            int a = 5;
            int b = 10;

            {
                int toplam = 100;
                int toplam2 = a + b;
                Console.WriteLine(toplam);
                Console.WriteLine(toplam2);
            }

           /* HATA 
                    Console.WriteLine(toplam);
                    Console.WriteLine(toplam2);
            */

            Console.ReadLine();

        }
    }
}
