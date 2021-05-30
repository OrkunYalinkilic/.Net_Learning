using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Musteri
    {

        public string ad;
        public string soyad;

        private string emailAdres;

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

    }
}
