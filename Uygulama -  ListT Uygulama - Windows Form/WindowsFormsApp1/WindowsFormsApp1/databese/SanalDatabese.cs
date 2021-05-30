using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1.databese
{
    class SanalDatabese
    {
        public static List<kullanici> kullaniciTablo;
        public static List<todo> todoTablo;

        static SanalDatabese()
        {
            kullaniciTablo = new List<kullanici>();
            kullaniciTablo.Add(new kullanici() { id = Guid.NewGuid(), kullaniciAdi = "test1", sifre = "1" });
            todoTablo = new List<todo>();
        }
    }
}
