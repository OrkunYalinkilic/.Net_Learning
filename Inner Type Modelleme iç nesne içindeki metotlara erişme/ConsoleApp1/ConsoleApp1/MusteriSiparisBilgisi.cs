using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MusteriSiparisBilgisi
    {
        public string siparisNumarasi { get; set; }
        public Urun[] urunler;

        public MusteriSiparisBilgisi()
        {
            urunler = new Urun[5];
        }

        public void siparistestmetot()
        {
            Console.WriteLine("Siaris test metot");
        }
    }
}
