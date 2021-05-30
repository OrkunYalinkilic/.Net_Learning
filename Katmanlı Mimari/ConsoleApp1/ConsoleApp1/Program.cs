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
            // UI: User Interface :-> Herhangi bir kontrol yok. Kullanıcıya veri gösteriyor veya kullanıcıdan veri alıyor.

            BusinessLogicLayer BLL = new BusinessLogicLayer();
            //int eks = BLL.veriKaydet(1, "Orkun", "Yalinkilic");
            int eks = BLL.veriKaydet(1, string.Empty, "Yalinkilic");

            if (eks>0)
            {
                Console.WriteLine("Islem basarili");
            }
            else
            {
                Console.WriteLine("Islem basarisiz");
            }
            Console.ReadLine();
        }
    }
}
