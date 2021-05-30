using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikselIslemler.Islemler islem = new MatematikselIslemler.Islemler();
            int sonuc = islem.Topla(12, 2);
            Console.WriteLine("Toplam:" + sonuc);
            Console.ReadLine();

        }
    }
}
