using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlTextWriter XmlText = new XmlTextWriter(@"d:\XML\Personellerim.xml",System.Text.UTF8Encoding.UTF8);
            //XmlText.WriteComment("Xml İşlemleri"); // Açıklama

            //XmlText.WriteStartElement("Personellerim");  // En dıştaki element başlatıldı.

            //XmlText.WriteStartElement("Personel"); // element içindeki ilk element başlatıldı.
            //XmlText.WriteAttributeString("ID", "1");
            //XmlText.WriteElementString("İsim", "Orkun");
            //XmlText.WriteElementString("Soyisim", "Yalinkilic");
            //XmlText.WriteElementString("EMailAdres", "orkunyalinkilic69@gmail.com");
            //XmlText.WriteEndElement();

            //XmlText.WriteStartElement("Personel"); // element içerisindeki ikinci element 
            //XmlText.WriteAttributeString("ID", "2");
            //XmlText.WriteElementString("İsim", "Ufuk");
            //XmlText.WriteElementString("Soyisim", "Büyük");
            //XmlText.WriteElementString("EMailAdres", "ufuk.büyük@gmail.com");
            //XmlText.WriteEndElement();

            //XmlText.WriteEndElement();
            //XmlText.Close();

            XmlReader XRead = XmlReader.Create(@"D:\XML\Personellerim.xml");
            while (XRead.Read())
            {
                Console.Write(XRead.Name.ToString());
                Console.Write(XRead.Value.ToString() + "\n");
            }
            Console.ReadLine();

        }
    }
}
