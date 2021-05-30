using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BusinessLogicLayer // İÇERİDEKİLERİ NESNELERİ ÖNCE BELLEĞE ÇIKARIYOR ÖRNEKLEYEREK.
    {
        DataAccessLayer DAL; 
        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer(); // DATAACCES DE RAM'E ÇIKIYO(KURUCU İLE)
            // Yani aslında bll örneklenirken arkada dal 'e diyorki sende örneklen..
        }

        internal int veriKaydet(int musteriID, string isim, string soyisim)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim))
            {
                Musteri m1 = new Musteri();
                m1.MusteriID = musteriID;
                m1.isim = isim;
                m1.soyisim = soyisim;

                return DAL.VeriKaydet(m1); // Bu şekilde bir üst katmana aktardık.
            }
            else
            {
                return -1; // Eksik parametre hatası 
                // Eğer uymuyorsa hiç dal'a gitmeyip işi burda kesiyoruz.
            }
        }
    }
}
