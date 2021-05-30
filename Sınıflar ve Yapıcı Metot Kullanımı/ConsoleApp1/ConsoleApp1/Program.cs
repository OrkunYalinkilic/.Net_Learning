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

            Musteri M2 = new Musteri("Orkun");

            Musteri M3 = new Musteri("Orkun", "YK");

            Musteri M4 = new Musteri("Orkun", "YK", "535433");

            Musteri M5 = new Musteri("Orkun", "YK", "535433", 21);

            Musteri M6 = M4;

            Musteri M7 = M5;

            M2 = null;

            M3= null;

        }
    }
}
