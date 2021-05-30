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
            Personel p1 = new Personel();
           // Personel.domain = "hotmail.com";

            p1.isim = "Orkun";
            p1.soyisim = "Yalinkilic";
            p1.EMailAdres = "orkun.yk";
            p1.cinsiyet = 717722001;

            Helper.mailGonder("berat@windowslive.com", "Yeni Personel Bilgilendirme", p1.isim + " " + p1.soyisim + " " + p1.EMailAdres + " " + p1.cinsiyet);
            Console.ReadLine();

            //static metotları helper classı içinde toplayarak bu şekilde örnek oluşturmadan direkt sınıfın ismiyle kullanabiliyoruz.

        }
    }
}
