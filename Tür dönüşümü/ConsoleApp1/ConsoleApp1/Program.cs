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
            int a = 125;
            int b = 512;
            int x, y;

            x = (byte)a;

            // y = (byte)b;  //checked blok kısmı yerine sadece bu eklenirse y=0 olur hata verilmez.


            checked
            {
                y = (byte)b;

            }

            Console.Write("x=");
            Console.WriteLine(x);
            Console.Write("y=");
            Console.WriteLine(y);


            Console.ReadLine();

            checked
            {
                y = (byte)b;

            }

        }
    }
}
