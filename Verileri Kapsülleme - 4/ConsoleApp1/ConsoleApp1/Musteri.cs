using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Musteri
    {
        public string _isim;
        private string _soyisim;
        private string _eMailAdres;
        private string _tckimlikno;

        public string soyisim
        {
            set
            {
                this._soyisim = value;
                this._eMailAdres = string.Format(this._isim + "." + this._soyisim + "@gmail.com");
            }
            get
            {
                return this._soyisim;

            }
        }

        public string eMailAdres
        {
            get
            {
                return this._eMailAdres;
            }

            private set { }

        }

        public string tcKimlikNo
        {
            get
            {
                return this._tckimlikno;
            }

            set
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("TC Kimlik No 11 Haneden Oluşmalıdır.");
                    Console.ReadLine();
                }

                else
                {
                    bool rakamKontrol = true;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsNumber(value[i]) == false)
                        {
                            rakamKontrol = false;
                            break;
                        }

                    }

                    if (rakamKontrol == false)
                    {
                        Console.Write("TC Kimlik No Rakamlardan Oluşmalıdır..");
                        Console.ReadLine();
                    }

                    else
                    {
                        this._tckimlikno = value;
                    }
            }
        }
    }


}
}
