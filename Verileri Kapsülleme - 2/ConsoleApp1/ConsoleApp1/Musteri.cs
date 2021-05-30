using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Musteri
    {
        public Musteri()
        {
            ıd = ıdUret();
        }

        public string ad;
        public string soyad;
        private int ıd;

        private int ıdUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }

        public int ID
        {

            set
            {
                this.ıd = value;
            }

            private get
            {
                return this.ıd;
            }
        }

    }
}
