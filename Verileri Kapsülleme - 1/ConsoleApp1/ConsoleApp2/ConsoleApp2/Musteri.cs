using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Musteri
    {

        public Musteri()
        {
            this.Id = IdRandom();
        }

        public string ad;
        public string soyad;

        private string emailAdres;

        private int IdRandom()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }

        private int Id;

        public string EmailAdres
        {
            set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }
        }

        public int ID
        {
            get
            {
                return this.Id;
            }

            private set
            {
                this.Id = value;
            }
        }

    }
}
