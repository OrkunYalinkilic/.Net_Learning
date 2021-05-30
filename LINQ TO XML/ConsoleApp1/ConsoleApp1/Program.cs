using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daha çok linq to xml kullanılır. Bir önceki konu olan system.xml 'in mantığını anlamak yeterli..

            XDocument XDoc = new XDocument( // Genel dokuman ismi oluyor.
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("VeriTabanim",
                new XComment("Personellerim Bilgilerini Taşır."),
                new XElement("Personellerim", new XAttribute("ID", "102"),
                new XElement("Isim", "Orkun"),
                new XElement("Soyisim", "Yalinkilic"),
                new XElement("EMailAdres", "orkunyalinkilic69@gmail.com")
                )
                )
                );
            XDoc.Save(@"d:\XML\Ornek.xml");


        }
    }
}
