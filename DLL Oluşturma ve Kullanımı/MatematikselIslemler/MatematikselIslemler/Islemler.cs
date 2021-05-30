using System;

namespace MatematikselIslemler
{
    public class Islemler
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        private void ozelMetot1()
        {
            Console.WriteLine("Dll referans edildiginde calismayacaktir.");
        }

    }
}
