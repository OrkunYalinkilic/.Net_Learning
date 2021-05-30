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

            Musteri M1 = new Musteri(1,"Orkun","YK");
            Musteri M2 = new Musteri(3, "Fatih", "YK");

            Console.WriteLine( M1.ToString() );
            Console.WriteLine(M2.ToString());
            Console.ReadLine();

            
        }
    }
}
