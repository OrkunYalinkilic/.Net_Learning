using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun : baseClass
    {
        public int alis { get; set; }
        public int satis { get; set; }

        public override void ekranaYaz(string data)
        {
            Console.WriteLine("print: " + data);
        }

    }

}

