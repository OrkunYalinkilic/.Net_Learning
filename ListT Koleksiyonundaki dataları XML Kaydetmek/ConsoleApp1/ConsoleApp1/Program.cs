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
            #region XML Kaydetme
            List<Ogrenci> Ogrencilerim = new List<Ogrenci>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Ogrenci Temp = new Ogrenci();
            //    Temp.ID = Guid.NewGuid();
            //    Temp.isim = FakeData.NameData.GetFirstName();
            //    Temp.soyisim = FakeData.NameData.GetSurname();
            //    Temp.numara = FakeData.NumberData.GetNumber(100, 500);
            //    Ogrencilerim.Add(Temp);
            //}

            //XDocument doc = new XDocument(
            //    new XDeclaration("1.1", "UTF-8", "yes"),
            //    new XElement("Ogrencilerim",
            //    Ogrencilerim.Select(I => 
            //    new XElement("Ogrenci",
            //    new XElement("id", I.ID),
            //    new XElement("isim", I.isim),
            //    new XElement("soyisim", I.soyisim),
            //    new XElement("Numara", I.numara)
            //    )
            //    )
            //    )
            //    );

            //doc.Save(@"d:\XML\Ogrencilerim.xml");
            #endregion

            #region XML Okuma
            List<Ogrenci> OkunanData = new List<Ogrenci>();

            XDocument docOku = XDocument.Load(@"d:\XML\Ogrencilerim.xml");
            List<XElement> OkunanElementler = docOku.Descendants("Ogrenci").ToList();

            foreach (XElement item in OkunanElementler)
            {
                Ogrenci temp = new Ogrenci();
                temp.ID = Guid.Parse(item.Element("ID").Value);
                temp.isim = item.Element("isim").Value;
                temp.soyisim = item.Element("soyisim").Value;
                temp.numara = int.Parse(item.Element("Numara").Value);
                OkunanData.Add(temp);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
