using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Okuma
{
    public class XObject
    { // json datamı karşılayacak bir tip oluşturuyorum
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string EMailAdres { get; set; }
        public string telefonNumara { get; set; }
        public string sehir { get; set; }

        public override string ToString()
        {
            return this.isim + " " + this.soyisim;
        }
    }
}
