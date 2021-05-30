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
            Musteri<int> m1 = new Musteri<int>();
            m1.id = 1;
            m1.tcKimlikNo = "243215432234";
            m1.musteriNumara = 3;
            m1.isim = "Orkun";
            m1.soyisim = "yk";
            m1.dogumTarih = DateTime.Parse("21.11.1998");

            Console.WriteLine(m1.musteriNoDondur());

            Musteri<Guid> m2 = new Musteri<Guid>();
            m1.id = 1;
            m1.tcKimlikNo = "243215432234";
            m1.musteriNumara = 6;
            m1.isim = "Orkun";
            m1.soyisim = "yk";
            m1.dogumTarih = DateTime.Parse("21.11.1997");

            Console.WriteLine(m1.musteriNoDondur());
            Console.ReadLine();


        }
    }
}
