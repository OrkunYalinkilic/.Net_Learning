using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SanalDatabese
    {
        ArrayList sanalDb = new ArrayList();

        /*public int yeniMusteriKayit(Musteri m)
        {
            sanalDb.Add(m);  
            return 717770001; // BU OKUNAKSIZ DÜZENSİZ
        }*/

        public musteriReturnValue yeniMusteriKayit(Musteri m)
        {
            sanalDb.Add(m);
            return musteriReturnValue.kayitBasarili;
        }
    }
}
