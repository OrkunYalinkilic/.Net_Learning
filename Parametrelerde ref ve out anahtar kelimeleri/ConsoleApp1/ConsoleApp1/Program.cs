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
            int sayi1 = 0;
            DegerAta(ref sayi1);

        }

        static public void DegerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
    }

  
}
