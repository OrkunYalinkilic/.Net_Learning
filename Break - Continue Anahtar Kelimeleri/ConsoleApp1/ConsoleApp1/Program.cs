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
            int sayac = 0;
            for(sayac=0;sayac<15;sayac++)
            {
                if (sayac == 10) { Console.WriteLine("BREAK"); break; }
                if (sayac == 4) { Console.WriteLine("CONTINUE"); continue; }

                Console.WriteLine(sayac);
                
            }
            Console.ReadLine();

        }
    }
}
