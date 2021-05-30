using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class sanalDatabese
    {
        /*static sanalDatabese()
        {
            db = new ArrayList();
        }*/

        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(BaseClass data)
        {
            if (string.IsNullOrEmpty(data.barkod))
            {
                Console.WriteLine("Bos barkodlu urun eklenmesi yapilamaz!");
            }           
            else
            {
                db.Add(data);
            }
        }

        public static bool  barkodDatabeseKontrol(string barkod) // static eki önemli
        {
            bool kontrol = false;

            if(db.Count>0 && db!= null)
            {
                for(int i=0; i<db.Count; i++)
                {
                    BaseClass temp = (BaseClass)db[i];

                    if (temp.barkod == barkod ) // Obje çevirilmeli..
                    {
                        kontrol = true;
                        break;
                    }
                }
            }

            return kontrol;
        }

    }
}
