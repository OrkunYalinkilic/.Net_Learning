using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class Rehber
    {
        public Guid ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string telefonNumarasiI { get; set; }
        public string telefonNumarasiII { get; set; }
        public string telefonNumarasiIII { get; set; }
        public string EMailAdres { get; set; }
        public string WebAdres { get; set; }
        public string Adres { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }

    }

    
}
