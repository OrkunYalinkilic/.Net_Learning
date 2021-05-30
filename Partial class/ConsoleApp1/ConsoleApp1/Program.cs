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
            ogrenci o1 = new ogrenci();
            o1.isim = "Orkun";
            o1.soyisim = "Yalinkilic";
            o1.ogrenciNo = "030118132";

            o1.ogrenciEkle("sd","fsd","1325");
            o1.ogrenciSil("423");

            Console.ReadLine();
        }
    }
}
