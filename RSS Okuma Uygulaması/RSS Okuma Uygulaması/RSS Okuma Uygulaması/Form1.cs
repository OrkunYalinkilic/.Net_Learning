using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSS_Okuma_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            lstBaslik.DataSource = XmlCevir();
        }
        private List<Haber> XmlCevir()
        {
            //XML içerisinde item'lar var. İtem'ların içerisinde title,link,description,guid vs var.   

            List<Haber> HaberKayitlari = new List<Haber>();

            XDocument XMLKaynak = XDocument.Load(txtUrl.Text);
            List<XElement> rows = XMLKaynak.Descendants("item").ToList(); 
            // kaynak içerisindeki item elementleri çekilerek, rows adındaki XElement listesine atıldı.
            //Descendants çekme işlemi yapıyor..
            foreach (XElement item in rows)
            {
                Haber temp = new Haber();
                temp.Baslik = item.Element("title").Value; // item'in içerisindeki title'ın değeri
                temp.link = item.Element("link").Value; 
                temp.Aciklama = item.Element("description").Value;
                HaberKayitlari.Add(temp);
            }
            return HaberKayitlari;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox islemdekiListe = (ListBox)sender;
            Haber secilenHaber = (Haber)islemdekiListe.SelectedItem;
            webBrowser.DocumentText = secilenHaber.Aciklama;
        }
    }
}
