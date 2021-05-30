using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Urun
    {
        public int id { get; set; }
        public string urunTanim { get; set; }
        public string resimYol { get; set; }
        public Image urunResim
        {
            get
            {
                if(!string.IsNullOrEmpty(resimYol))
                {
                    return Image.FromFile(resimYol);
                }

                else
                {
                    return Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\78-) Windows Form - GridView içinde Image nesnesi\WindowsFormsApp1\WindowsFormsApp1\image\no-image.png");
                }



            }
        }
    }
}
