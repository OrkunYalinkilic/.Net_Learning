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
            object degisken1= "Orkun";
            object degisken2 = "Fatih";
            object degisken3 = -35350;

            bool kontrol = degisken1 is int;
            string b = degisken2 as string;
            bool kontrol2 = degisken3 is int;

            Console.WriteLine("{0}", kontrol);
            Console.WriteLine("{0}", b);
            Console.WriteLine("{0}", kontrol2);

            Console.ReadLine();             
        }
    }
}
