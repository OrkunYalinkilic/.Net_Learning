using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class temelSinif
    {
        public string ad { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public abstract void yaz(); // metot imzası

        public void adCikar() { 
            Console.WriteLine("\n" + this.ad);
        }

    }
}
