using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; }
        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public void iletisimTestMetot()
        {
            Console.WriteLine("Iletisim test metot");
        }
    }
}
