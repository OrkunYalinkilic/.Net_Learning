using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic adından da belli oldugu gibi her aldıgı tipe bürünebiliyor. var gibi değil. Çok daha esnek.
            //var da ilk atadıgın deger neyse o tipe dönüşüyor. Ama dynamic de öyle bir durum yok. Her şeye eşitlenebilir.
            //Bir deger ataması yapıldıgında hala o tipe dönüşmez. 
            //Uygulamanın bazı yerlerinde ne geleceğini bilmiyorsak vs kullanılabilir. var da kullanılabilir.
            //Dynamic'in metodları yok. Ama bir object'in fonksiyonları kullanılabilir.
            // Özetle dynamic anlık veri saklamak için kullanılabilrir.
            dynamic deger = "Orkun Yalinkilic";
            deger = 5.5;
            deger = true;
            deger = 12312123;
            deger = new
            {
                ad = "orkun",
                soyad = "yk",
                yas = 22
            };

        }
    }
}
