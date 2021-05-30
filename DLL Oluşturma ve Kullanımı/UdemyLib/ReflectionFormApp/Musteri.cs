using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFormApp
{
    public class Musteri
    {
        public Guid id { get; set; }
        public int cariNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string EMailAdres { get; set; }

        public Musteri()
        {

        }
        public Musteri(Guid idd, int cariNumarasi)
        {
            this.id = idd;
            this.cariNo = cariNumarasi;
        }
        public Musteri(Guid ID, int cariNumarasi, string Isim, string Soyisim)
        {
            this.id = ID;
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.cariNo = cariNumarasi;
        }
        public void EkranaYaz()
        {
            Console.WriteLine(id.ToString() + " Cari Numarasi: "
                + this.cariNo.ToString() + " Isim soyisim: " + this.isim + " " + this.soyisim);
        }
        public void cariNoGuncelle(int yeni)
        {
            this.cariNo = yeni;
        }
    }
}
