using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personel
    {
        static public string domain = "orkun.com";

        public string isim { get; set; }
        public string soyisim { get; set; }
        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }

            set
            {
                this._email = value.ToLower() + "@" + domain;
            }
        }

        public Personel()
        {
            Console.WriteLine("STANDART kurucu fonksiyon çalıştı..");
        }

        static Personel()
        {
            Console.WriteLine("STATİC kurucu fonksiyon çalıştı..");
        }
    }
}
