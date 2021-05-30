using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri<T>
    {
        public T id { get; set; }
        public T musteriNumara { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }

        public T musteriNoDondur()
        {
            return this.musteriNumara;
        }
    }
}
