﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikselIslemler.Islemler islem = new MatematikselIslemler.Islemler();
            int sonuc = islem.Cikar(20, 10);
            Console.WriteLine(sonuc);

            Console.ReadLine(); 
            

        }
    }
}
