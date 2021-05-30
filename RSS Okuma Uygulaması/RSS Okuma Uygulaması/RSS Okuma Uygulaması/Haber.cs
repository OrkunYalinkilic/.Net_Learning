using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Okuma_Uygulaması
{
    public class Haber
    {
        public string Baslik { get; set; }
        public string link { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return this.Baslik;
        }

    }

}
