using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {
        string tckimlikno;
        string isim;
        int yas;

        public Musteri()
        {
            isim = "Orkun";
;        }

        public bool musteriKontrol()
        {
            bool kontrol = musteriKontrolDatabese(tckimlikno);
            return kontrol;
        }

        private bool musteriKontrolDatabese(string tckimlikno)
        {
            return true;
        }

        internal void iyiGun() // sadece namespace ' da erişilebilir..
        {
            Console.WriteLine("İyi Günler " + isim);
            Console.ReadLine();
        }
    }
}
