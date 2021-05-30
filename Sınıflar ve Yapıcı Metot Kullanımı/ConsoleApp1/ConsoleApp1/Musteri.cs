using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public string tckimlikno;
        public int yas;

        public Musteri()
        {
            isim = "Name";
            soyisim = "Surname";
            tckimlikno = "IdNumber";
            yas = 18;
        }

        public Musteri(string _isim)
        {
            isim = _isim;
            soyisim = "Surname";
            tckimlikno = "IdNumber";
            yas = 18;
        }

        public Musteri(string _isim, string _soyisim)
        {
            isim = _isim;
            soyisim = _soyisim;
            tckimlikno = "IdNumber";
            yas = 18;
        }

        public Musteri(string _isim, string _soyisim, string _tckimlikno)
        {
            isim = _isim;
            soyisim = _soyisim;
            tckimlikno = _tckimlikno;
            yas = 18;

        }

        public Musteri(string _isim, string _soyisim, string _tckimlikno, int _yas)
        {
            isim = _isim;
            soyisim = _soyisim;
            tckimlikno = _tckimlikno;
            yas = _yas;
        }
    }
}
