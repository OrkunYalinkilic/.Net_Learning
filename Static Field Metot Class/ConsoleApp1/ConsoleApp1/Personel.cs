using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personel
    {
        public static string domain = "windowslive.com";

        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        private string _emailAdres { get; set; }

        public string EMailAdres {
            get
            {
                return this._emailAdres;
            }

            set
            {
                this._emailAdres = value.ToLower() + "@" + domain;
            }
        }
    }
}
