using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {

        public Musteri(int _id, string _isim, string _soyisim)
        {
            this.id = _id;
            this.isim = _isim;
            this.soyisim = _soyisim;
        }

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim + "= " + id ;
        }

    }
}
