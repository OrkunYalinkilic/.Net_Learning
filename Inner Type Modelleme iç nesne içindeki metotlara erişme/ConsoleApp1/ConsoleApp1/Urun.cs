using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun
    {
        public int urunID { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }
        public void testMetot()
        {
            Console.WriteLine("Urun test metot calisti..");
        }

        public Urun()
        {
            Console.WriteLine("Urun constructor çalıştı..");
        }
    }
}
