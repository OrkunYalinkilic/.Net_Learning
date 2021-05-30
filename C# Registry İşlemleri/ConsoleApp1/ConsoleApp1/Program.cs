using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32; /***/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // yeni bir deger olusturma
            //Registry.CurrentUser.SetValue("Anahtar", "Merhaba Registry");
            // arama kısmına regede yazarsan buna ulaşabilirsin.

            // olusturugumuz degeri  okuma
            string GelenDeger =  Registry.CurrentUser.GetValue("Anahtar").ToString();
            Console.WriteLine("Registry icerisindeki deger: " + GelenDeger);

            Registry.CurrentUser.DeleteValue("Anahtar"); // siler

            Console.ReadLine();

        }
    }
}
