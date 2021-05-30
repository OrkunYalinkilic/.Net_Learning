using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class temelTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int GuncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("temelTip kurucu fonksiyon çalıştı..");
            idUretmeIslemi();
        }

        private void idUretmeIslemi()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9000);
        }

        public void temelTiptestFonk()
        {
            Console.WriteLine("Temel tip içindeki bir fonksiyon çalıştı..");
        }

        protected void degiskenMetot()
        {
            Console.WriteLine("Protected kullanildi..");
        }
    }
}
