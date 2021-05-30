using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        public static int sayac = 1;

        public BaseClass()
        {
            _id = sayac;
            sayac++;
        }

        private int _id;
        public int id
        {
            get
            {
                return this._id;
            }
            private set
            {
                //  _id = sayac;  sayac++; işlemini burada yapamam. Çünkü set bloğu private. 
                //  Bu yüzden burada değer atayamam. Ctor'da atadım.

            }
        }
        private string _barkod;
        public string barkod
        {
            get
            {
                return this._barkod;
            }
            set
            {
                if (sanalDatabese.barkodDatabeseKontrol(value) == true)
                {
                    Console.WriteLine("Girmis oldugunuz barkod numarasina ait urun zaten bulunmaktadir..");
                }

                else
                {
                    this._barkod = value;
                }
            }
        }

        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarihi { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }

        /*  İd değerini kullanıcı giremiyor. İd değeri içerideki bir sayaca göre değer alıyor..   */

    }
}
