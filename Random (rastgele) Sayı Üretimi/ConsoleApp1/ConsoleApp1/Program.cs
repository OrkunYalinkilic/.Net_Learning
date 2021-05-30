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
            Random rnd = new Random();
            
            for(int i=0; i<10; i++)
            {
                Console.Write(rnd.Next(1, 10) + " ");
            }

            Console.WriteLine();

            Random rnd2 = new Random();

            for(int i=0; i<10; i++)
            {
                Console.Write(rnd2.Next(1, 100) + " ");
            }

            Console.ReadLine();
        }
    }
}
