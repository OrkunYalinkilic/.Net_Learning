using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {
        public string isim { get; set; }
        public string  soyisim { get; set; }
        public int yas { get; set; }

        public void fonk1()
        {
            Console.Write("\nNew olusturdugunda geldi.");
        }

        public static void fonk2()
        {
            Console.Write("New ile olusturulmadan geldi.");
        }

    }
}
