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
            Musteri m1 = new Musteri();
            m1._isim = "Orkun";
            m1.soyisim = "yalinkilic";
            m1.tcKimlikNo = "61523549967";

            Musteri m2= new Musteri();
            m2._isim = "Orkun";
            m2.soyisim = "yalinkilic";
            m2.tcKimlikNo = "6152359967";

            Musteri m3 = new Musteri();
            m3._isim = "Orkun";
            m3.soyisim = "yalinkilic";
            m3.tcKimlikNo = "615235w9967";

        }
    }
}
