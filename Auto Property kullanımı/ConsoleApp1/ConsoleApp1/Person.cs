using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string tc;

        public string TC
        {
            get // get veya set bloğu private a çekilebilir.
            {
                return this.tc;
            }
            set // this.tc value ye eşitlemeden önce çeşitli işlemler yapılabilir.
            {
                this.tc = value;
            }
        }

        public string isim { get; private set; } // sadece okunabilir hale getirdim
    }
}
