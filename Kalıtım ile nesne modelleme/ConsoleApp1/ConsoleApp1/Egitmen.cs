using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Egitmen:Personel
    {
        public string brans { get; set; }
        public int bransUzmanlik { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Egitmen kurucu fonksiyon çalıştı..");,
            degiskenMetot();
        }

    }
}
