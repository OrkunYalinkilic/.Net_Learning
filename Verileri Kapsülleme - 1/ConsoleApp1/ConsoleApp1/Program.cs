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
            Musteri M1 = new Musteri();

            M1.ad = "Orkun";
            M1.soyad = "Yalinkilic";

            //M1.emailAdres = "orkunyalinkilic69@gmail.com";

            M1.EmailAdres = "orkunyalinkilic69@gmail.com";

            Console.WriteLine(M1.ad);
            Console.WriteLine(M1.soyad);
            Console.Write(M1.EmailAdres);
            Console.ReadLine();
        }
    }
}
