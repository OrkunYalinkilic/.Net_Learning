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
            Person p = new Person();
            p.TC = "214231342";
            // p.isim = "orkun"; //HATA

            Console.WriteLine(p.isim); // HATA DEĞİL.
        }
    }
}
