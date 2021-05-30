using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Helper
    {
        public static void mailGonder(string aliciAdres , string mailKonu , string mailIcerik)
        {
            Console.WriteLine(aliciAdres + "\n" + mailKonu + "\n" + mailIcerik);
        }
    }
}
