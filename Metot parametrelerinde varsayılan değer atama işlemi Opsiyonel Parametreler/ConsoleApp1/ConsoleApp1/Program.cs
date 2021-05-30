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
            //debugger modunda incele..
            Hesaplar H1 = new Hesaplar();

            decimal ort1 = H1.ortalama(100, 100);

            Hesaplar H2 = new Hesaplar();

            decimal ort2 = H2.ortalama(100, 100, 100, 100);

        }
    }
}
