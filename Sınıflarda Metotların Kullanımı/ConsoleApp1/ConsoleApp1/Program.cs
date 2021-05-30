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
            Musteri m = new Musteri();

            bool mkont = m.musteriKontrol();

            m.iyiGun(); // sadece bu isim uzayında çalışır ( kalpli )

        }
    }
}
