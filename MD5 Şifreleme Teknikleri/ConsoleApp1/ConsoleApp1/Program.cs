using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifrelenecekMetin = "Orkun1Yalinkilic";

            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] sifrelenecekMetinBytes = System.Text.Encoding.UTF8.GetBytes(sifrelenecekMetin); // metini byte dizisine çevirdim.
            byte[] MD5ComputeBytes = MD5.ComputeHash(sifrelenecekMetinBytes); // metini şifreledik. Bize byte dizi dönüyor.
            string SifrelenenDeger = Convert.ToBase64String(MD5ComputeBytes); // ve onu string'e çevirdim.

            Console.WriteLine(SifrelenenDeger);

            //SifrelenenDeger: "Orkun1Yalinkilic" in MD5 ile şifrelenmiş hali

            Console.ReadLine();

            // MD5 VE SHA GERİYE DÖNÜLMEYECEK ŞEKİLDE ŞİFRELER. SİSTEM YÖNETİCİLERİ DE BİLEMEZ.
            //MD5 kırıldığı için Sha256 sha512 daha çok kullanılır.
        }
    }
}
