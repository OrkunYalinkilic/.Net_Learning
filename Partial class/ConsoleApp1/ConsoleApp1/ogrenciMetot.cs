using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class ogrenci
    {
        public int ogrenciEkle(string isim, string soyisim, string ogrNo)
        {
            Console.WriteLine("Ogrenci Kaydedildi.");
            return 1;
        }

        public int ogrenciSil(string ogrNo)
        {
            Console.WriteLine("Ogrenci Silindi.");
            return 1;
        }
    }
}
