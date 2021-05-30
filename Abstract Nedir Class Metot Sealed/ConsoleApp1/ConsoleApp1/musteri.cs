using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class musteri : temelSinif
    {
        public int musteriId { get; set; }

        public override void yaz()
        {
            Console.WriteLine("musteri sinifi ımplement..");
        }
       
    }
}
