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
            double b = 100;
            byte d= 125;
            string e= "Orkun";

            object w = a;
            object x = b;
            object z = d;
            object t = e;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(e);

            a = (int)d;
            Console.WriteLine();
            Console.WriteLine(a);

            Console.ReadLine();


        }
    }
}
